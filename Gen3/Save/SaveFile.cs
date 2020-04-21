using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace Gen3.Save
{
    public class SaveFile
    {
        internal static uint SizeNormal = 128 * 1024;    //File Size as Dectiated
        internal static uint SizeLow = 120 * 1024; //Lower File Size limit
        internal static uint SizeHigh = 145 * 1024;//Upper File Size limit
        internal Data data;
        internal string FileName;
        internal GameSave GameSaveA;
        internal GameSave GameSaveB;



        internal GameSave.TrainerInfoClass TrainerInfo;
        internal GameSave.TeamItemsClass TeamItems;
        internal GameSave.PCBufferClass[] PCBuffers;
        internal GameSave.PCPokemonsClass _PCPokemons;

        public GameSave.TeamItemsClass _TeamItems { get { return this.TeamItems; } }
        public GameSave.TrainerInfoClass _TrainerInfo { get { return this.TrainerInfo; } }
        public GameSave.PCPokemonsClass PCPokemons { get { return this._PCPokemons; } }
        public SaveFile(string filename)
        {
            this.FileName = filename;
            byte[] arr = System.IO.File.ReadAllBytes(filename);
            if (arr.Length < SizeLow || arr.Length > SizeHigh)
                throw new Exception("Wrong file save Format");
            this.data = new Data(arr);
            this.Initialize();
        }
        internal void Initialize()
        {
            this.GameSaveA = new GameSave(data, 0x000000);
            this.GameSaveB = new GameSave(data, 0x00E000);
            this.TrainerInfo = GameSaveA.TrainerInfo.SaveCount > GameSaveB.TrainerInfo.SaveCount ? GameSaveA.TrainerInfo : GameSaveB.TrainerInfo;
            this.TeamItems = GameSaveA.TrainerInfo.SaveCount > GameSaveB.TrainerInfo.SaveCount ? GameSaveA.TeamItems : GameSaveB.TeamItems;
            this.PCBuffers = GameSaveA.PCBuffers[0].SaveCount > GameSaveB.PCBuffers[0].SaveCount ? GameSaveA.PCBuffers : GameSaveA.PCBuffers;
            this._PCPokemons = new GameSave.PCPokemonsClass(this.PCBuffers);
        }
        public class GameSave
        {
            internal Data data;
            internal uint offset;
            internal Section[] _sections;
            public TrainerInfoClass TrainerInfo;
            public TeamItemsClass TeamItems;
            public PCBufferClass[] PCBuffers;
            internal static uint Size = 57344;
            internal GameSave(Data data, uint offset)
            {
                this.data = data; this.offset = offset;
                this._sections = new Section[14];
                for (uint i = 0; i < 14; i++)
                    this._sections[i] = new Section(data,this.offset+ i * 4096);
                var trainerInfoSection = _sections.Where(x => x.SectionID == 0).Single();
                var dd = _sections.Where(x => x.SectionID == 0).Single().offset;
                this.TrainerInfo = new TrainerInfoClass(data, _sections.Where(x => x.SectionID == 0).Single().offset);
                this.TeamItems = new TeamItemsClass(
                    data,
                    _sections.Where(x => x.SectionID == 1).Single().offset,
                    this.TrainerInfo.SecurityKey,
                    this.TrainerInfo.GameVersion);
                this.PCBuffers = new PCBufferClass[9];
                for (uint i = 0; i < 9; i++)
                    this.PCBuffers[i] = new PCBufferClass(this.data, _sections.Where(x => x.SectionID == i + 5).Single().offset, i);
            }

            public class Section
            {
                internal Data data;
                internal uint offset;
                internal uint[] SectionChecksumableData = new uint[14]
            {
                3884, // 0  - Trainer Info
                3968, // 1  - Team - Items
                3968, // 2  - Game State
                3968, // 3  - Misc Data
                3968, // 4  - Rival Info
                3968, // 5  - PC Buffer A
                3968, // 6  - PC Buffer B
                3968, // 7  - PC Buffer C
                3968, // 8  - PC Buffer D
                3968, // 9  - PC Buffer E
                3968, // 10 - PC Buffer F
                3968, // 11 - PC Buffer G
                3968, // 12 - PC Buffer H
                2000, // 13 - PC Buffer I
            };
                internal Section(Data data,uint offset) { this.data = data; this.offset = offset; }
                public uint SaveCount { get { return this.data.Read.Uint(this.offset + 0xFFC); } }
                public ushort SectionID { get { return this.data.Read.Ushort(this.offset + 0xFF4); } }
                public ushort Checksum { get { return this.data.Read.Ushort(this.offset + 0xFF6); } }
                public bool ChecksumGood
                {
                    get { return this.Checksum == GenerateChecksum(); }
                }
                public ushort GenerateChecksum()
                {
                    uint result = 0;
                    ushort SectionID = this.SectionID;
                    for (uint i =0; i < this.SectionChecksumableData[SectionID]; i += 4)
                        result += this.data.Read.Uint(this.offset+i);
                    byte[] arr = BitConverter.GetBytes(result);
                    ushort re = (ushort)(BitConverter.ToInt16(arr, 0) + BitConverter.ToInt16(arr, 2));
                    return re;
                }
            }
            public class TrainerInfoClass : Section
            {
                internal TrainerInfoClass(Data data, uint offset) : base(data,offset) 
                { 
                    this.data = data;
                    this.offset = offset;
                    this.options = new Options(data, offset);
                }
                public Options options;
                public string PlayerName { get { return this.data.Read.String(this.offset, 7); } }
                public Gender PlayerGender { get { return (Gender)this.data[this.offset + 0x0008]; } }
                public uint TrainerID { get { return this.data.Read.Uint(this.offset + 0x000A); } }
                public ushort TrainerPID { get { return this.data.Read.Ushort(this.offset + 0x000A); } }
                public ushort TrainerSID { get { return this.data.Read.Ushort(this.offset + 0x000C); } }
                public ushort HoursPlayed { get { return this.data.Read.Ushort(this.offset + 0x000E); } }
                public byte MinutesPlayed { get { return this.data.Read.Byte(this.offset + 0x0010); } }
                public byte SecondsPlayed { get { return this.data.Read.Byte(this.offset + 0x0011); } }
                public byte FramesPlayed { get { return this.data.Read.Byte(this.offset + 0x0012); } }
                public Version GameVersion
                {
                    get
                    {
                        byte BT = this.data[this.offset + 0x00AC];
                        if (BT == 0x00)
                            return Version.RS;
                        else if (BT == 0x01)
                            return Version.FL;
                        else return Version.E;
                    }
                }
                public uint SecurityKey
                {
                    get
                    {
                        if (this.GameVersion == Version.E)
                            return this.data.Read.Uint(this.offset + 0x00AC);
                        else if (this.GameVersion == Version.FL)
                            return this.data.Read.Uint(this.offset + 0x0AF8);
                        else return 0;
                    }
                }
                public class Options
                {
                    internal Data data;
                    internal uint offset;
                    internal Options(Data data, uint offset) { this.data = data;this.offset = offset; }
                    public ButtonMode ButtonMode { get { return (ButtonMode)this.data[this.offset + 0x0013]; } }
                    public TextSpeed TextSpeed { get { return (TextSpeed)(this.data[this.offset+0x0014] & 7); } }
                    public Sound SoundMode { get { return this.data[0x0015].GetBit(0) ? Sound.Stereo: Sound.Mono; } }
                    public BattleStyle BattleStyleMode { get { return this.data[this.offset + 0x0015].GetBit(1) ? BattleStyle.Set : BattleStyle.Switch; } }
                    public BattleScene BattleSceneMode { get { return this.data[this.offset + 0x0015].GetBit(2) ? BattleScene.Off : BattleScene.On; } }
                    public byte Frame { get { return (byte)((this.data[this.offset + 0x0014] & 0b11111000) >> 3); } }
                }
            }
            public class TeamItemsClass : Section
            {

                //Interna;
                internal Data data;
                internal uint offset;
                internal uint SecurityKey;
                internal Version v;
                //Public
                public PokemonPartyClass[] PartyPokemons;
                public Item[] PCItems;
                public Item[] Items;
                public Item[] KeyItems;
                public Item[] Balls;
                public Item[] TMCase;
                public Item[] Berries;

                //Private


                internal TeamItemsClass(Data data, uint offset,uint key,Version v) : base(data, offset) { this.data = data; this.offset = offset;
                    this.PartyPokemons = new PokemonPartyClass[6];
                    for (uint i = 0; i < 6; i++)
                        PartyPokemons[i] = new PokemonPartyClass(data, this.offset + (uint)(v == Version.FL ? 0x38 : 0x238) + (i * 100));
                    this.SecurityKey = key;
                    this.v = v;

                    InitializeItems();


                }
                private void InitializeItems()
                {
                    //PCItems
                    this.PCItems    = new Item[(this.v == Version.FL ? 30 : 50)];
                    this.Items      = new Item[(this.v == Version.FL ? 42 : this.v == Version.E ? 30 : 20)];
                    this.KeyItems   = new Item[(this.v == Version.E ? 30 : 20)];
                    this.Balls      = new Item[(this.v == Version.FL ? 13 : 13)];
                    this.TMCase     = new Item[(this.v == Version.FL ? 58 : 64)];
                    this.Berries    = new Item[(this.v == Version.FL ? 43 : 46)];


                    int offPCItems  = this.v == Version.FL ? 0x0298 : 0x0498;
                    int offItems    = this.v == Version.FL ? 0X310 : 0x560;
                    int offKeys     = this.v == Version.RS ? 0x5b0 : this.v == Version.E ? 0x5d8 : 0x03b8;
                    int offBalls    = this.v == Version.RS ? 0x600 : this.v == Version.E ? 0x650 : 0x430;
                    int offTM       = this.v == Version.RS ? 0x640 : this.v == Version.E ? 0x690 : 0x464;
                    int offBerries  = this.v == Version.RS ? 0x740 : this.v == Version.E ? 0x790 : 0x54c;
                    for (uint i = 0; i < (this.v == Version.FL ? 30 : 50); i++)
                        this.PCItems[i] = new Item(this.data, (uint)(this.offset + offPCItems + (i * 4)));
                    for (uint i = 0; i < (this.v == Version.FL ? 42 : this.v == Version.E ? 30 : 20); i++)
                        this.Items[i] = new Item(this.data, (uint)(this.offset + offItems + (i * 4)));
                    for (uint i = 0; i < (this.v == Version.E ? 30 : 20); i++)
                        this.KeyItems[i] = new Item(this.data, (uint)(this.offset + offKeys + (i * 4)));
                    for (uint i = 0; i < (this.v == Version.FL ? 13 : 13); i++)
                        this.Balls[i] = new Item(this.data, (uint)(this.offset + offBalls + (i * 4)));
                    for (uint i = 0; i < (this.v == Version.FL ? 58 : 64); i++)
                        this.TMCase[i] = new Item(this.data, (uint)(this.offset + offTM + (i * 4)));
                    for (uint i = 0; i < (this.v == Version.FL ? 43 : 46); i++)
                        this.Berries[i] = new Item(this.data, (uint)(this.offset + offBerries + (i * 4)));
                }
                public uint TeamSize        { get { return this.data.Read.Uint(this.offset + (uint)(v == Version.FL ? 0x0034:0x0234)); } }
                public uint Money           { get { return this.data.Read.Uint(this.offset + (uint)(v == Version.FL ? 0x0290 : 0x0490)) ^ this.SecurityKey; } }
                public ushort Coins         { get { return (ushort)(this.data.Read.Ushort(this.offset + (uint)(v == Version.FL ? 0x0294 : 0x0494)) ^ (this.SecurityKey & 0xFFFF)); } }

                public class Item
                {
                    internal uint offset;
                    internal Data data;
                    public ushort Index { get { return this.data.Read.Ushort(this.offset); } }
                    public ushort Quantity { get { return this.data.Read.Ushort(this.offset + 2); } }
                    public Item(Data data, uint offset) { this.data = data; this.offset = offset; }
                }
                public class PokemonPartyClass
                {
                    internal Data data;
                    internal uint offset;
                    internal PokemonPartyClass(Data data, uint offset) { this.data = data; this.offset = offset; }
                    public uint PersonalityValue    { get { return this.data.Read.Uint(this.offset + 0x00); } }
                    public uint OTID                { get { return this.data.Read.Uint(this.offset + 0x04); } }
                    public string Nickname          { get { return this.data.Read.String(this.offset + 0x08, 10); } }
                    public Language Language        { get { return (Language)this.data.Read.Ushort(this.offset + 18); } }
                    public string OTName            { get { return this.data.Read.String(this.offset + 20, 7); } }
                    public Marking Markigns         { get { return (Marking)this.data[this.offset + 27]; } }
                    public ushort CheckSum          { get { return this.data.Read.Ushort(this.offset + 28); } }
                    public PokemonDataClass Data { get { return new PokemonDataClass(data,this, this.offset); } }
                    public virtual uint StatusCondition     { get { return this.data.Read.Uint(this.offset + 80); } }
                    public virtual byte Level               { get { return this.data[this.offset + 84]; } }
                    public virtual byte Pokerus             { get { return this.data[this.offset + 85]; } }
                    public virtual ushort CurrentHP         { get { return this.data[this.offset + 86]; } }
                    public virtual ushort TotalHP           { get { return this.data[this.offset + 88]; } }
                    public virtual ushort Attack            { get { return this.data[this.offset + 90]; } }
                    public virtual ushort Defence           { get { return this.data[this.offset + 92]; } }
                    public virtual ushort Speed             { get { return this.data[this.offset + 94]; } }
                    public virtual ushort SPAttack          { get { return this.data[this.offset + 96]; } }
                    public virtual ushort SPDefence         { get { return this.data[this.offset + 98]; } }
                    public class PokemonDataClass
                    {
                        internal Data data;
                        internal uint offset;
                        internal PokemonPartyClass pkm;
                        internal PokemonDataClass(Data data, PokemonPartyClass pkm, uint offset) { this.data = data; this.offset = offset; this.pkm = pkm; }
                        private uint order { get { return this.pkm.PersonalityValue % 24; } }
                        private uint decryptionKey { get { return this.pkm.PersonalityValue ^ pkm.OTID; } }
                        private int[,] orders = new int[,]
                        {
                            { 0,1,2,3 },
                            { 0,1,3,2 },
                            { 0,2,1,3 },
                            { 0,3,1,2 },
                            { 0,2,3,1 },
                            { 0,3,2,1 },
                            { 1,0,2,3 },
                            { 1,0,3,2 },
                            { 2,0,1,3 },
                            { 3,0,1,2 },
                            { 2,0,3,1 },
                            { 3,0,2,1 },
                            { 1,2,0,3 },
                            { 1,3,0,2 },
                            { 2,1,0,3 },
                            { 3,1,0,2 },
                            { 2,3,0,1 },
                            { 3,2,0,1 },
                            { 1,2,3,0 },
                            { 1,3,2,0 },
                            { 2,1,3,0 },
                            { 3,1,2,0 },
                            { 2,3,1,0 },
                            { 3,2,1,0 },
                        };
                        private ushort CheckSum
                        {
                            get
                            {
                                ushort value = 0;
                                for (int i = 0; i < DecryptedData.Length; i += 2)
                                    value += BitConverter.ToUInt16(DecryptedData, i);
                                return value;
                            }
                        }
                        public bool ChecksumGood
                        {
                            get { return this.CheckSum == this.pkm.CheckSum; }
                        }
                        private byte[] DecryptedData
                        {
                            get
                            {
                                List<byte> result = new List<byte>();
                                for (uint i = this.offset + 32; i < this.offset + 80; i += 4)
                                {
                                    var value = this.data.Read.Uint(i) ^ decryptionKey;
                                    foreach (byte x in value.GetBytes())
                                        result.Add(x);
                                }
                                return result.ToArray();
                            }
                        }
                        public ushort Species                   { get { return BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 0] * 12 + 0); } }
                        public ushort HeldItem                  { get { return BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 0] * 12 + 2); } }
                        public uint Experience                  { get { return BitConverter.ToUInt32(this.DecryptedData, orders[this.order, 0] * 12 + 4); } }
                        public byte PPBonuses                   { get { return this.DecryptedData[orders[this.order, 0] * 12 + 8]; } }
                        public byte Friendship                  { get { return this.DecryptedData[orders[this.order, 0] * 12 + 9]; } }
                        public ushort Move1                     { get { return BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 1] * 12 + 0); } }
                        public ushort Move2                     { get { return BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 1] * 12 + 2); } }
                        public ushort Move3                     { get { return BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 1] * 12 + 4); } }
                        public ushort Move4                     { get { return BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 1] * 12 + 6); } }
                        public byte PP1                         { get { return this.DecryptedData[orders[this.order, 1] * 12 + 8]; } }
                        public byte PP2                         { get { return this.DecryptedData[orders[this.order, 1] * 12 + 9]; } }
                        public byte PP3                         { get { return this.DecryptedData[orders[this.order, 1] * 12 + 10]; } }
                        public byte PP4                         { get { return this.DecryptedData[orders[this.order, 1] * 12 + 11]; } }
                        public byte EV_HP                       { get { return this.DecryptedData[orders[this.order, 2] * 12 + 0]; } }
                        public byte EV_Attack                   { get { return this.DecryptedData[orders[this.order, 2] * 12 + 1]; } }
                        public byte EV_Defence                  { get { return this.DecryptedData[orders[this.order, 2] * 12 + 2]; } }
                        public byte EV_Speed                    { get { return this.DecryptedData[orders[this.order, 2] * 12 + 3]; } }
                        public byte EV_SPAttack                 { get { return this.DecryptedData[orders[this.order, 2] * 12 + 4]; } }
                        public byte EV_SPDefence                { get { return this.DecryptedData[orders[this.order, 2] * 12 + 5]; } }
                        public byte Coolness                    { get { return this.DecryptedData[orders[this.order, 2] * 12 + 6]; } }
                        public byte Beauty                      { get { return this.DecryptedData[orders[this.order, 2] * 12 + 7]; } }
                        public byte Cuteness                    { get { return this.DecryptedData[orders[this.order, 2] * 12 + 8]; } }
                        public byte Smartness                   { get { return this.DecryptedData[orders[this.order, 2] * 12 + 9]; } }
                        public byte Toughness                   { get { return this.DecryptedData[orders[this.order, 2] * 12 + 10]; } }
                        public byte Feel                        { get { return this.DecryptedData[orders[this.order, 2] * 12 + 11]; } }
                        public byte PokerusStatus               { get { return this.DecryptedData[orders[this.order, 3] * 12 + 0]; } }
                        public byte MetLocation                 { get { return this.DecryptedData[orders[this.order, 3] * 12 + 1]; } }
                        public Gender OTGender                  { get { return this.DecryptedData[orders[this.order, 3] * 12 + 3].GetBit(7) ? Gender.Female : Gender.Male; } }
                        public Ball Ball                        { get { return (Ball)((this.DecryptedData[orders[this.order, 3] * 12 + 3] & 0b01111000) >> 3); } }
                        public GameOfOrigin GoO                 { get { return (GameOfOrigin)(ushort)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 2) & 0b0000011110000000) >> 7); } }
                        public byte LevelMet                    { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 2) & 0b0000000001111111)); } }
                        public byte IV_HP                       { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 4) & 0b00000000000000000000000000011111)     ); } }
                        public byte IV_Attack                   { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 4) & 0b00000000000000000000001111100000) >> 5); } }
                        public byte IV_Defence                  { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 4) & 0b00000000000000000111110000000000) >> 10); } }
                        public byte IV_Speed                    { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 4) & 0b00000000000011111000000000000000) >> 15); } }
                        public byte IV_SPAttack                 { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 4) & 0b00000001111100000000000000000000) >> 20); } }
                        public byte IV_SPDefence                { get { return (byte)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 4) & 0b00111110000000000000000000000000) >> 25); } }
                        public bool IsEgg                       { get { return this.DecryptedData[orders[this.order, 3] * 12 + 7].GetBit(6); } }
                        public bool SecondAbility               { get { return this.DecryptedData[orders[this.order, 3] * 12 + 7].GetBit(7); } }
                        public ContestRibbon Ribbon_Cool        { get { return (ContestRibbon)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 8) & 0b00000000000000000000000000000111)); } }
                        public ContestRibbon Ribbon_Beauty      { get { return (ContestRibbon)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 8) & 0b00000000000000000000000000111000) >> 3); } }
                        public ContestRibbon Ribbon_Cute        { get { return (ContestRibbon)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 8) & 0b00000000000000000000000111000000) >> 6); } }
                        public ContestRibbon Ribbon_Smart       { get { return (ContestRibbon)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 8) & 0b00000000000000000000111000000000) >> 9); } }
                        public ContestRibbon Ribbon_Tought      { get { return (ContestRibbon)((BitConverter.ToUInt16(this.DecryptedData, orders[this.order, 3] * 12 + 8) & 0b00000000000000000111000000000000) >> 12); } }
                        public bool Ribbon_Champion             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 8].GetBit(6); } }
                        public bool Ribbon_Winning              { get { return this.DecryptedData[orders[this.order, 3] * 12 + 9].GetBit(7); } }
                        public bool Ribbon_Victory              { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(0); } }
                        public bool Ribbon_Artist               { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(1); } }
                        public bool Ribbon_Effort               { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(2); } }
                        public bool Ribbon_Special1             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(3); } }
                        public bool Ribbon_Special2             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(4); } }
                        public bool Ribbon_Special3             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(5); } }
                        public bool Ribbon_Special4             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(6); } }
                        public bool Ribbon_Special5             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 10].GetBit(7); } }
                        public bool Ribbon_Special6             { get { return this.DecryptedData[orders[this.order, 3] * 12 + 11].GetBit(1); } }                        
                    }
                }
                
                
            }
            public class PCBufferClass : Section
            {
                internal Data data;
                internal uint offsets;
                internal uint id;
                internal PCBufferClass(Data data, uint offset,uint id) : base(data, offset) { this.data = data; this.offset = offset; this.id = id; }
            }
            public class PCPokemonsClass
            {
                public Data data;
                internal PokemonBoxClass[] _pkms;
                public PokemonBoxClass this[uint Box,uint Index]
                {
                    get { return this._pkms[Box*30+Index]; }
                }
                public uint CurrentPCBox
                {
                    get { return this.data.Read.Uint(0); }
                }
                public string[] PCBoxNames
                {
                    get
                    {
                        List<string> result = new List<string>();

                        for (uint i = 0x8344; i < 0x83C2; i += 9)
                            result.Add(this.data.Read.String(i, 9));
                        return result.ToArray();
                    }
                }
                public byte Wallpaper(uint index)
                {
                    if (index > 14)
                        return 255;
                    return this.data[0x83C2 + index];
                }
                internal PCPokemonsClass(PCBufferClass[] pcs)
                {
                    List<byte> d = new List<byte>();
                    for (int i = 0; i < pcs.Length; i++)
                        for (int x = 0; x < pcs[i].SectionChecksumableData[i+5]; x++)
                            d.Add(pcs[i].data[x + pcs[i].offset]);
                    this.data = new Data(d.ToArray());
                    uint index = 4;
                    this._pkms = new PokemonBoxClass[420];
                    for (int i = 0; i < 420; i++)
                    {
                        this._pkms[i] = new PokemonBoxClass(this.data, index);
                        index += 80;
                    }
                }
                        
                public class PokemonBoxClass : TeamItemsClass.PokemonPartyClass
                {
                    internal PokemonBoxClass(Data data, uint offset) : base(data, offset) { this.data = data; this.offset = offset; }
                    public override uint StatusCondition { get { return 0; /*Need caluclation*/ } }
                    public override byte Level { get { return 0; /*Need caluclation*/ } }
                    public override byte Pokerus { get { return 0; /*Need caluclation*/ } }
                    public override ushort Attack { get { return 0; /*Need caluclation*/ } }
                    public override ushort CurrentHP { get { return 0; /*Need caluclation*/ } }
                    public override ushort Defence { get { return 0; /*Need caluclation*/ } }
                    public override ushort SPAttack { get { return 0; /*Need caluclation*/ } }
                    public override ushort SPDefence { get { return 0; /*Need caluclation*/ } }
                    public override ushort Speed { get { return 0; /*Need caluclation*/ } }
                    public override ushort TotalHP { get { return 0; /*Need caluclation*/ } }

                }
            }

        }

    }
}

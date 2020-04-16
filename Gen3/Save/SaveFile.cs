using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Toolbox;
namespace Gen3.Save
{
    public class SaveFile
    {
        internal readonly uint Size = 57344 + 57344 + 8192 + 4096 + 4096;
        private uint GameSaveAStart         = 0x000000;
        private uint GameSaveASize          = 57344;
        private uint GameSaveBStart         = 0x00E000;
        private uint GameSaveBSize          = 57344;
        private uint HoFStart               = 0x01C000;
        private uint HoFSize                = 8192;
        private uint MysteryGiftStart       = 0x01E000;
        private uint MysteryGiftSize        = 4096;
        private uint RecorderBattleStart    = 0x01F000;
        private uint RecorderBattleSize     = 4096;
        internal byte[] Data;
        public byte[] GameSaveAData
        {
            get { return this.Data.Sub(GameSaveAStart, GameSaveASize); }
            set { if (value.Length != GameSaveASize) throw new FormatException("Given array for GameSaveA is not in the corrent Format");
                this.Data.Update(GameSaveAStart, value);
                }
        }
        public byte[] GameSaveBData
        {
            get { return this.Data.Sub(GameSaveBStart, GameSaveBSize); }
            set
            {
                if (value.Length != GameSaveBSize) throw new FormatException("Given array for GameSaveB is not in the corrent Format");
                this.Data.Update(GameSaveBStart, value);
            }
        }
        public byte[] HoFData
        {
            get { return this.Data.Sub(HoFStart, HoFSize); }
            set
            {
                if (value.Length != HoFSize) throw new FormatException("Given array for HoF is not in the corrent Format");
                this.Data.Update(HoFStart, value);
            }
        }
        public byte[] MysteryGiftData
        {
            get { return this.Data.Sub(MysteryGiftStart, MysteryGiftSize); }
            set
            {
                if (value.Length != MysteryGiftSize) throw new FormatException("Given array for MysteryGift is not in the corrent Format");
                this.Data.Update(MysteryGiftStart, value);
            }
        }
        public byte[] RecorderBattleData
        {
            get { return this.Data.Sub(RecorderBattleStart, RecorderBattleSize); }
            set
            {
                if (value.Length != RecorderBattleSize) throw new FormatException("Given array for MysteryGift is not in the corrent Format");
                this.Data.Update(RecorderBattleStart, value);
            }
        }
        public GameSave GameSaveA;
        public GameSave GameSaveB;
        public SaveFile(string FileName)
        {
            byte[] temp = File.ReadAllBytes(FileName);
            if (temp.Length != this.Size)
                throw new Exception("The given file is not a valid RB/E/LF Save File");
            this.Data = temp;
            Initialize();
        }
        public PlayerClass Player;
        public OptionsClass Options;
        public PCBoxClass PCBoxes;
        public PokedexClass Pokedex;

        public class PokedexClass
        {
            SaveFile sv;
            public SeenClass Seen;
            public OnwedClass Onwed;
            internal byte[] PokedexSeenA
            {
                get { return this.sv.GameSaveA.sections[0].wholeData.Sub(0x005C, 49); }
            }
            public class OnwedClass
            {
                SaveFile sv;
                public bool this[uint PokemonID]
                {

                    get
                    {
                        if (PokemonID > 277)
                            PokemonID -= 25;
                        var ByteIndex = (uint)(PokemonID / 8);
                        var BitIndex = (uint)(PokemonID % 8);
                        return this.sv.GameSaveA.sections[0].wholeData[0x0028 + ByteIndex].GetBit(BitIndex);
                    }
                    set
                    {
                        if (PokemonID > 277)
                            PokemonID -= 25;
                        var ByteIndex = (uint)(PokemonID / 8);
                        var BitIndex = (uint)(PokemonID % 8);
                        this.sv.GameSaveA.sections[0].wholeData[0x0028 + ByteIndex].SetBit(BitIndex, value);
                    }
                }
                internal OnwedClass(SaveFile sv) { this.sv = sv; }
            }
            public class SeenClass
            {

                internal Dictionary<Game, uint> A = new Dictionary<Game, uint>()
                {
                    {Game.E, 0x005C },
                    {Game.RS, 0x005C },
                    {Game.FL, 0x005C }
                };
                internal Dictionary<Game, uint> B = new Dictionary<Game, uint>()
                {
                    {Game.E, 0x0988 },
                    {Game.RS, 0x0938 },
                    {Game.FL, 0x05F8 }
                };
                internal Dictionary<Game, uint> C = new Dictionary<Game, uint>()
                {
                    {Game.E, 0x0CA4 },
                    {Game.RS, 0x0C0C },
                    {Game.FL, 0x0B98 }
                };
                SaveFile sv;
                public bool this[uint PokemonID]
                {
                    
                    get 
                    {
                        if (PokemonID > 277)
                            PokemonID -= 25;
                        var ByteIndex = (uint)(PokemonID / 8);
                        var BitIndex = (uint)(PokemonID % 8);
                        return this.sv.GameSaveA.sections[0].wholeData[A[this.sv.GameType] + ByteIndex].GetBit(BitIndex);
                    }
                    set 
                    {
                        if (PokemonID > 277)
                            PokemonID -= 25;
                        var ByteIndex = (uint)(PokemonID / 8);
                        var BitIndex = (uint)(PokemonID % 8);
                        this.sv.GameSaveA.sections[0].wholeData[A[this.sv.GameType] + ByteIndex].SetBit(BitIndex, value);
                        this.sv.GameSaveA.sections[1].wholeData[B[this.sv.GameType] + ByteIndex].SetBit(BitIndex, value);
                        this.sv.GameSaveA.sections[4].wholeData[C[this.sv.GameType] + ByteIndex].SetBit(BitIndex, value);

                    }
                }
                internal SeenClass(SaveFile sv) { this.sv = sv; }
            }
            internal PokedexClass(SaveFile sv) { this.sv = sv; this.Seen = new SeenClass(sv); this.Onwed = new PokedexClass.Onwed(sv); }
            
        }
        public class PlayerClass
        {
            internal SaveFile sv;
            internal PlayerClass(SaveFile sv)
            {
                this.sv = sv;
            }
            public string Name
            {
                get { return sv.GameSaveA.sections[0].wholeData.Sub(0x0000, 7).Decode(); }
                set { throw new NotImplementedException(); }
            }
            public Gender Gender
            {
                get { return (Gender)sv.GameSaveA.sections[0].wholeData.Sub(0x0008, 1)[0]; }
                set { throw new NotImplementedException(); }
            }
            public uint TrainerID
            {
                get { return BitConverter.ToUInt32(sv.GameSaveA.sections[0].wholeData, 0x000A); }
            }
            public ushort PublicID
            {
                get { return BitConverter.ToUInt16(BitConverter.GetBytes(this.TrainerID), 0); }
                set { throw new NotImplementedException(); }
            }
            public ushort SecretID
            {
                get { return BitConverter.ToUInt16(BitConverter.GetBytes(this.TrainerID), 2); }
                set { throw new NotImplementedException(); }
            }
            public ushort HoursPlayed
            {
                get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[0].wholeData, 0x000E); }
                set { throw new NotImplementedException(); }
            }
            public byte MinutesPlayed
            {
                get { return this.sv.GameSaveA.sections[0].wholeData[0x0010]; }
                set { throw new NotImplementedException(); }
            }
            public byte SecondsPlayed
            {
                get { return this.sv.GameSaveA.sections[0].wholeData[0x0011]; }
                set { throw new NotImplementedException(); }
            }
            public byte FramesPlayer
            {
                get { return this.sv.GameSaveA.sections[0].wholeData[0x0012]; }
                set { this.sv.GameSaveA.sections[0].wholeData[0x0012] = value ; }//asdasdasdasdasd
            }
            public uint Money
            {
                get 
                {
                    if (this.sv.GameType == Game.FL)
                        return(uint)(BitConverter.ToInt32(this.sv.GameSaveA.sections[1].wholeData, 0x0290) ^ this.sv.SecurityKey);
                    else return (uint)(BitConverter.ToInt32(this.sv.GameSaveA.sections[1].wholeData, 0x0490) ^ this.sv.SecurityKey);
                }
                set { throw new NotImplementedException(); }
            }
            public ushort Coins
            {
                get
                {
                    if (this.sv.GameType == Game.FL)
                        return (ushort)(BitConverter.ToInt16(this.sv.GameSaveA.sections[1].wholeData, 0x0294) ^ this.sv.SecurityKey);
                    else return (ushort)(BitConverter.ToInt16(this.sv.GameSaveA.sections[1].wholeData, 0x0494) ^ this.sv.SecurityKey);
                }
                set { throw new NotImplementedException(); }
            }
            public uint TeamSize
            {
                get
                {
                    if (this.sv.GameType == Game.FL)
                        return (uint)(BitConverter.ToInt16(this.sv.GameSaveA.sections[1].wholeData, 0x034));
                    else return (uint)(BitConverter.ToInt16(this.sv.GameSaveA.sections[1].wholeData, 0x0234));
                }
                set { throw new NotImplementedException(); }
            }
            public Pokemon Pokemon1
            {
                get { return new Pokemon(this.sv,0); }
                set { this.Pokemon1 = value; }
            }
            public Pokemon Pokemon2
            {
                get { return new Pokemon(this.sv, 1); }
                set { this.Pokemon2 = value; }
            }
            public Pokemon Pokemon3
            {
                get { return new Pokemon(this.sv, 2); }
                set { this.Pokemon3 = value; }
            }
            public Pokemon Pokemon4
            {
                get { return new Pokemon(this.sv, 3); }
                set { this.Pokemon4 = value; }
            }
            public Pokemon Pokemon5
            {
                get { return new Pokemon(this.sv, 4); }
                set { this.Pokemon5 = value; }
            }
            public Pokemon Pokemon6
            {
                get { return new Pokemon(this.sv, 5); }
                set { this.Pokemon6 = value; }
            }
            public Dictionary<ushort,ushort> PCItems
            {
                get 
                {
                    Dictionary<ushort, ushort> result = new Dictionary<ushort, ushort>();
                    var start = this.sv.GameType == Game.FL ? 0x0298 : 0x0498;
                    var size = this.sv.GameType == Game.FL ? 120 : 200;
                    for (int i = start; i < start + size; i += 4)
                    {
                        ushort tt = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4)+0));
                        ushort bb = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 2));
                        result.Add(tt, bb);
                    } 
                    return result;
                }
            }
            public Dictionary<ushort, ushort> Items
            {
                get
                {
                    Dictionary<ushort, ushort> result = new Dictionary<ushort, ushort>();
                    var start = this.sv.GameType == Game.FL ? 0x0310 : 0x0560;
                    var size = this.sv.GameType == Game.FL ? 168 : this.sv.GameType == Game.RS ? 80 : 120;
                    for (int i = start; i < start + size; i += 4)
                    {
                        ushort tt = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 0));
                        ushort bb = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 2));
                        if (tt == 0)
                            break;
                        if (this.sv.GameType != Game.RS)
                            bb = (ushort)(bb ^ (this.sv.SecurityKey & 0b00000000000000001111111111111111));
                        if (result.ContainsKey(tt))
                            result[tt] += bb;
                        else result.Add(tt, bb);
                    }
                    return result;
                }
            }
            public Dictionary<ushort, ushort> KeyItems
            {
                get
                {
                    Dictionary<ushort, ushort> result = new Dictionary<ushort, ushort>();
                    var start = this.sv.GameType == Game.FL ? 0x03b8 : this.sv.GameType == Game.RS ? 0x05B0 : 0x05D8;
                    var size = this.sv.GameType == Game.FL ? 120 : this.sv.GameType == Game.RS ? 80 : 120;
                    for (int i = start; i < start + size; i += 4)
                    {
                        ushort tt = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 0));
                        ushort bb = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 2));
                        if (tt == 0)
                            break;
                        if (this.sv.GameType != Game.RS)
                            bb = (ushort)(bb ^ (this.sv.SecurityKey & 0b00000000000000001111111111111111));
                        if (result.ContainsKey(tt))
                            result[tt] += bb;
                        else result.Add(tt, bb);
                    }
                    return result;
                }
            }
            public Dictionary<ushort, ushort> Balls
            {
                get
                {
                    Dictionary<ushort, ushort> result = new Dictionary<ushort, ushort>();
                    var start = this.sv.GameType == Game.FL ? 0x0430 : this.sv.GameType == Game.RS ? 0x0600 : 0x0650;
                    var size = this.sv.GameType == Game.FL ? 52 : this.sv.GameType == Game.RS ? 64 : 64;
                    for (int i = start; i < start + size; i += 4)
                    {
                        ushort tt = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 0));
                        ushort bb = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 2));
                        if (tt == 0)
                            break;
                        if (this.sv.GameType != Game.RS)
                            bb = (ushort)(bb ^ (this.sv.SecurityKey & 0b00000000000000001111111111111111));
                        if (result.ContainsKey(tt))
                            result[tt] += bb;
                        else result.Add(tt, bb);
                    }
                    return result;
                }
            }
            public Dictionary<ushort, ushort> TMs
            {
                get
                {
                    Dictionary<ushort, ushort> result = new Dictionary<ushort, ushort>();
                    var start = this.sv.GameType == Game.FL ? 0x00464 : this.sv.GameType == Game.RS ? 0x0640 : 0x0690;
                    var size = this.sv.GameType == Game.FL ? 232 : this.sv.GameType == Game.RS ? 256 : 256;
                    for (int i = start; i < start + size; i += 4)
                    {
                        ushort tt = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 0));
                        ushort bb = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 2));
                        if (this.sv.GameType != Game.RS)
                            bb = (ushort)(bb ^ (this.sv.SecurityKey & 0b00000000000000001111111111111111));
                        if (result.ContainsKey(tt))
                            result[tt] += bb;
                        else result.Add(tt, bb);
                    }
                    return result;
                }
            }
            public Dictionary<ushort, ushort> Berries
            {
                get
                {
                    Dictionary<ushort, ushort> result = new Dictionary<ushort, ushort>();
                    var start = this.sv.GameType == Game.FL ? 0x054C : this.sv.GameType == Game.RS ? 0x0740 : 0x0790;
                    var size = this.sv.GameType == Game.FL ? 172 : this.sv.GameType == Game.RS ? 184 : 184;
                    for (int i = start; i < start + size; i += 4)
                    {
                        ushort tt = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 0));
                        ushort bb = (BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, start + (((i - start) / 4) * 4) + 2));
                        if (this.sv.GameType != Game.RS)
                            bb = (ushort)(bb ^ (this.sv.SecurityKey & 0b00000000000000001111111111111111));
                        if (result.ContainsKey(tt))
                            result[tt] += bb;
                        else result.Add(tt, bb);
                    }
                    return result;
                }
            }

            
            public class Pokemon
            {
                public virtual uint Personality
                {
                    get { return BitConverter.ToUInt32(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number))); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number)),value); }
                }
                public uint OTID
                {
                    get { return BitConverter.ToUInt32(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number)+4)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number)+4), value); }
                }
                public string Nickaname
                {
                    get { return this.sv.GameSaveA.sections[1].wholeData.Sub((start + (100 * number) + 8),10).Decode(jp: (this.Language == Language.Japanese)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((start + (100 * number) + 8), value,10); }
                }
                public Language Language
                {
                    get { return (Language)BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 18)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 18), (uint)value); }
                }
                public string OTName
                {
                    get { return this.sv.GameSaveA.sections[1].wholeData.Sub((start + (100 * number) + 20), 7).Decode(jp: (this.Language == Language.Japanese)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((start + (100 * number) + 20), value, 7); }
                }
                public Marking Markings
                {
                    get { return (Marking)this.sv.GameSaveA.sections[1].wholeData[start + (100 * number) + 27]; }
                    set { this.sv.GameSaveA.sections[1].wholeData[start + (100 * number) + 27] = (byte)value; }
                }
                public ushort Checksum
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 28)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 28), value); }
                }
                public byte Level
                {
                    get { return this.sv.GameSaveA.sections[1].wholeData[start + (100 * number) + 84]; }
                    set { this.sv.GameSaveA.sections[1].wholeData[start + (100 * number) + 84] = value; }
                }
                public byte Pokerus
                {
                    get { return this.sv.GameSaveA.sections[1].wholeData[start + (100 * number) + 85]; }
                    set { this.sv.GameSaveA.sections[1].wholeData[start + (100 * number) + 85] = value; }
                }
                public ushort CurrentHP
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 86)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 86), value); }
                }
                public ushort TotalHP
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 88)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 88), value); }
                }
                public ushort Attack
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 90)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 90), value); }
                }
                public ushort Defense
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 92)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 92), value); }
                }
                public ushort Speed
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 94)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 94), value); }
                }
                public ushort SPAttack
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 86)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 86), value); }
                }
                public ushort SPDefence
                {
                    get { return BitConverter.ToUInt16(this.sv.GameSaveA.sections[1].wholeData, (int)(start + (100 * number) + 98)); }
                    set { this.sv.GameSaveA.sections[1].wholeData.Update((uint)(start + (100 * number) + 98), value); }
                }
                public PokemonData Data
                {
                    get { return new PokemonData(this); }
                }
                public byte[] EncryptedData
                {
                    get { return this.sv.GameSaveA.sections[1].wholeData.Sub((uint)(start + (100 * number) + 32), 48); }
                }
                internal SaveFile sv;
                internal uint number;
                internal uint start;
                public class PokemonData
                {
                    internal List<List<string>> dd = new List<List<string>>
                    {
                        new List<string>(){"G","A","E","M"},
                        new List<string>(){"G","A","M","E"},
                        new List<string>(){"G","E","A","M"},
                        new List<string>(){"G","E","M","A"},
                        new List<string>(){"G","M","A","E"},
                        new List<string>(){"G","M","E","A"},
                        new List<string>(){"A","G","E","M"},
                        new List<string>(){"A","G","M","E"},
                        new List<string>(){"A","E","G","M"},
                        new List<string>(){"A","E","M","G"},
                        new List<string>(){"A","M","G","E"},
                        new List<string>(){"A","M","E","G"},
                        new List<string>(){"E","G","A","M"},
                        new List<string>(){"E","G","M","A"},
                        new List<string>(){"E","A","G","M"},
                        new List<string>(){"E","A","M","G"},
                        new List<string>(){"E","M","G","A"},
                        new List<string>(){"E","M","A","G"},
                        new List<string>(){"M","G","A","E"},
                        new List<string>(){"M","G","E","A"},
                        new List<string>(){"M","A","G","E"},
                        new List<string>(){"M","A","E","G"},
                        new List<string>(){"M","E","G","A"},
                        new List<string>(){"M","E","A","G"},
                    };
                    internal byte[] Growth
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("G") * 12, 12); }
                    }
                    internal byte[] Attacks
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("A") * 12, 12); }
                    }
                    internal byte[] EVs
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("E") * 12, 12); }
                    }
                    internal byte[] Misc
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("M") * 12, 12); }
                    }
                    internal Pokemon sv;
                    public ushort Species
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Growth, 0) ^ DecryprionKey).GetBytes(),0); }
                    }
                    public ushort HeldItem
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Growth, 0) ^ DecryprionKey).GetBytes(), 2); }
                    }
                    public uint Experience
                    {
                        get { return BitConverter.ToUInt32(this.Growth, 4) ^ DecryprionKey; }
                    }
                    public byte PPBonuses
                    {
                        get { return (BitConverter.ToUInt32(this.Growth, 8) ^ DecryprionKey).GetBytes()[0]; }
                    }
                    public byte Friendship
                    {
                        get { return (BitConverter.ToUInt32(this.Growth, 8) ^ DecryprionKey).GetBytes()[1]; }
                    }
                    public ushort Move1
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 0) ^ DecryprionKey).GetBytes(), 0); }
                    }
                    public ushort Move2
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 0) ^ DecryprionKey).GetBytes(), 2); }
                    }
                    public ushort Move3
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 4) ^ DecryprionKey).GetBytes(), 0); }
                    }
                    public ushort Move4
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 4) ^ DecryprionKey).GetBytes(), 2); }
                    }
                    public byte PP1
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[0]; }
                    }
                    public byte PP2
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[1]; }
                    }
                    public byte PP3
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[2]; }
                    }
                    public byte PP4
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[3]; }
                    }
                    public byte HP_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte Attack_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[1]; } }
                    public byte Defence_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[2]; } }
                    public byte Speed_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[3]; } }
                    public byte SPAttack_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte SPDefence_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[1]; } }
                    public byte Coolness_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[2]; } }
                    public byte Beauty_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[3]; } }
                    public byte Cuteness_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte Smartness_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[1]; } }
                    public byte Toughness_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[2]; } }
                    public byte Feel_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[3]; } }
                    public byte PokerusStatus { get { return (BitConverter.ToUInt32(this.Misc, 0) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte MetLocation { get { return (BitConverter.ToUInt32(this.Misc, 0) ^ DecryprionKey).GetBytes()[1]; } }
                    public ushort OriginsInfo { get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Misc, 0) ^ DecryprionKey).GetBytes(),2); } }
                    public byte HP_IV { get { return (byte)((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)           & 0b00000000000000000000000000011111); } }
                    public byte Attack_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)      & 0b00000000000000000000001111100000) >> 5); } }
                    public byte Defence_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)     & 0b00000000000000000111110000000000) >> 10); } }
                    public byte Speed_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)       & 0b00000000000011111000000000000000) >> 15); } }
                    public byte SPAttack_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)    & 0b00000001111100000000000000000000) >> 20); } }
                    public byte SPDefence_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)   & 0b00111110000000000000000000000000) >> 25); } }
                    public bool IsEgg { get { return (((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)              & 0b00000000000000000000000000000011) >> 0) == 0? false : true; } }
                    public byte Ability { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey)      & 0b10000000000000000000000000000000) >> 31); } }
                    public byte Ribbon_Cool { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)        & 0b00000000000000000000000000000111) >> 0); } }
                    public byte Ribbon_Beauty { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)      & 0b00000000000000000000000000111000) >> 3); } }
                    public byte Ribbon_Cute { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)        & 0b00000000000000000000000111000000) >> 6); } }
                    public byte Ribbon_Smart { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)       & 0b00000000000000000000111000000000) >> 9); } }
                    public byte Ribbon_Tought { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)      & 0b00000000000000000111000000000000) >> 12); } }
                    public byte Ribbon_Champion { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000000000000001000000000000000) >> 13); } }
                    public byte Ribbon_Winning { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)     & 0b00000000000000010000000000000000) >> 14); } }
                    public byte Ribbon_Victory { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)     & 0b00000000000000100000000000000000) >> 15); } }
                    public byte Ribbon_Artist { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)      & 0b00000000000001000000000000000000) >> 16); } }
                    public byte Ribbon_Effort { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)      & 0b00000000000010000000000000000000) >> 17); } }
                    public byte Ribbon_Special1 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000000000100000000000000000000) >> 18); } }
                    public byte Ribbon_Special2 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000000001000000000000000000000) >> 19); } }
                    public byte Ribbon_Special3 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000000010000000000000000000000) >> 20); } }
                    public byte Ribbon_Special4 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000000100000000000000000000000) >> 21); } }
                    public byte Ribbon_Special5 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000001000000000000000000000000) >> 22); } }
                    public byte Ribbon_Special6 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey)    & 0b00000010000000000000000000000000) >> 23); } }

                    internal uint DecryprionKey
                    {
                        get { return this.sv.Personality ^ this.sv.OTID; }
                    }
                    private int Modulo;
                    internal PokemonData(Pokemon sv) 
                    { 
                        this.sv = sv;
                        this.Modulo = (int)(sv.Personality % 24);
                        var b = dd[1].IndexOf("G"); 
                    }
                }
                public Pokemon(SaveFile sv,uint number)
                { this.sv = sv; this.number = number; this.start = sv.GameType == Game.FL ? (uint)0x0038 : (uint)0x0238; }
            }
        }
        public class OptionsClass
        {
            internal SaveFile sv;
            internal OptionsClass(SaveFile sv) { this.sv = sv; }
            public ButtonMode ButtonMode
            {
                get { return (ButtonMode)this.sv.GameSaveA.sections[0].wholeData[0x0013]; }
                set { throw new NotImplementedException(); }
            }
            public TextSpeed TextSpeed
            {
                get { return (TextSpeed)(this.sv.GameSaveA.sections[0].wholeData[0x0014] & 0b00000011); }
                set { throw new NotImplementedException(); }
            }
            public byte Frame
            {
                get { return (byte)((this.sv.GameSaveA.sections[0].wholeData[0x0014] & 0b11111000) >> 3); }
                set { throw new NotImplementedException(); }
            }
            public Sound Sound
            {
                get { return (Sound)(this.sv.GameSaveA.sections[0].wholeData[0x0015] & 0b00000001); }
                set { throw new NotImplementedException(); }
            }
            public BattleStyle BattleStyle
            {
                get { return (BattleStyle)((this.sv.GameSaveA.sections[0].wholeData[0x0015] & 0b00000010) >> 1); }
                set { throw new NotImplementedException(); }
            }
            public BattleScene BattleScene
            {
                get { return (BattleScene)((this.sv.GameSaveA.sections[0].wholeData[0x0015] & 0b00000100) >> 2); }
                set { throw new NotImplementedException(); }
            }
        }
        public class PCBoxClass
        {
            internal byte[] PCBuffer
            {
                get
                {
                    var pca = this.sv.GameSaveA.sections[5].wholeData.Sub(0, 3968);
                    var pcb = this.sv.GameSaveA.sections[6].wholeData.Sub(0, 3968);
                    var pcc = this.sv.GameSaveA.sections[7].wholeData.Sub(0, 3968);
                    var pcd = this.sv.GameSaveA.sections[8].wholeData.Sub(0, 3968);
                    var pce = this.sv.GameSaveA.sections[9].wholeData.Sub(0, 3968);
                    var pcf = this.sv.GameSaveA.sections[10].wholeData.Sub(0, 3968);
                    var pcg = this.sv.GameSaveA.sections[11].wholeData.Sub(0, 3968);
                    var pch = this.sv.GameSaveA.sections[12].wholeData.Sub(0, 3968);
                    var pci = this.sv.GameSaveA.sections[13].wholeData.Sub(0, 2000);
                    List<byte> result = new List<byte>();
                    foreach (var x in pca)
                        result.Add(x);
                    foreach (var x in pcb)
                        result.Add(x);
                    foreach (var x in pcc)
                        result.Add(x);
                    foreach (var x in pcd)
                        result.Add(x);
                    foreach (var x in pce)
                        result.Add(x);
                    foreach (var x in pcf)
                        result.Add(x);
                    foreach (var x in pcg)
                        result.Add(x);
                    foreach (var x in pch)
                        result.Add(x);
                    foreach (var x in pci)
                        result.Add(x);
                    return result.ToArray();
                }
            }
            public uint CurrentPCBox
            {
                get { return BitConverter.ToUInt32(this.PCBuffer, 0); }
            }
            public string[] BoxNames
            {
                get
                {
                    List<string> result = new List<string>();
                    for (uint i = 0; i < 14; i++)
                        result.Add(this.PCBuffer.Sub(0x8344 + (i * 9), 9).Decode());
                    return result.ToArray();
                }
            }
            public byte[] BoxWallpapers
            {
                get { return this.PCBuffer.Sub(0x83C2, 14); }
            }
            internal SaveFile sv;
            public Pokemon[] Pokemons = new Pokemon[420];
            public PCBoxClass(SaveFile sv) { this.sv = sv; 
                this.Pokemons = new Pokemon[420];
                for (uint i = 0; i < 420; i++)
                {
                    Pokemons[i] = new Pokemon(this, i);
                }
            }
            public class Pokemon
            {
                internal uint Start
                {
                    get { return (uint)(80 * number + 4); }
                }
                public uint Box
                {
                    get { return (uint)(this.number / 30); }
                }
                public uint Personality
                {
                    get { return BitConverter.ToUInt32(this.PC.PCBuffer, (int)Start); }
                    set { this.PC.PCBuffer.Update((uint)(80 * number), value); }
                }
                public uint OTID
                {
                    get { return BitConverter.ToUInt32(this.PC.PCBuffer, (int)Start + 4); }
                    set { this.PC.PCBuffer.Update((uint)Start + 4, value); }
                }
                public string Nickaname
                {
                    get { return this.PC.PCBuffer.Sub(Start + 8, 10).Decode(jp:(this.Language == Language.Japanese)); }
                    set { this.PC.PCBuffer.Update(Start + 8, value, 10); }
                }
                public Language Language
                {
                    get { return (Language)BitConverter.ToUInt16(this.PC.PCBuffer, (int)Start + 18); }
                    set { this.PC.PCBuffer.Update((uint) Start + 18, (uint)value); }
                }
                public string OTName
                {
                    get { return this.PC.PCBuffer.Sub(Start + 20, 7).Decode(jp: (this.Language == Language.Japanese)); }
                    set { this.PC.PCBuffer.Update(Start + 20, value, 7); }
                }
                public bool IsPokemon
                {
                    get
                    {
                        if (this.PC.PCBuffer[Start + 8] == 0)
                            return false;
                        else return true;
                    }
                }
                public ushort CheckSum
                {
                    get { return BitConverter.ToUInt16(this.PC.PCBuffer,(int)Start+28); }
                    set { this.PC.PCBuffer.Update((uint)Start + 28, value); }
                }
                public byte[] EncryptedData
                {
                    get { return this.PC.PCBuffer.Sub(Start + 32, 48); }
                    set { this.PC.PCBuffer.Update(Start + 32, value); }
                }
                public PokemonData Data
                {
                    get { return new PokemonData(this); }
                }
                internal PCBoxClass PC;
                internal uint number;
                public Pokemon(PCBoxClass Buffer, uint no)
                {
                    this.PC = Buffer;
                    this.number = no;
                }
                public class PokemonData
                {
                    internal List<List<string>> dd = new List<List<string>>
                    {
                        new List<string>(){"G","A","E","M"},
                        new List<string>(){"G","A","M","E"},
                        new List<string>(){"G","E","A","M"},
                        new List<string>(){"G","E","M","A"},
                        new List<string>(){"G","M","A","E"},
                        new List<string>(){"G","M","E","A"},
                        new List<string>(){"A","G","E","M"},
                        new List<string>(){"A","G","M","E"},
                        new List<string>(){"A","E","G","M"},
                        new List<string>(){"A","E","M","G"},
                        new List<string>(){"A","M","G","E"},
                        new List<string>(){"A","M","E","G"},
                        new List<string>(){"E","G","A","M"},
                        new List<string>(){"E","G","M","A"},
                        new List<string>(){"E","A","G","M"},
                        new List<string>(){"E","A","M","G"},
                        new List<string>(){"E","M","G","A"},
                        new List<string>(){"E","M","A","G"},
                        new List<string>(){"M","G","A","E"},
                        new List<string>(){"M","G","E","A"},
                        new List<string>(){"M","A","G","E"},
                        new List<string>(){"M","A","E","G"},
                        new List<string>(){"M","E","G","A"},
                        new List<string>(){"M","E","A","G"},
                    };
                    internal byte[] Growth
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("G") * 12, 12); }
                    }
                    internal byte[] Attacks
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("A") * 12, 12); }
                    }
                    internal byte[] EVs
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("E") * 12, 12); }
                    }
                    internal byte[] Misc
                    {
                        get { return this.sv.EncryptedData.Sub((uint)dd[this.Modulo].IndexOf("M") * 12, 12); }
                    }
                    internal Pokemon sv;
                    public ushort Species
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Growth, 0) ^ DecryprionKey).GetBytes(), 0); }
                    }
                    public ushort HeldItem
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Growth, 0) ^ DecryprionKey).GetBytes(), 2); }
                    }
                    public uint Experience
                    {
                        get { return BitConverter.ToUInt32(this.Growth, 4) ^ DecryprionKey; }
                    }
                    public byte PPBonuses
                    {
                        get { return (BitConverter.ToUInt32(this.Growth, 8) ^ DecryprionKey).GetBytes()[0]; }
                    }
                    public byte Friendship
                    {
                        get { return (BitConverter.ToUInt32(this.Growth, 8) ^ DecryprionKey).GetBytes()[1]; }
                    }
                    public ushort Move1
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 0) ^ DecryprionKey).GetBytes(), 0); }
                    }
                    public ushort Move2
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 0) ^ DecryprionKey).GetBytes(), 2); }
                    }
                    public ushort Move3
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 4) ^ DecryprionKey).GetBytes(), 0); }
                    }
                    public ushort Move4
                    {
                        get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Attacks, 4) ^ DecryprionKey).GetBytes(), 2); }
                    }
                    public byte PP1
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[0]; }
                    }
                    public byte PP2
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[1]; }
                    }
                    public byte PP3
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[2]; }
                    }
                    public byte PP4
                    {
                        get { return (BitConverter.ToUInt32(this.Attacks, 8) ^ DecryprionKey).GetBytes()[3]; }
                    }
                    public byte HP_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte Attack_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[1]; } }
                    public byte Defence_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[2]; } }
                    public byte Speed_EV { get { return (BitConverter.ToUInt32(this.EVs, 0) ^ DecryprionKey).GetBytes()[3]; } }
                    public byte SPAttack_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte SPDefence_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[1]; } }
                    public byte Coolness_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[2]; } }
                    public byte Beauty_EV { get { return (BitConverter.ToUInt32(this.EVs, 4) ^ DecryprionKey).GetBytes()[3]; } }
                    public byte Cuteness_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte Smartness_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[1]; } }
                    public byte Toughness_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[2]; } }
                    public byte Feel_EV { get { return (BitConverter.ToUInt32(this.EVs, 8) ^ DecryprionKey).GetBytes()[3]; } }
                    public byte PokerusStatus { get { return (BitConverter.ToUInt32(this.Misc, 0) ^ DecryprionKey).GetBytes()[0]; } }
                    public byte MetLocation { get { return (BitConverter.ToUInt32(this.Misc, 0) ^ DecryprionKey).GetBytes()[1]; } }
                    public ushort OriginsInfo { get { return BitConverter.ToUInt16((BitConverter.ToUInt32(this.Misc, 0) ^ DecryprionKey).GetBytes(), 2); } }
                    public byte HP_IV { get { return (byte)((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00000000000000000000000000011111); } }
                    public byte Attack_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00000000000000000000001111100000) >> 5); } }
                    public byte Defence_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00000000000000000111110000000000) >> 10); } }
                    public byte Speed_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00000000000011111000000000000000) >> 15); } }
                    public byte SPAttack_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00000001111100000000000000000000) >> 20); } }
                    public byte SPDefence_IV { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00111110000000000000000000000000) >> 25); } }
                    public bool IsEgg { get { return (((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b00000000000000000000000000000011) >> 0) == 0 ? false : true; } }
                    public byte Ability { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 4) ^ DecryprionKey) & 0b10000000000000000000000000000000) >> 31); } }
                    public byte Ribbon_Cool { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000000000000000000111) >> 0); } }
                    public byte Ribbon_Beauty { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000000000000000111000) >> 3); } }
                    public byte Ribbon_Cute { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000000000000111000000) >> 6); } }
                    public byte Ribbon_Smart { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000000000111000000000) >> 9); } }
                    public byte Ribbon_Tought { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000000111000000000000) >> 12); } }
                    public byte Ribbon_Champion { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000001000000000000000) >> 13); } }
                    public byte Ribbon_Winning { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000010000000000000000) >> 14); } }
                    public byte Ribbon_Victory { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000000100000000000000000) >> 15); } }
                    public byte Ribbon_Artist { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000001000000000000000000) >> 16); } }
                    public byte Ribbon_Effort { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000010000000000000000000) >> 17); } }
                    public byte Ribbon_Special1 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000000100000000000000000000) >> 18); } }
                    public byte Ribbon_Special2 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000001000000000000000000000) >> 19); } }
                    public byte Ribbon_Special3 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000010000000000000000000000) >> 20); } }
                    public byte Ribbon_Special4 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000000100000000000000000000000) >> 21); } }
                    public byte Ribbon_Special5 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000001000000000000000000000000) >> 22); } }
                    public byte Ribbon_Special6 { get { return (byte)(((BitConverter.ToUInt32(this.Misc, 8) ^ DecryprionKey) & 0b00000010000000000000000000000000) >> 23); } }

                    internal uint DecryprionKey
                    {
                        get { return this.sv.Personality ^ this.sv.OTID; }
                    }
                    private int Modulo;
                    internal PokemonData(Pokemon sv)
                    {
                        this.sv = sv;
                        this.Modulo = (int)(sv.Personality % 24);
                        var b = dd[1].IndexOf("G");
                    }
                }

            }
        }

        public Game GameType
        {
            get { if (GameSaveA.sections[0].wholeData[0x00AC] == 0) return Game.RS;
                else if (GameSaveA.sections[0].wholeData[0x00AC] == 1) return Game.FL;
                else return Game.E;
            }
        }
        public uint SecurityKey
        {
            get { if (this.GameType == Game.E) return BitConverter.ToUInt32(this.GameSaveA.sections[0].wholeData, 0x00AC);
                else if (this.GameType == Game.RS) return 0;
                else return BitConverter.ToUInt32(this.GameSaveA.sections[0].wholeData, 0X0AF8);
                    }
        }
        internal void Initialize()
        {
            this.GameSaveA = new GameSave(this.GameSaveAData);
            this.GameSaveB = new GameSave(this.GameSaveBData);
            
            this.Player = new SaveFile.PlayerClass(this);
            this.Options = new OptionsClass(this);
            this.PCBoxes = new PCBoxClass(this);
            this.Pokedex = new PokedexClass(this);
        }
    }
}

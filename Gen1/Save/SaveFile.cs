using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Gen1.Save
{
    public class SaveFile
    {
        internal const uint FileSize = 32768;
        internal const uint BanksNumber = 4;
        internal const uint BankSize = 8192;
        internal const uint FirstBankOffset = 0x0000;  //Scratch and Hall of Fame
        internal const uint SecondBankOffset = 0x2000; //Main
        internal const uint ThirdBankOffset = 0x4000;  //Boxes 1-6
        internal const uint FourthBankOffset = 0x6000; //Boxes 7-12
        public MainBankClass MainBank;
        public MiscBankClass MiscBank;
        public PCStorageBankClass PCStorageBank;
        internal Data data;
        internal string FileName;

        public SaveFile(string FileName)
        {
            var temp = File.ReadAllBytes(FileName);
            if (temp.Length < FileSize)
                throw new Exception("Not valid Generator I savefile.");
            this.data = new Data(temp);
            this.FileName = FileName;
            Initialize();
        }
        public void Save()
        {
            this.MainBank.RecalculateChecksum();
            File.WriteAllBytes(this.FileName, this.data);
        }
        
        
        public void Initialize()
        {


            this.MainBank = new MainBankClass(this);
            this.MiscBank = new MiscBankClass(this);
            this.PCStorageBank = new PCStorageBankClass(this);
        }
        public class MiscBankClass
        {
            internal enum OffsetEnum { SpriteBuffer0,SpriteBuffer1,SpriteBuffer2,Unused1,HallOfFame,Unused2 }
            internal Dictionary<OffsetEnum, uint> Offsets = new Dictionary<OffsetEnum, uint>()
            {
                { OffsetEnum.SpriteBuffer0, 0x0000 },
                { OffsetEnum.SpriteBuffer1, 0x0188 },
                { OffsetEnum.SpriteBuffer2, 0x0310 },
                { OffsetEnum.Unused1,       0x0498 },
                { OffsetEnum.HallOfFame,    0x0598 },
                { OffsetEnum.Unused2,       0X1858 },

            };
            internal Dictionary<OffsetEnum, uint> Sizes = new Dictionary<OffsetEnum, uint>()
            {
                { OffsetEnum.SpriteBuffer0, 0x188 },
                { OffsetEnum.SpriteBuffer1, 0x188 },
                { OffsetEnum.SpriteBuffer2, 0x188 },
                { OffsetEnum.Unused1,       0x100 },
                { OffsetEnum.HallOfFame,    0x12C0 },
                { OffsetEnum.Unused2,       0x7A8 },

            };

            internal SaveFile sv;
            
            internal MiscBankClass(SaveFile sv) { this.sv = sv; }
        }
        public class MainBankClass
        {
            internal enum OffsetEnum { Unused1, PlayerName, MainData, SpriteData, PartyData, CurrentBoxData,TilesetType,MainDataChecksum,Unused2 }
            internal Dictionary<OffsetEnum, uint> Offsets = new Dictionary<OffsetEnum, uint>()
            {
                { OffsetEnum.Unused1,           0x2000 },
                { OffsetEnum.PlayerName,        0x2598 },
                { OffsetEnum.MainData,          0x25A3 },
                { OffsetEnum.SpriteData,        0x2D2C },
                { OffsetEnum.PartyData,         0x2F2C },
                { OffsetEnum.CurrentBoxData,    0x30C0 },
                { OffsetEnum.TilesetType,       0x3522 },
                { OffsetEnum.MainDataChecksum,  0x3523 },
                { OffsetEnum.Unused2,           0x3524 },

            };
            internal Dictionary<OffsetEnum, uint> Sizes = new Dictionary<OffsetEnum, uint>()
            {
                { OffsetEnum.Unused1,           0X598 },
                { OffsetEnum.PlayerName,        0x007 },
                { OffsetEnum.MainData,          0x789 },
                { OffsetEnum.SpriteData,        0x200 },
                { OffsetEnum.PartyData,         0x194 },
                { OffsetEnum.CurrentBoxData,    0x462 },
                { OffsetEnum.TilesetType,       0x1 },
                { OffsetEnum.MainDataChecksum,  0x1 },
                { OffsetEnum.Unused2,           0xADC },

            };
            public MainDataClass MainData;
            public FlagClass Flags;
            public PartyClass Party;
            public string PlayerName
            {
                get { return this.sv.data.Read.String(Offsets[OffsetEnum.PlayerName], Sizes[OffsetEnum.PlayerName]); }
                set { throw new NotImplementedException(); }
            }
            public string RivalName
            {
                get { return this.sv.data.Read.String(0X25F6, 7); }
                set { throw new NotImplementedException(); }
            }
            public ushort PlayerID
            {
                get { return this.sv.data.Read.Ushort(0x2605); }
                set { throw new NotImplementedException(); }
            }
            public byte PlayTimeHours
            {
                get { return this.sv.data[0x2CED]; }
                set { this.sv.data[0x2CED] = value; }
            }
            public byte PlayTimeMaxed
            {
                get { return this.sv.data[0x2CEE]; }
            }
            public byte PlayTimeMinutes
            {
                get { return this.sv.data[0x2CEF]; }
                set { this.sv.data[0x2CEF] = value; }
            }
            public byte PlayTimeSeconds
            {
                get { return this.sv.data[0x2CF0]; }
                set { this.sv.data[0x2CF0] = value; }
            }
            public byte PlayTimeFrames
            {
                get { return this.sv.data[0x2CF1]; }
                set { this.sv.data[0x2CF1] = value; }
            }
            public uint Money
            {
                get { return this.sv.data.Read.BCDThreeBytes(0x25F3); }
            }
            public uint SlotCoins
            {
                get { return this.sv.data.Read.BCDThreeBytes(0x2850); }
            }
            public string DaycareName
            {
                get { return this.sv.data.Read.String(0x2CF5, 11); }
            }
            public byte DayCarePokemon
            {
                get { return this.sv.data[0x2D0B]; }
            }
            public byte DayCareInUse
            {
                get { return this.sv.data[0x2CF4]; }
            }


            internal void RecalculateChecksum()
            {
                this.Checksum = GenerateChecksum;
            }
            internal byte GenerateChecksum
            {
                get
                {
                    byte result = 255;
                    for (int i = 0x2598; i <= 0x3522; i++)
                        result -= this.sv.data[i];
                    return result;
                }
            }
            public byte Checksum
            {
                get { return this.sv.data[0x3523]; }
                set { this.sv.data[0x3523] = value; }
            }
            internal SaveFile sv;
            internal MainBankClass(SaveFile sv) { this.sv = sv; this.MainData = new MainDataClass(sv); this.Flags = new FlagClass(sv);this.Party = new PartyClass(sv); }
            public class MainDataClass
            {
                public PokedexClass Owned;
                public PokedexClass Seen;
                public EnumurableList BagItems;
                public EnumurableList PCItems;
                public bool[] Badges
                {
                    get { return this.sv.data[0x2602].GetBits(); }
                    set { this.sv.data[0x2602] = value.GetByte(); }
                }                
                internal SaveFile sv;
                internal MainDataClass(SaveFile sv) 
                {
                    this.sv = sv; 
                    this.Owned = new PokedexClass(sv,true);
                    this.Seen = new PokedexClass(sv, false);
                    this.BagItems = new EnumurableList(sv, 0x25C9);
                    this.PCItems = new EnumurableList(sv, 0x27E6);
                }
                public class PokedexClass
                {
                    internal int offset;
                    public bool this[int Pokemon]
                    {
                        get 
                        {
                            var ByteIndex = (uint)((Pokemon-1) / 8);
                            var BitIndex = (uint)((Pokemon-1) % 8);
                            var Byte = this.sv.data[offset + ByteIndex];
                            return Byte.GetBit(BitIndex);
                        }
                        set
                        {
                            var ByteIndex = (uint)((Pokemon - 1) / 8);
                            var BitIndex = (uint)((Pokemon - 1) % 8);
                            var Byte = this.sv.data[offset + ByteIndex];
                            Byte.SetBit(BitIndex,value);
                        }
                    }
                    internal SaveFile sv;
                    internal PokedexClass(SaveFile sv, bool isOwned) { this.sv = sv; this.offset = isOwned ? 0x25A3 : 0x25B6; }
                }
                
            }
            public class EnumurableList
            {
                private uint offset;
                public ListEntry[] Items
                {
                    get
                    {
                        List<ListEntry> result = new List<ListEntry>();
                        int i = 1;

                        for (int x = 0; x < Size; x++)
                        {
                            result.Add(new ListEntry()
                            {
                                Amount = this.sv.data[offset + (i * 2)],
                                ID = this.sv.data[offset + (i * 2) - 1]
                            });
                            i++;
                        }
                        return result.ToArray();
                    }
                }
                public byte Size
                {
                    get { return this.sv.data[offset]; }
                }
                SaveFile sv;
                public EnumurableList(SaveFile sv,uint offset) { this.sv = sv; this.offset = offset; if (!Validate) throw new Exception(); }
                public bool Validate
                {
                    get 
                    {
                        byte size = this.sv.data[offset];
                        byte end = this.sv.data[offset + (size * 2) + 1];
                        if (end != 0xFF)
                            return false;
                        return true;
                    }
                }
            }
            public class FlagClass
            {
                public bool ReceivedOldRod
                {
                    get { return this.sv.data[0x29D4].GetBit(3); }
                    set { throw new NotImplementedException(); }
                }
                public bool ReceivedGoodRod
                {
                    get { return this.sv.data[0x29D4].GetBit(4); }
                    set { throw new NotImplementedException(); }
                }
                public bool ReceivedSuperRod
                {
                    get { return this.sv.data[0x29D4].GetBit(5); }
                    set { throw new NotImplementedException(); }
                }
                public bool SaffronGuardDrink
                {
                    get { return this.sv.data[0x29D4].GetBit(6); }
                    set { throw new NotImplementedException(); }
                }
                public bool ReceivedLapras
                {
                    get { return this.sv.data[0x29DA].GetBit(0); }
                    set { throw new NotImplementedException(); }
                }
                public bool ReceiverStarter
                {
                    get { return this.sv.data[0x29DA].GetBit(3); }
                    set { throw new NotImplementedException(); }
                }
                SaveFile sv;
                internal FlagClass(SaveFile sv) { this.sv = sv; }
            }
            public class PartyClass
            {
                internal PartyPokemonClass[] pkms;
                SaveFile sv;
                public PartyPokemonClass this[int index]
                {
                    get { return this.pkms[index]; }
                }
                public PartyClass(SaveFile sv)
                {
                    this.sv = sv; this.pkms = new PartyPokemonClass[6]; for (uint i = 0; i < 6; i++) { this.pkms[i] = new PartyPokemonClass(sv, i); } 
                }
            }
            public class PartyPokemonClass
            {
                internal uint offset { get { return (0x2F2C+ 0x08 + (44 * no)); } }
                public byte Species
                {
                    get { return this.sv.data[offset]; }
                    set { this.sv.data[offset] = value; }
                }
                public ushort CurrentHP
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x01); }
                }
                public byte Level
                {
                    get { return this.sv.data.Read.Byte(offset + 0x03); }
                }
                public byte StatusCondition
                {
                    get { return this.sv.data.Read.Byte(offset + 0x04); }
                }
                public byte Type1
                {
                    get { return this.sv.data.Read.Byte(offset + 0x05); }
                }
                public byte Type2
                {
                    get { return this.sv.data.Read.Byte(offset + 0x06); }
                }
                public byte CatchRate
                {
                    get { return this.sv.data.Read.Byte(offset + 0x07); }
                }
                public byte Move1
                {
                    get { return this.sv.data.Read.Byte(offset + 0x08); }
                }
                public byte Move2
                {
                    get { return this.sv.data.Read.Byte(offset + 0x09); }
                }
                public byte Move3
                {
                    get { return this.sv.data.Read.Byte(offset + 0x0A); }
                }
                public byte Move4
                {
                    get { return this.sv.data.Read.Byte(offset + 0x0B); }
                }
                public ushort OTID
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x0C); }
                }
                public uint Experience
                {
                    get { return this.sv.data.Read.ThreeBytes(offset + 0x0E); }
                }
                public ushort EV_HitPoints
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x11); }
                }
                public ushort EV_Attack
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x13); }
                }
                public ushort EV_Defence
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x15); }
                }
                public ushort EV_Speed
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x17); }
                }
                public ushort EV_Special
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x19); }
                }
                public byte IV_Attack
                {
                    get { return (byte)(this.sv.data.Read.Byte(offset + 0x1B) >> 4); }
                }
                public byte IV_Defence
                {
                    get { return (byte)((this.sv.data.Read.Byte(offset + 0x1B) & 0b00001111)); }
                }
                public byte IV_Speed
                {
                    get { return (byte)(this.sv.data.Read.Byte(offset + 0x1C) >> 4); }
                }
                public byte IV_Special
                {
                    get { return (byte)((this.sv.data.Read.Byte(offset + 0x1C) & 0b00001111)); }
                }
                public byte Move1_PP
                {
                    get { return this.sv.data.Read.Byte(offset + 0x1D); }
                }
                public byte Move2_PP
                {
                    get { return this.sv.data.Read.Byte(offset + 0x1E); }
                }
                public byte Move3_PP
                {
                    get { return this.sv.data.Read.Byte(offset + 0x1F); }
                }
                public byte Move4_PP
                {
                    get { return this.sv.data.Read.Byte(offset + 0x20); }
                }
                public ushort MaximumHP
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x22); }
                }
                public ushort Attack
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x24); }
                }
                public ushort Defence
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x24); }
                }
                public ushort Speed
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x28); }
                }
                public ushort Special
                {
                    get { return this.sv.data.Read.Ushort(offset + 0x2A); }
                }
                public string Nickname
                {
                    get { return this.sv.data.Read.String(0x2F2C + 0x110 + 0x42 + (no * 0xB), 0xB); }
                }
                public string TrainerName
                {
                    get { return this.sv.data.Read.String(0x2F2C + 0x110 + (no * 0xB), 0xB); }
                }
                SaveFile sv;
                internal uint no;
                internal PartyPokemonClass(SaveFile sv,uint no) { this.sv = sv; this.no = no; }
            }
        }
        public class PCStorageBankClass
        {
            
            internal readonly uint[] BoxOfssets =  new uint[]{ 0x4000, 0x4462, 0x48C4, 0x4D26, 0x5188, 0x55EA, 0x6000, 0x6462, 0x68C4, 0x6D26, 0x7188, 0x75EA };
            internal SaveFile sv;
            internal PCStorageClass[] boxes;
            internal PCStorageBankClass(SaveFile sv)
            {
                this.sv = sv; this.boxes = new PCStorageClass[12]; for (int i = 0; i < 12; i++)
                {
                    this.boxes[i] = new PCStorageClass(sv, BoxOfssets[i]);
                } }
            public PCStorageClass this[int index]
            {
                get { return this.boxes[index]; }
            }

            public byte ChecksumWhole1 { get { return this.sv.data.Read.Byte(0x5A4C); } }
            public byte ChecksumWhole2 { get { return this.sv.data.Read.Byte(0X7A4D); } }
            public byte[] Checksums1
            {
                get { return new byte[] {   this.sv.data.Read.Byte(0x5A4D),
                                            this.sv.data.Read.Byte(0x5A4E),
                                            this.sv.data.Read.Byte(0x5A4F),
                                            this.sv.data.Read.Byte(0x5A50),
                                            this.sv.data.Read.Byte(0x5A51),
                                            this.sv.data.Read.Byte(0x5A52)}; }
            }
            public byte[] Checksums2
            {
                get
                {
                    return new byte[] {   this.sv.data.Read.Byte(0x7A4D),
                                            this.sv.data.Read.Byte(0x7A4E),
                                            this.sv.data.Read.Byte(0x7A4F),
                                            this.sv.data.Read.Byte(0x7A50),
                                            this.sv.data.Read.Byte(0x7A51),
                                            this.sv.data.Read.Byte(0x7A52)};
                }
            }
            public byte checkSum1()
            {
                byte result = 0;
                for (uint i = 0x6000; i <= (0x7a4b); i++)
                {
                    result += this.sv.data[i];
                }
                result ^= 0xFF;
                return result;
            }

            public class PCStorageClass
            {
                internal uint Offset;
                internal const uint Size = 0x462;
                internal SaveFile sv;
                public byte PokemonCount
                {
                    get { return this.sv.data.Read.Byte(this.Offset); }
                }
                internal PCPokemonClass[] pkms; 
                public PCPokemonClass this[int index]
                {
                    get { return this.pkms[index]; }
                }
                internal PCStorageClass(SaveFile sv,uint offset) { this.sv = sv; this.Offset = offset; this.pkms = new PCPokemonClass[20];
                    for (uint i = 0; i < 20; i++)
                    {
                        this.pkms[i] = new PCPokemonClass(sv, offset, i);
                    }
                }
                public class PCPokemonClass
                {
                    internal uint Offset;
                    internal uint DataOffset
                    {
                        get { return this.Offset + 0x16 + (0x21 * NumberInBox); }
                    }
                    internal uint NumberInBox;
                    public byte Species
                    {
                        get { return this.sv.data.Read.Byte(this.Offset + 0x01 + (0x01*NumberInBox)); }
                    }
                    public ushort CurrentHP
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x01); }
                    }
                    public byte Level
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x03); }
                    }
                    public byte StatusCondition
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x04); }
                    }
                    public byte Type1
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x05); }
                    }
                    public byte Type2
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x06); }
                    }
                    public byte CatchRate
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x07); }
                    }
                    public byte Move1
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x08); }
                    }
                    public byte Move2
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x09); }
                    }
                    public byte Move3
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x0A); }
                    }
                    public byte Move4
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x0B); }
                    }
                    public ushort OTID
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x0C); }
                    }
                    public uint Experience
                    {
                        get { return this.sv.data.Read.ThreeBytes(DataOffset + 0x0E); }
                    }
                    public ushort EV_HitPoints
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x11); }
                    }
                    public ushort EV_Attack
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x13); }
                    }
                    public ushort EV_Defence
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x15); }
                    }
                    public ushort EV_Speed
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x17); }
                    }
                    public ushort EV_Special
                    {
                        get { return this.sv.data.Read.Ushort(DataOffset + 0x19); }
                    }
                    public byte IV_Attack
                    {
                        get { return (byte)(this.sv.data.Read.Byte(DataOffset + 0x1B) >> 4); }
                    }
                    public byte IV_Defence
                    {
                        get { return (byte)((this.sv.data.Read.Byte(DataOffset + 0x1B) & 0b00001111)); }
                    }
                    public byte IV_Speed
                    {
                        get { return (byte)(this.sv.data.Read.Byte(DataOffset + 0x1C) >> 4); }
                    }
                    public byte IV_Special
                    {
                        get { return (byte)((this.sv.data.Read.Byte(DataOffset + 0x1C) & 0b00001111)); }
                    }
                    public byte Move1_PP
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x1D); }
                    }
                    public byte Move2_PP
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x1E); }
                    }
                    public byte Move3_PP
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x1F); }
                    }
                    public byte Move4_PP
                    {
                        get { return this.sv.data.Read.Byte(DataOffset + 0x20); }
                    }
                    public string Name
                    {
                        get { return this.sv.data.Read.String(Offset + 0x386 + (0x0B * NumberInBox),0xB); }
                    }
                    internal SaveFile sv;
                    internal PCPokemonClass(SaveFile sv, uint Offset,uint no) { this.sv = sv;this.Offset = Offset;this.NumberInBox = no; }
                }

            }
        }

    }
}

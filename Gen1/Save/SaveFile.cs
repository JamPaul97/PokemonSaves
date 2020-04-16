﻿using System;
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
        internal byte[] data;

        public SaveFile(string FileName)
        {
            var temp = File.ReadAllBytes(FileName);
            if (temp.Length != FileSize)
                throw new Exception("Not valid Generator I savefile.");
            this.data = temp;
            Initialize();
        }

        public byte GenerateChecksum
        {
            get
            {
                byte result = 255;
                for (int i = 0x2598; i < 0x3522; i++)
                    result -= this.data[i];
                return result;
            }
        }
        public void Initialize()
        {


            this.MainBank = new MainBankClass(this);
            this.MiscBank = new MiscBankClass(this);
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
            public string PlayerName
            {
                get { return this.sv.data.Sub(Offsets[OffsetEnum.PlayerName], Sizes[OffsetEnum.PlayerName]).Decode(); }
                set { this.sv.data.Update(Offsets[OffsetEnum.PlayerName], value.GenerateName()); }
            }
            public string RivalName
            {
                get { return this.sv.data.Sub(0X25F6, 7).Decode(); }
                set { this.sv.data.Update(0X25F6, value.GenerateName()); }
            }
            internal SaveFile sv;
            internal MainBankClass(SaveFile sv) { this.sv = sv; this.MainData = new MainDataClass(sv); }
            public class MainDataClass
            {
                public PokedexClass Owned;
                public PokedexClass Seen;
                public EnumurableList BagItems;
                public uint Money
                {
                    get { return this.sv.data.Sub(0x25F3, 3).FromBCD(); }
                }
                internal SaveFile sv;
                internal MainDataClass(SaveFile sv) 
                {
                    this.sv = sv; 


                    this.Owned = new PokedexClass(sv,true);
                    this.Seen = new PokedexClass(sv, false);
                    this.BagItems = new EnumurableList(sv, 0x25C9);
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
                            var bbb = this.sv.data.Sub((uint)offset, 0X13);
                            return Byte.GetBit(BitIndex);
                        }
                        set
                        {
                            var ByteIndex = (uint)((Pokemon - 1) / 8);
                            var BitIndex = (uint)((Pokemon - 1) % 8);
                            var Byte = this.sv.data[offset + ByteIndex];
                            var bbb = this.sv.data.Sub((uint)offset, 0X13);
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
        }

    }
}

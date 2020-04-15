using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Saves.GameSaves.Sections
{
    public class TeamItems
    {
        private const int size = 4096;
        private byte[] data;
        private Game type;
        private uint encKey;
        public uint TeamSize
        {
            get 
            {
                switch (this.type)
                {
                    case Game.RS:
                            return BitConverter.ToUInt32(data.SubArray(0x0234, 4), 0);
                    case Game.E:
                            return BitConverter.ToUInt32(data.SubArray(0x0234, 4), 0);
                    case Game.FL:
                            return BitConverter.ToUInt32(data.SubArray(0x0034, 4), 0);
                    default:
                        return BitConverter.ToUInt32(data.SubArray(0x0234, 4), 0);
                }
                
            }
            set { throw new NotImplementedException(); }
        }
        public Primatives.Pokemon Pokemon1;
        public Primatives.Pokemon Pokemon2;
        public Primatives.Pokemon Pokemon3;
        public Primatives.Pokemon Pokemon4;
        public Primatives.Pokemon Pokemon5;
        public Primatives.Pokemon Pokemon6;
        public uint Money
        {
            get 
            {
                switch(this.type)
                {
                    case Game.RS:
                            return BitConverter.ToUInt32(data.SubArray(0x0490, 4), 0) ^ this.encKey;
                    case Game.E:
                            return BitConverter.ToUInt32(data.SubArray(0x0490, 4), 0) ^ this.encKey;
                    case Game.FL:
                            return BitConverter.ToUInt32(data.SubArray(0x0290, 4), 0) ^ this.encKey;
                    default:
                        return BitConverter.ToUInt32(data.SubArray(0x0490, 4), 0) ^ this.encKey;
                } 
            }
            set { throw new NotImplementedException(); }
        }
        public uint Coins
        {
            get
            {
                switch (this.type)
                {
                    case Game.RS:
                        return BitConverter.ToUInt32(data.SubArray(0x0494, 4), 0) ^ this.encKey;
                    case Game.E:
                        return BitConverter.ToUInt32(data.SubArray(0x0494, 4), 0) ^ this.encKey;
                    case Game.FL:
                        return BitConverter.ToUInt32(data.SubArray(0x0294, 4), 0) ^ this.encKey;
                    default:
                        return BitConverter.ToUInt32(data.SubArray(0x0494, 4), 0) ^ this.encKey;
                }
            }
            set { throw new NotImplementedException(); }
        }
        public List<Primatives.Item> PCItems
        {
            get
            {
                switch(this.type)
                {
                    case Game.E:
                        return DecodeItems(0x0498, 200);
                    case Game.RS:
                        return DecodeItems(0x0498, 200);
                    case Game.FL:
                        return DecodeItems(0x0298, 120);
                    default:
                        return DecodeItems(0x0498, 200);
                }
            }
            set { throw new NotImplementedException(); }
        }
        public List<Primatives.Item> Items
        {
            get
            {
                switch (this.type)
                {
                    case Game.E:
                        return DecodeItems(0x560, 120);
                    case Game.RS:
                        return DecodeItems(0x560, 80);
                    case Game.FL:
                        return DecodeItems(0x0310, 168);
                    default:
                        return DecodeItems(0x560, 80);
                }
            }
            set { throw new NotImplementedException(); }
        }
        public List<Primatives.Item> KeyItems
        {
            get
            {
                switch (this.type)
                {
                    case Game.E:
                        return DecodeItems(0x05D8, 120);
                    case Game.RS:
                        return DecodeItems(0X05B0, 80);
                    case Game.FL:
                        return DecodeItems(0X03B8, 120);
                    default:
                        return DecodeItems(0x05D8, 120);
                }
            }
            set { throw new NotImplementedException(); }
        }
        public List<Primatives.Item> BallItems
        {
            get
            {
                switch (this.type)
                {
                    case Game.E:
                        return DecodeItems(0x0650, 64);
                    case Game.RS:
                        return DecodeItems(0x0600, 64);
                    case Game.FL:
                        return DecodeItems(0x0430, 52);
                    default:
                        return DecodeItems(0x0650, 64);
                }
            }
            set { throw new NotImplementedException(); }
        }
        public List<Primatives.Item> TMCase
        {
            get
            {
                switch (this.type)
                {
                    case Game.E:
                        return DecodeItems(0x0690, 256);
                    case Game.RS:
                        return DecodeItems(0x0640, 256);
                    case Game.FL:
                        return DecodeItems(0x0464, 232);
                    default:
                        return DecodeItems(0x0690, 256);
                }
            }
            set { throw new NotImplementedException(); }
        }
        public List<Primatives.Item> BerryPocket
        {
            get
            {
                switch (this.type)
                {
                    case Game.E:
                        return DecodeItems(0x0790, 184);
                    case Game.RS:
                        return DecodeItems(0x0740, 184);
                    case Game.FL:
                        return DecodeItems(0x054C, 172);
                    default:
                        return DecodeItems(0x0790, 184);
                }
            }
            set { throw new NotImplementedException(); }
        }
        public TeamItems(byte[] arr, Game type, uint encKey)
        {
            if (arr.Length != size)
                throw new FormatException();
            this.data = arr;
            this.type = type;
            this.encKey = encKey;
            if(type == Game.E || type == Game.RS)
            {
                this.Pokemon1 = new Primatives.Pokemon(data.SubArray(0x238 + 0, 100));
                this.Pokemon2 = new Primatives.Pokemon(data.SubArray(0x29C, 100));
                this.Pokemon3 = new Primatives.Pokemon(data.SubArray(0x238 + 0xc8, 100));
                this.Pokemon4 = new Primatives.Pokemon(data.SubArray(0x238 + 300, 100));
                this.Pokemon5 = new Primatives.Pokemon(data.SubArray(0x238 + 400, 100));
                this.Pokemon6 = new Primatives.Pokemon(data.SubArray(0x238 + 500, 100));
            }
            else
            {
                this.Pokemon1 = new Primatives.Pokemon(data.SubArray(0x0038 + 0, 100));
                this.Pokemon2 = new Primatives.Pokemon(data.SubArray(0x0038 + 100, 100));
                this.Pokemon3 = new Primatives.Pokemon(data.SubArray(0x0038 + 200, 100));
                this.Pokemon4 = new Primatives.Pokemon(data.SubArray(0x0038 + 300, 100));
                this.Pokemon5 = new Primatives.Pokemon(data.SubArray(0x0038 + 400, 100));
                this.Pokemon6 = new Primatives.Pokemon(data.SubArray(0x0038 + 500, 100));
            }
            

        }
        private List<Primatives.Item> DecodeItems(uint start, uint lenght)
        {
            List<Primatives.Item> result = new List<Primatives.Item>();
            for (uint i = 0; i < lenght/4; i++)
            {
                result.Add(new Primatives.Item(this.data.SubArray(start + (i * 4), 4)));
            }
            return result;
        }
    }
}

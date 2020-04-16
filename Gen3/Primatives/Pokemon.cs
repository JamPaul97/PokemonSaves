using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gen3.Primatives.PokeData;
namespace Gen3.Primatives
{
    public class Pokemon
    {
        private const int Size = 100;
        private byte[] data;
        public uint Personality;
        public uint OTID;
        public string Nickaname;
        public Language Language;
        public string OTName;
        public Marking Markings;
        public uint Checksum;
        public byte Level
        {
            get { return data[84]; }
            set { data[84] = value; }
        }
        public uint Pokerus;
        public short CurrentHP;
        public short TotalHP;
        public short Attack;
        public short Defense;
        public short Speed;
        public short SPAttack;
        public short SPDefence;
        public PokemonData Data;
        public Pokemon(byte[] arr)
        {
            this.data = arr;
            this.Personality = BitConverter.ToUInt32(data.SubArray(0, 4), 0);
            this.OTID = BitConverter.ToUInt32(data.SubArray(4, 4), 0);
            //this.Nickaname = data.SubArray(8, 10).Decode();
            this.Language = (Language)BitConverter.ToInt16(data.SubArray(18, 2), 0);
            //this.OTName = data.SubArray(20, 7).Decode();
            this.Markings = (Marking)data[27];
            this.Pokerus = BitConverter.ToUInt32(new byte[] { data.SubArray(85, 1)[0], 0, 0, 0 }, 0);
            this.CurrentHP = BitConverter.ToInt16(data.SubArray(86, 2), 0);
            this.TotalHP = BitConverter.ToInt16(data.SubArray(88, 2), 0);
            this.Attack = BitConverter.ToInt16(data.SubArray(90, 2), 0);
            this.Defense = BitConverter.ToInt16(data.SubArray(92, 2), 0);
            this.Speed = BitConverter.ToInt16(data.SubArray(94, 2), 0);
            this.SPAttack = BitConverter.ToInt16(data.SubArray(96, 2), 0);
            this.SPDefence = BitConverter.ToInt16(data.SubArray(98, 2), 0);
            this.Data = new PokemonData(data.SubArray(32, 48), OTID ^ Personality, Personality%24);
        }


    }
}

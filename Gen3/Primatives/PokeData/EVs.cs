using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class EVs
    {
        private const int size = 12;
        private byte[] data;
        private uint EncryptionKey;
        public byte HP;
        public byte Attack;
        public byte Defense;
        public byte Speed;
        public byte SPAttack;
        public byte SPDefence;
        public byte Coolness;
        public byte Beauty;
        public byte Cuteness;
        public byte Smartness;
        public byte Toughness;
        public byte Feel;
        public EVs(byte[] arr, uint enc)
        {
            this.data = arr;
            this.EncryptionKey = enc;
            byte[] dec = BitConverter.GetBytes(BitConverter.ToInt32(data.SubArray(0, 4), 0) );
            this.HP = dec[0];
            this.Attack = dec[1];
            this.Defense = dec[2];
            this.Speed = dec[3];
            dec = BitConverter.GetBytes(BitConverter.ToInt32(data.SubArray(4, 4), 0) );
            this.SPAttack = dec[0];
            this.SPDefence = dec[1];
            this.Coolness = dec[2];
            this.Beauty = dec[3];
            dec = BitConverter.GetBytes(BitConverter.ToInt32(data.SubArray(8, 4), 0) );
            this.Cuteness = dec[0];
            this.Smartness = dec[1];
            this.Toughness = dec[2];
            this.Feel = dec[3];
    }
    }
}

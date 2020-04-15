using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class Attacks
    {
        private const int size = 12;
        private byte[] data;
        private uint EncryptionKey;
        public short Move1;
        public short Move2;
        public short Move3;
        public short Move4;
        public byte PP1;
        public byte PP2;
        public byte PP3;
        public byte PP4;
        public Attacks(byte[] arr, uint enc)
        {
            this.data = arr;
            this.EncryptionKey = enc;
            byte[] dec = BitConverter.GetBytes(BitConverter.ToInt32(data.SubArray(0, 4), 0) );
            this.Move1 = BitConverter.ToInt16(dec, 0);
            this.Move2 = BitConverter.ToInt16(dec, 2);
            dec = BitConverter.GetBytes(BitConverter.ToInt32(data.SubArray(4, 4), 0));
            this.Move3 = BitConverter.ToInt16(dec, 0);
            this.Move4 = BitConverter.ToInt16(dec, 2);
            dec = BitConverter.GetBytes(BitConverter.ToInt32(data.SubArray(8, 4), 0));
            this.PP1 = dec[0];
            this.PP2 = dec[1];
            this.PP3 = dec[2];
            this.PP4 = dec[3];
    }
    }
}

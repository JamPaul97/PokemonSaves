using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class Misc
    {
        private const int size = 12;
        private byte[] data;
        private uint EncryptionKey;
        public byte Pokerus;
        public byte MetLoc;
        public short Origins;
        public IVs IVs;
        public Ribbons Ribbons;
        public Misc(byte[] arr, uint enc)
        {
            this.data = arr;
            this.EncryptionKey = enc;
            byte[] dec = BitConverter.GetBytes(BitConverter.ToInt32(arr.SubArray(0, 4), 0));
            this.Pokerus = dec[0];
            this.MetLoc = dec[1];
            this.Origins = BitConverter.ToInt16(dec, 2);
            dec = BitConverter.GetBytes(BitConverter.ToInt32(arr.SubArray(4, 4), 0));
            this.IVs = new IVs(BitConverter.ToInt32(dec, 0));
            dec = BitConverter.GetBytes(BitConverter.ToInt32(arr.SubArray(8, 4), 0));
            this.Ribbons = new Ribbons(BitConverter.ToInt32(dec, 0));
        }
    }
}

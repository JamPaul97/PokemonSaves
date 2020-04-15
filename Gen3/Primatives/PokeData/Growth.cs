using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class Growth
    {
        private const int size = 12;
        private byte[] data;
        public short Species;
        public short HeldItem;
        public uint Experiece;
        public byte PPBonuses;
        public byte Frienship;
        private uint EncryptionKey;
        public Growth(byte[] arr,uint enc)
        {
            this.data = arr;
            this.EncryptionKey = enc;
            byte[] dec = BitConverter.GetBytes(BitConverter.ToInt32(arr.SubArray(0, 4), 0));
            this.Species = BitConverter.ToInt16(arr, 0);
            this.HeldItem = BitConverter.ToInt16(dec, 2);
            dec = BitConverter.GetBytes(BitConverter.ToInt32(arr.SubArray(4, 4), 0));
            this.Experiece = BitConverter.ToUInt32(dec, 0);
            dec = BitConverter.GetBytes(BitConverter.ToInt32(arr.SubArray(8, 4), 0));
            this.PPBonuses = dec[0];
            this.Frienship = dec[1];
        }
    }
}

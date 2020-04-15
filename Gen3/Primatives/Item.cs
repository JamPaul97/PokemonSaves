using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives
{
    public class Item
    {
        private readonly int Size = 4;
        private byte[] data;
        public short index;
        public short quantity;
        public Item(byte[] arr)
        {
            if (arr.Length != Size)
                throw new FormatException();
            this.index = BitConverter.ToInt16(arr, 0);
            this.quantity = BitConverter.ToInt16(arr, 2);
        }
    }
}

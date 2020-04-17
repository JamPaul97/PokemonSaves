using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1.Save
{
    internal class Data
    {
        internal byte[] RealData;
        public ReadClass Read;
        public Data(byte[] arr)
        {
            this.RealData = arr;
            this.Read = new Data.ReadClass(this);
        }
        public byte this[int index]
        {
            get { return this.RealData[index]; }
            set { this.RealData[index] = value; }
        }
        public byte this[uint index]
        {
            get { return this.RealData[index]; }
            set { this.RealData[index] = value; }
        }
        public byte this[long index]
        {
            get { return this.RealData[index]; }
            set { this.RealData[index] = value; }
        }
        public ushort @ushort(uint offset)
        {


            return 0;
        }
        public bool GetBit(uint Byte,uint bit)
        {
            return this.RealData[Byte].GetBit(bit);
        }
        public void SetBit(uint Byte, uint bit)
        {
            this.RealData[Byte].SetBit(bit);
        }
        public void ClearBit(uint Byte, uint bit)
        {
            this.RealData[Byte].ClearBit(bit);
        }
        
        public static implicit operator byte[](Data data)
        {
            return data.RealData;
        }
        public class ReadClass
        {
            internal Data data;
            internal ReadClass(Data data) { this.data = data; }
            public string String(uint Offset, uint size) { return this.data.RealData.Sub(Offset, size).Decode(); }
            public byte Byte(uint Offset) { return this.data.RealData[Offset]; }
            public ushort Ushort(uint Offset,bool BigEndian = true)
            {
                byte[] bytes = new byte[2] { this.data.RealData[Offset], this.data.RealData[Offset + 1] };
                if (BigEndian)
                    Array.Reverse(bytes);
                return BitConverter.ToUInt16(bytes, 0);
            }
            public uint Uint(uint Offset, bool BigEndian = true)
            {
                byte[] bytes = new byte[4] { this.data.RealData[Offset], this.data.RealData[Offset + 1], this.data.RealData[Offset + 2], this.data.RealData[Offset + 3] };
                if (BigEndian)
                    Array.Reverse(bytes);
                return BitConverter.ToUInt32(bytes, 0);
            }
            public uint ThreeBytes(uint Offset,bool BigEndian = true)
            {
                byte[] bytes;
                bytes = BigEndian
                    ? new byte[4] { 0, this.data.RealData[Offset], this.data.RealData[Offset + 1], this.data.RealData[Offset + 2] }
                    : new byte[4] { this.data.RealData[Offset], this.data.RealData[Offset + 1], this.data.RealData[Offset + 2], 0 };
                if (BigEndian)
                    Array.Reverse(bytes);
                return BitConverter.ToUInt32(bytes, 0);
            }
            public uint BCDThreeBytes(uint Offset)
            {
                int result = 0;
                for (uint i = 0x25F3; i < 0x25F3+0x03; i++)
                {
                    result *= 100;
                    result += (10 * (this.data[i] >> 4));
                    result += this.data[i] & 0xf;
                }
                return (uint)result;
            }
        }
        
    }
}

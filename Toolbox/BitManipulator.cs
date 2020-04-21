using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public static class BitManipulator
    {
        public static bool GetBit(this byte bt, int pos)
        {
            if (pos > 7)
                throw new Exception("Bit out of bounds");
            var r = bt & (byte)Math.Pow(2, pos);
            return r >> pos == 0 ? false : true;
        }
        public static bool GetBit(this byte bt, uint pos)
        {
            if (pos > 7)
                throw new Exception("Bit out of bounds");
            var r = bt & (byte)Math.Pow(2, (int)pos);
            return r >> (int)pos == 0 ? false : true;
        }
        public static void SetBit(this ref byte bt, uint pos, bool bit)
        {
            byte t = bt;
            if (bit)
                bt.SetBit(pos);
            else
                bt.ClearBit(pos);
        }
        public static void SetBit(this ref byte bt, uint pos)
        {
            bt |= (byte)(Math.Pow(2, pos));
        }
        public static void ClearBit(this ref byte bt, uint pos)
        {
            bt &= (byte)(~(int)Math.Pow(2, pos));
        }
        public static uint FromBCD(this byte bt)
        {
            uint result = 0;
            result *= 100;
            result += (uint)(10 * (bt >> 4));
            result += (uint)bt & 0xf;
            return result;
        }
        public static uint FromBCD(this byte[] bt)
        {
            int result = 0;
            foreach (byte bcd in bt)
            {
                result *= 100;
                result += (10 * (bcd >> 4));
                result += bcd & 0xf;
            }
            return (uint)result;
        }
        public static bool[] GetBits(this byte bt)
        {
            List<bool> result = new List<bool>();
            for (int i = 0; i < 8; i++)
                result.Add(bt.GetBit(i));
            return result.ToArray();
        }
        public static byte GetByte(this bool[] bits)
        {
            byte result = 0;
            for (uint i = 0; i < 8; i++)
                result.SetBit(i, bits[i]);
            return result;
        }

    }
}

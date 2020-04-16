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
            return r >> pos-1 == 0 ? false : true;
        }
        public static bool GetBit(this byte bt, uint pos)
        {
            if (pos > 7)
                throw new Exception("Bit out of bounds");
            var r = bt & (byte)Math.Pow(2, (int)pos);
            return r >> (int)pos == 0 ? false : true;
        }
        public static void SetBit(this ref byte bt,uint pos,bool bit)
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen1
{
    public enum Region
    {
        JPN,
        ENG,
        FRE,
        ITA,
        GER,
        ESP,
        KOR
    }
    public static class ArrayManipulator
    {
        public static string Decode(this byte[] arr,Region reg = Region.ENG)
        {
            string re = string.Empty;
            if(reg == Region.ENG)
            {
                foreach (var x in arr)
                {
                    if (x == 0x50)
                        break;
                    re += Data.EnglishCharacters[x];
                }
                    
            }
            else if(reg == Region.ESP || reg == Region.ITA)
            {

            }
            else if(reg == Region.GER || reg == Region.GER)
            {

            }   
            else if(reg == Region.JPN || reg == Region.KOR)
            {

            }
            return re;
        }
        public static byte[] Sub(this byte[] arr, uint start, uint lenght)
        {
            List<byte> result = new List<byte>();
            for (uint i = start; i < start + lenght; i++)
                result.Add(arr[i]);
            return result.ToArray();
        }
        public static void Update(this byte[] arr, uint start, byte[] data)
        {
            for (uint i = start; i < start + data.Length; i++)
                arr[i] = data[i - start];
        }
        public static void Update(this byte[] arr, uint start, uint value)
        {
            byte[] val = System.BitConverter.GetBytes(value);
            for (uint i = start; i < start + val.Length; i++)
                arr[i] = val[i - start];
        }
        public static void Update(this byte[] arr, uint start, ushort value)
        {
            byte[] val = System.BitConverter.GetBytes(value);
            for (uint i = start; i < start + val.Length; i++)
                arr[i] = val[i - start];
        }
        public static void Update(this byte[] arr, uint start, string value, uint max)
        {
            byte[] val = value.Encode(max);
            for (uint i = start; i < start + val.Length; i++)
                arr[i] = val[i - start];
        }
        public static byte[] Encode(this string str, uint Characters)
        {
            List<byte> result = new List<byte>();
            foreach (var x in str)
            {
                string te = x.ToString();
                foreach (var z in Data.EnglishCharacters)
                    if (z.Value == te)
                        result.Add((byte)z.Key);
            }
            return result.ToArray();
        }
        public static void Push(ref byte[] arr, byte b)
        {
            List<byte> temp = new List<byte>();
            foreach (var x in arr)
                temp.Add(x);
            temp.Add(b);
            arr = temp.ToArray();
        }
        public static byte[] GenerateName(this string value)
        {
            var bytes = value.Encode(7);
            Push(ref bytes, 0x50);
            return bytes;
        }
        
    }
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
                result.SetBit(i,bits[i]);
            return result;
        }

    }
}

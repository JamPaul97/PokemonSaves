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
    public static class ToolBox
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
            ToolBox.Push(ref bytes, 0x50);
            return bytes;
        }
    }
}

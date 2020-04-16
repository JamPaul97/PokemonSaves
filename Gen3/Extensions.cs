
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public static class Extensions
    {
        
        public static byte[] SubArray(this byte[] arr, uint start, uint lenght)
        {
            List<byte> result = new List<byte>();
            for (uint i = start; i < start + lenght; i++)
                result.Add(arr[i]);
            return result.ToArray();
        }
        

        public static byte[] Replace(this byte[] arr, uint start, byte[] bytes)
        {
            for (uint i = start; i < start+bytes.Length; i++)
            {
                arr[i] = bytes[i - start];
            }
            return arr;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen4.Save
{
    public static class Checksum
    {
        private static int[] SeedTable
        {
            get 
            {
                var SeedTable = new int[0x100];
                int index = 0;
                int result = 0;

                do
                {
                    result = index << 8;
                    int index2 = 0;
                    do
                    {
                        if (((byte)(result >> 8) & 0x80) != 0)
                            result = (2 * result) ^ 0x1021;
                        else
                            result *= 2;
                    }
                    while (++index2 < 8);

                    SeedTable[index++] = (ushort)(result);
                } while (index <= 0xFF);
                return SeedTable;
            }
        }
        public static ushort GenerateChecksum(byte[] data)
        {
            int sum = 0xFFFF;
            for (int i = 0; i < data.Length; i++)
                sum = (sum << 8) ^ SeedTable[(byte)(data[i] ^ (byte)(sum >> 8))];
            return (ushort)sum;
        }
    }
}

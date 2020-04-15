using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public class Section
    {
        private readonly int[] CheckSumSize = {3884,3968,3968,3968,3848,3968,3968,3968,3968,3968,3968,3968,3968,2000};
        public readonly string[] SectionName =
        {
            "Trainer Info",
            "Team/Items",
            "Game State",
            "Misc Data",
            "Rival Info",
            "PC Buffer A",
            "PC Buffer B",
            "PC Buffer C",
            "PC Buffer D",
            "PC Buffer E",
            "PC Buffer F",
            "PC Buffer G",
            "PC Buffer H",
            "PC Buffer I",
        };
        public const int Size = 4096;
        public byte[] data;
        private byte[] realData;
        public ushort SectionID;
        public ushort CheckSum;
        public int SaveIndex;
        public Section(byte[] data)
        {
            if (data.Length != Size)
                throw new Exception("Wrong Format");
            this.data = data;
            realData = new byte[3968];
            Array.Copy(data, 0, realData,0, 3968);
            SectionID = BitConverter.ToUInt16(data.SubArray(0x0FF4, 2), 0);
            CheckSum = BitConverter.ToUInt16(data.SubArray(0x0FF6, 2), 0);
            SaveIndex = BitConverter.ToInt32(data.SubArray(0x0FFC, 4), 0);
            if (!CheckSumCheck())
                throw new Exception("Section's " + SectionID + " Checksum was not correct");
        }
        public bool CheckSumCheck()
        {
            int re = 0;
            for (uint i = 0; i < CheckSumSize[SectionID] / 4; i++)
            {
                re += BitConverter.ToInt32(this.data.SubArray(i * 4, 4), 0);
            }
            byte[] arrr = BitConverter.GetBytes(re);
            ushort cc = BitConverter.ToUInt16(arrr.SubArray(0, 2), 0);
            ushort dd = BitConverter.ToUInt16(arrr.SubArray(2, 2), 0);
            cc += dd;
            return cc == CheckSum;
        }        
    }
}

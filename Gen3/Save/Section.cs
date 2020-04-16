using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Save
{
    public class Section
    {
        internal readonly uint size = 4096;
        internal readonly ushort[] ids = new ushort[]
        {
            3884,3968,3968,3968,3848,3968,3968,3968,3968,3968,3968,3968,3968,2000
        };
        internal byte[] wholeData;
        internal byte[] data;
        internal ushort sectionID;
        internal ushort checksum;
        internal uint saveIndex;
        public Section(byte[] arr)
        {
            if (arr.Length != this.size)
                throw new FormatException();
            this.wholeData = arr;
            Initialize();
        }
        internal void Initialize()
        {
            this.data = this.wholeData.SubArray(0, 3968);
            this.sectionID = BitConverter.ToUInt16(this.wholeData, 0x0ff4);
            this.checksum = BitConverter.ToUInt16(this.wholeData, 0x0ff6);
            this.saveIndex = BitConverter.ToUInt32(this.wholeData, 0x0ffc);
            if (GenerateCheckSum() != this.checksum)
                throw new Exception("Checksum mismatch");
        }
        internal ushort GenerateCheckSum()
        {
            uint a = 0;
            for (uint i = 0; i < ids[this.sectionID] / 4; i++)
                a += BitConverter.ToUInt32(this.wholeData, (int)i * 4);
            byte[] bytes = BitConverter.GetBytes(a);
            return (ushort)(BitConverter.ToUInt16(bytes, 0) + BitConverter.ToUInt16(bytes, 2));
        }
    }
}

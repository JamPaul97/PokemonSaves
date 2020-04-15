using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public class HoF
    {
        public const int Size = 8192;
        private byte[] data;
        public HoF(byte[] data)
        {
            if (data.Length != Size)
                throw new Exception("Wrong Format");
            this.data = data;
        }
    }
}

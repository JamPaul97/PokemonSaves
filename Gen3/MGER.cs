using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public class MGER
    {
        public const int Size = 4096;
        private byte[] data;
        public MGER(byte[] data)
        {
            if (data.Length != Size)
                throw new Exception("Wrong Format");
            this.data = data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives
{
    public class TimePlayed
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
        public int Frames;
        public TimePlayed(byte[] arr)
        {
            if (arr.Length != 5)
                throw new Exception("The TimePlayed format is wrong");
            this.Hours = BitConverter.ToInt32(new byte[] { arr[0], arr[1],0,0 }, 0);
            this.Minutes = BitConverter.ToInt32(new byte[] { arr[2],0, 0, 0 }, 0);
            this.Seconds = BitConverter.ToInt32(new byte[] { arr[3],0, 0, 0  }, 0);
            this.Frames = BitConverter.ToInt32(new byte[] { arr[4],0, 0, 0 }, 0);
        }
    }
}

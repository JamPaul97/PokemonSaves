using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace Gen3.Save
{
    public class GameSave
    {
        private readonly uint Size = 57344;
        private byte[] data;
        public Section[] sections; 
        internal GameSave(byte[] data)
        {
            if (data.Length != this.Size)
                throw new FormatException();
            this.data = data;
            Initialize();
        }
        internal void Initialize()
        {
            this.sections = new Section[14];
            for (uint i = 0; i < 14; i++)
            {
                sections[i] = new Section(this.data.Sub(i * 4096, 4096));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
    [Serializable]
    public class Cache
    {
        public string fileName;
        public string resource;
        public int id;
        public DateTime date;
    }
}

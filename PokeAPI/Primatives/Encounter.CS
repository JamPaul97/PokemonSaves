using System;
using System.Collections.Generic;
namespace PokeAPI.Primatives
{
    [Serializable]
    public class Encounter
    {
        public int min_level;
        public int max_level;
        public List<NamedAPIResource> condition_values;
        public int chance;
        public NamedAPIResource method;
    }
}

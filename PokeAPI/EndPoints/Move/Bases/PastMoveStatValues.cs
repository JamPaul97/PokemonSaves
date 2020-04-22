using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class PastMoveStatValues
    {
        public int accuracy;
        public int effect_chance;
        public int power;
        public int pp;
        public List<Primatives.VerboseEffect> effect_entries;
        public Primatives.NamedAPIResource type;
        public Primatives.NamedAPIResource version_group;
    }
}

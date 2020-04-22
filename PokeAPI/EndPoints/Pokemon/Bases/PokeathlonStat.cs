using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokeathlonStat
    {
        public int id;
        public string name;
        public List<Primatives.Name> names;
        public NaturePokeathlonStatAffectSets affecting_natures;
    }
}

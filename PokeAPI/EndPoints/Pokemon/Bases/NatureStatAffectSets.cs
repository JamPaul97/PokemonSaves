using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class NatureStatAffectSets
    {
        public List<Primatives.NamedAPIResource> increase;
        public List<Primatives.NamedAPIResource> decrease;
    }
}

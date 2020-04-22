using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class NaturePokeathlonStatAffectSets
    {
        public List<NaturePokeathlonStatAffect> increase;
        public List<NaturePokeathlonStatAffect> decrease;
    }
}

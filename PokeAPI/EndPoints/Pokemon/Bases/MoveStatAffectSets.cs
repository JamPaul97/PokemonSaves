using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class MoveStatAffectSets
    {
        public List<MoveStatAffect> increase;
        public List<MoveStatAffect> decrease;
    }
}

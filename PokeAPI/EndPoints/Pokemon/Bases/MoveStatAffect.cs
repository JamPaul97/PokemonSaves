using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class MoveStatAffect
    {
        public int change;
        public Primatives.NamedAPIResource move;
    }
}

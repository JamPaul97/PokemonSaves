using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class NaturePokeathlonStatAffect
    {
        public int max_change;
        public Primatives.NamedAPIResource nature;
    }
}

using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class NatureStatChange
    {
        public int max_change;
        public Primatives.NamedAPIResource pokeathlon_stat;
    }
}

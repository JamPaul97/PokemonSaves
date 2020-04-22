using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonStat
    {
        public Primatives.NamedAPIResource stat;
        public int effort;
        public int base_stat;
    }
}

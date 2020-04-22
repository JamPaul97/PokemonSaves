using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonSpeciesVariety
    {
        public bool is_default;
        public Primatives.NamedAPIResource pokemon;
    }
}

using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonSpeciesDexEntry
    {
        public int entry_number;
        public Primatives.NamedAPIResource pokedex;
    }
}

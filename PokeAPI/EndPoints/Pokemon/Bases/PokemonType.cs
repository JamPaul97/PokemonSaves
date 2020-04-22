using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonType
    {
        public int slot;
        public Primatives.NamedAPIResource type;
    }
}

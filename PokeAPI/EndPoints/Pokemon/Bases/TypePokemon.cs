using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class TypePokemon
    {
        public int slot;
        public Primatives.NamedAPIResource pokemon;
    }
}

using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonHeldItemVersion
    {
        public Primatives.NamedAPIResource version;
        public int rarity;
    }
}

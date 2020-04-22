using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonHeldItem
    {
        public Primatives.NamedAPIResource item;
        public List<PokemonHeldItemVersion> version_details;
    }
}

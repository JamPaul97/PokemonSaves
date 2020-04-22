using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonMove
    {
        public Primatives.NamedAPIResource move;
        public List<PokemonMoveVersion> version_group_details;
    }
}

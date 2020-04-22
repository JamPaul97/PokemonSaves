using System;
namespace PokeAPI.EndPoints.Item.Bases
{
    [Serializable]
    public class HolderPokemon
    {
        public Primatives.NamedAPIResource pokemon;
        public System.Collections.Generic.List<HolderPokemonVersionDetail> version_details;
    }
}

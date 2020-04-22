using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class AbilityPokemon
    {
        public bool is_hidden;
        public int slot;
        public Primatives.NamedAPIResource pokemon;
    }
}

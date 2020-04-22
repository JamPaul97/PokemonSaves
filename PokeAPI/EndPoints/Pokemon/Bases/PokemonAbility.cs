using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonAbility
    {
        public bool is_hidder;
        public int slot;
        public Primatives.NamedAPIResource ability;
    }
}

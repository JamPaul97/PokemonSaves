using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonMoveVersion
    {
        public Primatives.NamedAPIResource move_learn_method;
        public Primatives.NamedAPIResource version_group;
        public int level_learned_at;
    }
}

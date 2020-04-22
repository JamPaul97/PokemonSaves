using System;
using System.Collections.Generic;
using PokeAPI.Primatives;

namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Ability
    {
        public int id;
        public string name;
        public bool is_main_series;
        public NamedAPIResource generation;
        public List<Name> names;
        public List<VerboseEffect> effect_entries;
        public List<AbilityEffectChange> effect_changes;
        public List<AbilityFlavorText> flavor_text_entries;
        public List<AbilityPokemon> pokemon;
    }
}

using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class AbilityEffectChange
    {
        public List<Primatives.Effect> effect_entries;
        public Primatives.NamedAPIResource version_group;
    }
}

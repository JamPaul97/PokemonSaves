using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class GrowthRate
    {
        public int id;
        public string name;
        public string formula;
        public List<Primatives.Description> descriptions;
        public List<GrowthRateExperienceLevel> levels;
        public List<Primatives.NamedAPIResource> pokemon_species;
    }
}

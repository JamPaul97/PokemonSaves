using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Gender
    {
        public int id;
        public string name;
        public List<PokemonSpeciesGender> pokemon_species_details;
        public List<Primatives.NamedAPIResource> required_for_evolution;
    }
}

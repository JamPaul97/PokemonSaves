using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonShape
    {
        public int id;
        public string name;
        public List<AwesomeName> awesome_names;
        public List<Primatives.Name> names;
        public List<Primatives.NamedAPIResource> pokemon_species;
    }
}

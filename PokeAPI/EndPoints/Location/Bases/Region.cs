using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class Region
    {
        public int id;
        public List<Primatives.NamedAPIResource> locations;
        public string name;
        public List<Primatives.Name> names;
        public Primatives.NamedAPIResource main_generation;
        public List<Primatives.NamedAPIResource> pokedexes;
        public List<Primatives.NamedAPIResource> version_group;
    }
}

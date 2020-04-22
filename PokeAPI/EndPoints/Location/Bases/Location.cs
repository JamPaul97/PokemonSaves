using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class Location
    {
        public int id;
        public string name;
        public Primatives.NamedAPIResource region;
        public List<Primatives.Name> names;
        public List<Primatives.GenerationGameIndex> game_indices;
        public List<Primatives.NamedAPIResource> areas;
    }
}

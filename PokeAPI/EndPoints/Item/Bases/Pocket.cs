using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Item.Bases
{
    [Serializable]
    public class Pocket
    {
        public int id;
        public string name;
        public List<Primatives.NamedAPIResource> categories;
        public List<Primatives.Name> names;
    }
}

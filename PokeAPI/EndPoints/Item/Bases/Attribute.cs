using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Item.Bases
{
    [Serializable]
    public class Attribute
    {
        public int id;
        public string name;
        public List<Primatives.NamedAPIResource> items;
        public List<Primatives.Name> names;
        public List<Primatives.Description> descriptions;
    }
}

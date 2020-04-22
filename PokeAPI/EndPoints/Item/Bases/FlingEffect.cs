using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Item.Bases
{
    [Serializable]
    public class FlingEffect
    {
        public int id;
        public string name;
        public List<Primatives.Effect> effect_entries;
        public List<Primatives.NamedAPIResource> items;
    }
}

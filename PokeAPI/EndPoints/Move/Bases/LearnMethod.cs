using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class LearnMethod
    {
        public int id;
        public string name;
        public List<Primatives.Description> descriptions;
        public List<Primatives.Name> names;
        public List<Primatives.NamedAPIResource> version_groups;
    }
}

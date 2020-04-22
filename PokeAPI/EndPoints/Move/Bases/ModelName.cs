using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class ModelName
    {
        public int id;
        public string name;
        public List<Primatives.NamedAPIResource> moves;
        public List<Primatives.Description> descriptions;
    }
}

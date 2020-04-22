using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class ContestComboDetail
    {
        public List<Primatives.NamedAPIResource> use_before;
        public List<Primatives.NamedAPIResource> use_after;
    }
}

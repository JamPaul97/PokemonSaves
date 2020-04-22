using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class BattleStyle
    {
        public int id;
        public string name;
        public List<Primatives.Name> names;
    }
}

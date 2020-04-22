using System;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class StatChange
    {
        public int change;
        public Primatives.NamedAPIResource stat;
    }
}

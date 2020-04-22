using System;
namespace PokeAPI.EndPoints.Machine.Bases
{
    [Serializable]
    public class Machine
    {
        public int id;
        public Primatives.NamedAPIResource item;
        public Primatives.NamedAPIResource move;
        public Primatives.NamedAPIResource version_group;
    }
}

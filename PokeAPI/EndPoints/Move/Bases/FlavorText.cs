using System;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class FlavorText
    {
        public string flavor_text;
        public Primatives.NamedAPIResource language;
        public Primatives.NamedAPIResource version_group;
    }
}

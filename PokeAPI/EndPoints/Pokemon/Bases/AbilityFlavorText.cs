using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class AbilityFlavorText
    {
        public string flavor_text;
        public Primatives.NamedAPIResource language;
        public Primatives.NamedAPIResource version_group;
    }
}

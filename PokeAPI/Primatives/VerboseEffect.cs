using System;
namespace PokeAPI.Primatives
{
    [Serializable]
    public class VerboseEffect
    {
        public string effect;
        public string short_effect;
        public NamedAPIResource language;
    }
}

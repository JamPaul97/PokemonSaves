using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PalParkEncounterArea
    {
        public int base_score;
        public int rate;
        public Primatives.NamedAPIResource area;
    }
}

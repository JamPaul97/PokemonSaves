using System;
namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class PalParkEncounterSpecies
    {
        public int base_score;
        public int rate;
        public Primatives.NamedAPIResource pokemon_species;
    }
}

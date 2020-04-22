using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class Area
    {
        public int id;
        public string name;
        public int game_index;
        public List<EncounterMethodRate> encounter_method_rates;
        public Primatives.NamedAPIResource location;
        public List<Primatives.Name> names;
        public List<PokemonEncounter> pokemon_encounters;
    }
}

using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class PalParkArea
    {
        public int id;
        public string name;
        public List<Primatives.Name> names;
        public List<PalParkEncounterSpecies> pokemon_encounters;
    }
}

using System;
using System.Collections.Generic;
namespace PokeAPI.Primatives
{
    [Serializable]
    public class VersionEncounterDetail
    {
        public NamedAPIResource version;
        public int max_change;
        public List<Encounter> encounter_details;
    }
}

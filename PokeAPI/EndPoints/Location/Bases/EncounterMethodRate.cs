using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class EncounterMethodRate
    {
        public Primatives.NamedAPIResource encounter_method;
        public List<EncounterVersionDetails> version_details;
    }
}

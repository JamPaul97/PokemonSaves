using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.EndPoints.Location.Bases
{
    [Serializable]
    public class PokemonEncounter
    {
        public Primatives.NamedAPIResource pokemon;
        public List<Primatives.VersionEncounterDetail> version_details;
    }
}

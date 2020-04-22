using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonForm
    {
        public int id;
        public string name;
        public int order;
        public int form_order;
        public bool is_default;
        public bool is_battle_only;
        public bool is_mega;
        public string form_name;
        public Primatives.NamedAPIResource pokemon;
        public PokemonFormSprites sprites;
        public Primatives.NamedAPIResource version_group;
        public List<Primatives.Name> names;
        public List<Primatives.Name> form_names;
    }
}

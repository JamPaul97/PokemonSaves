using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.EndPoints.Item.Bases
{
    [System.Serializable]
    public class Item
    {
        public int id;
        public string name;
        public int? cost;
        public int? fling_power;
        public Primatives.NamedAPIResource fling_effect;
        public List<Primatives.NamedAPIResource> attributes;
        public Primatives.NamedAPIResource category;
        //                                                                    public List<VersboseEffect> effect_entries;
        public List<Primatives.FlavorText> flavor_text_entries;
        public List<Primatives.Name> names;
        public Sprites sprites;
        public List<HolderPokemon> held_by_pokemon;
        public Primatives.APIResource baby_trigger_for;
        public List<Primatives.MachineVersionDetail> machines;
    }
}

using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Stat
    {
        public int id;
        public string name;
        public int game_index;
        public bool is_battle_only;
        public MoveStatAffectSets affecting_moves;
        public NatureStatAffectSets affecting_natures;
        public List<Primatives.APIResource> characteristics;
        public Primatives.NamedAPIResource move_damage_class;
        public List<Primatives.Name> names;
    }
}

using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Nature
    {
        public int id;
        public string name;
        public Primatives.NamedAPIResource decreased_stat;
        public Primatives.NamedAPIResource increased_stat;
        public Primatives.NamedAPIResource hates_flavor;
        public Primatives.NamedAPIResource likes_flavor;
        public List<NatureStatChange> pokeathlon_stat_changes;
        public List<MoveBattleStylePreference> move_battle_style_preferences;
        public List<Primatives.Name> names;
    }
}

using System;
namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class MetaData
    {
        public Primatives.NamedAPIResource ailment;
        public Primatives.NamedAPIResource category;
        public int? min_hits;
        public int? max_hits;
        public int? min_turns;
        public int? max_turns;
        public int? drain;
        public int? healing;
        public int? crit_rate;
        public int? ailment_chance;
        public int? flinch_chance;
        public int? stat_chance;
    }
}

namespace PokeAPI.EndPoints.Evolution.Bases
{
    [System.Serializable]
    public class Detail
    {
        public Primatives.NamedAPIResource item;
        public Primatives.NamedAPIResource trigger;
        public int? gender;
        public Primatives.NamedAPIResource held_item;
        public Primatives.NamedAPIResource known_moves;
        public Primatives.NamedAPIResource location;
        public int? min_level;
        public int? min_happiness;
        public int? min_beauty;
        public int? min_affection;
        public bool needs_overworld_rain;
        public Primatives.NamedAPIResource party_species; 
        public Primatives.NamedAPIResource party_type;
        public int? relative_physical_stats;
        public string time_of_day;
        public Primatives.NamedAPIResource trade_species;
        public bool turn_upside_down;
    }
}

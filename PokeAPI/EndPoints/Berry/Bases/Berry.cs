namespace PokeAPI.EndPoints.Berry.Bases
{
    [System.Serializable]
    public class Berry
    {
        public int id;
        public string name;
        public int growth_time;
        public int max_harvest;
        public int natural_gift_power;
        public int size;
        public int smoothness;
        public int soil_dryness;
        public Primatives.NamedAPIResource firmness;
        public System.Collections.Generic.List<FlavorMap> flavors;
        public Primatives.NamedAPIResource item;
        public Primatives.NamedAPIResource natural_gilf_type;
    }
}

namespace PokeAPI.EndPoints.Berry.Bases
{
    [System.Serializable]
    public class Flavor
    {
        public int id;
        public string name;
        public System.Collections.Generic.List<FlavorMap> berries;
        public Primatives.NamedAPIResource contest_type;
        public System.Collections.Generic.List<Primatives.Name> names;
    }
}

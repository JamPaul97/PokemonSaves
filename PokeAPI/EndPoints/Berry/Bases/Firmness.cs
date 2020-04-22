namespace PokeAPI.EndPoints.Berry.Bases
{
    [System.Serializable]
    public class Firmness
    {
        public int id;
        public string name;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> berries;
        public System.Collections.Generic.List<Primatives.Name> names;
    }
}

namespace PokeAPI.EndPoints.Encounter.Bases
{
    [System.Serializable]
    public class Condition
    {
        public int id;
        public string name;
        public System.Collections.Generic.List<Primatives.Name> names;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> values;
    }
}

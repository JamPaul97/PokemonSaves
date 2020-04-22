namespace PokeAPI.EndPoints.Encounter.Bases
{
    [System.Serializable]
    public class ConditionValue
    {
        public int id;
        public string name;
        public Primatives.NamedAPIResource condition;
        public System.Collections.Generic.List<Primatives.Name> names;
    }
}

namespace PokeAPI.EndPoints.Contest.Bases
{
    [System.Serializable]
    public class Type
    {
        public int id;
        public string name;
        public Primatives.NamedAPIResource berry_flavor;
        public System.Collections.Generic.List<ContestName> names;
    }
}

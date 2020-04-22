namespace PokeAPI.EndPoints.Version.Bases
{
    [System.Serializable]
    public class Version
    {
        public int id;
        public string name;
        public System.Collections.Generic.List<Primatives.Name> names;
        public Primatives.NamedAPIResource version_group;
    }
}

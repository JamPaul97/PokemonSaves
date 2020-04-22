namespace PokeAPI.EndPoints.VersionGroup.Bases
{
    [System.Serializable]
    public class VersionGroup
    {
        public int id;
        public string name;
        public int order;
        public Primatives.NamedAPIResource generation;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> move_learn_methods;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> pokedexes;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> versions;
    }
}

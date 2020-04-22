namespace PokeAPI.EndPoints.Generation.Bases
{
    [System.Serializable]
    public class Generation
    {
        public int id;
        public string name;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> abilities;
        public System.Collections.Generic.List<Primatives.Name> names;
        public Primatives.NamedAPIResource main_region;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> moves;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> pokemon_species;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> types;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> version_groups;
    }
}

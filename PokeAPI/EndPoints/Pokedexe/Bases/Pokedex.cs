namespace PokeAPI.EndPoints.Pokedex.Bases
{
    [System.Serializable]
    public class Pokedex
    {
        public int id;
        public string name;
        public bool is_main;
        public System.Collections.Generic.List<Primatives.Description> descriptions;
        public System.Collections.Generic.List<Primatives.Name> names;
        public System.Collections.Generic.List<PokemonEntry> pokemon_entries;
        public Primatives.NamedAPIResource region;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> version_groups;
    }
}

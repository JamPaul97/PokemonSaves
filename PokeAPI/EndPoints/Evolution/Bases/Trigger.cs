namespace PokeAPI.EndPoints.Evolution.Bases
{
    [System.Serializable]
    public class Trigger
    {
        public int id;
        public string name;
        public System.Collections.Generic.List<Primatives.Name> names;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> pokemon_species;
    }
}

namespace PokeAPI.Primatives
{
    [System.Serializable]
    public class EndpointBase
    {
        public int count;
        public string next;
        public string previous;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> results;
    }
}

namespace PokeAPI.EndPoints.SuperContest.Bases
{
    [System.Serializable]
    public class Effect
    {
        public int id;
        public int appeal;
        public System.Collections.Generic.List<Primatives.FlavorText> flavor_text_entries;
        public System.Collections.Generic.List<Primatives.NamedAPIResource> moves;
    }
}

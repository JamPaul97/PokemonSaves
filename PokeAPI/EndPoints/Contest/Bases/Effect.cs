namespace PokeAPI.EndPoints.Contest.Bases
{
    [System.Serializable]
    public class Effect
    {
        public int id;
        public int appeal;
        public int jam;
        public System.Collections.Generic.List<EffectEntry> effect_entries;
        public System.Collections.Generic.List<Primatives.FlavorText> flavor_text_entries;
    }
}

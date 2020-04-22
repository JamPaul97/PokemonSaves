using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class MoveBattleStylePreference
    {
        public int low_hp_preference;
        public int high_hp_preference;
        public Primatives.NamedAPIResource move_battle_style;
    }
}

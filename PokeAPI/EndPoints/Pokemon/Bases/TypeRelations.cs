using System;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class TypeRelations
    {
        public Primatives.NamedAPIResource no_damage_to;
        public Primatives.NamedAPIResource half_damage_to;
        public Primatives.NamedAPIResource double_damage_to;
        public Primatives.NamedAPIResource no_damage_from;
        public Primatives.NamedAPIResource half_damage_from;
        public Primatives.NamedAPIResource double_damage_from;
    }
}

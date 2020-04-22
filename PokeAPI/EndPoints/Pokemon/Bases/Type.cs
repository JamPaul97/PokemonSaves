using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Type
    {
        public int id;
        public string name;
        public TypeRelations damage_relations;
        public List<Primatives.GenerationGameIndex> game_indices;
        public Primatives.NamedAPIResource generation;
        public Primatives.NamedAPIResource move_damage_class;
        public List<Primatives.Name> names;
        public List<TypePokemon> pokemon;
        public List<Primatives.NamedAPIResource> moves;
    }
}

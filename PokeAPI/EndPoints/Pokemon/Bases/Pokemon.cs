using System;
using System.Collections.Generic;
using PokeAPI.Primatives;

namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Pokemon
    {
        public int id;
        public string name;
        public int base_experience;
        public int height;
        public bool is_default;
        public int order;
        public int weight;
        public List<PokemonAbility> abilities;
        public List<NamedAPIResource> forms;
        public List<Primatives.VersionGameIndex> game_indices;
        public List<PokemonHeldItem> held_items;
        public string location_area_encounters;
        public List<PokemonMove> moves;
        public PokemonSprites sprites;
        public NamedAPIResource species;
        public List<PokemonStat> stats;
        public List<PokemonType> types;
    }
}

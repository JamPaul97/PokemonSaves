using System;
using System.Collections.Generic;
using PokeAPI.Primatives;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class PokemonSpecies
    {
        public int id;
        public string name;
        public int order;
        public int gender_rate;
        public int capture_rate;
        public int base_happiness;
        public bool is_baby;
        public int hatch_counter;
        public bool has_gender_differences;
        public bool forms_switchable;
        public NamedAPIResource growth_rate;
        public List<PokemonSpeciesDexEntry> pokedex_numbers;
        public List<NamedAPIResource> egg_groups;
        public NamedAPIResource color;
        public NamedAPIResource shape;
        public NamedAPIResource evolves_from_species;
        public APIResource evolution_chain;
        public NamedAPIResource habitat;
        public NamedAPIResource generation;
        public List<Name> names;
        public List<PalParkEncounterArea> pal_park_encounters;
        public List<FlavorText> flavor_text_entries;
        public List<Description> form_descriptions;
        public List<Genus> genera;
        public List<PokemonSpeciesVariety> varieties;
    }
}

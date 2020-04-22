using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI.EndPoints.Move.Bases
{
    [Serializable]
    public class Move
    {
        public int id;
        public string name;
        public int accuracy;
        public int effect_chance;
        public int pp;
        public int priority;
        public int power;
        public ContestComboSets contest_combos;
        public Primatives.NamedAPIResource contest_type;
        public Primatives.APIResource contest_effect;
        public Primatives.NamedAPIResource damage_class;
        public List<Primatives.VerboseEffect> effect_entries;
        public List<Pokemon.Bases.AbilityEffectChange> effect_changes;
        public List<FlavorText> flavor_text_entries;
        public Primatives.NamedAPIResource generation;
        public List<Primatives.MachineVersionDetail> machines;
        public MetaData meta;
        public List<Primatives.Name> names;
        public List<PastMoveStatValues> past_values;
        public List<StatChange> stat_changes;
        public Primatives.APIResource super_contest_effect;
        public Primatives.NamedAPIResource target;
        public Primatives.NamedAPIResource type;
    }
}

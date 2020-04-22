using System;
using System.Collections.Generic;
namespace PokeAPI.EndPoints.Pokemon.Bases
{
    [Serializable]
    public class Characteristic
    {
        public int id;
        public int gene_modulo;
        public List<int> possible_values;
    }
}

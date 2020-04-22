
namespace PokeAPI.EndPoints.Evolution.Bases
{
    public class ChainLink
    {
        public bool is_baby;
        public Primatives.NamedAPIResource species;
        public System.Collections.Generic.List<Detail> evolution_details;
        public System.Collections.Generic.List<ChainLink> evolves_to;
    }
}

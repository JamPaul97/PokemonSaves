using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeAPI.EndPoints;
namespace PokeAPI
{
    public static class Connector
    {
        #region "Structure"
        public static Berries                   Berries                     ;
        public static BerryFirmnesses           BerryFirmnesses             ;
        public static BerryFlavors              BerryFlavors                ;
        public static ContestNames              ContestNames                ;
        public static ContestEffects            ContestEffects              ;
        public static SuperContestEffects       SuperContestEffects         ;
        public static EncounterMethods          EncounterMethods            ;
        public static EncounterConditions       EncounterConditions         ;
        public static EncounterConditionValues  EncounterConditionValues    ;
        public static EvolutionChains           EvolutionChains             ;
        public static EvolutionTrigger          EvolutionTrigger            ;
        public static Generations               Generations                 ;
        public static Pokedexes                 Pokedexes                   ;
        public static Versions                  Versions                    ;
        public static VersionGroups             VersionGroups               ;
        public static Items                     Items                       ;
        public static ItemAttributes            ItemAttributes              ;
        public static ItemCategories            ItemCategories              ;
        public static ItemFlingEffects          ItemFlingEffects            ;
        public static ItemPockets               ItemPockets                 ;
        public static Locations                 Locations                   ;
        public static LocationAreas             LocationAreas               ;
        public static PalParkAreas              PalParkAreas                ;
        public static Regions                   Regions                     ;
        public static Machines                  Machines                    ;
        public static Moves                     Moves                       ;
        public static MoveAilments              MoveAilments                ;
        public static MoveBattleStyles          MoveBattleStyles            ;
        public static MoveCategories            MoveCategories              ;
        public static MoveDamageClasses         MoveDamageClasses           ;
        public static MoveLearnMethods          MoveLearnMethods            ;
        public static MoveTargets               MoveTargets                 ;
        public static Abilities                 Abilities                   ;
        public static Characteristics           Characteristics             ;
        public static EggGroups                 EggGroups                   ;
        public static Genders                   Genders                     ;
        public static GrowthRates               GrowthRates                 ;
        public static Natures                   Natures                     ;
        public static PokeathlonStats           PokeathlonStats             ;
        public static Pokemons                  Pokemons                    ;
        public static PokemonColors             PokemonColors               ;
        public static PokemonForms              PokemonForms                ;
        public static PokemonHabitats           PokemonHabitats             ;
        public static PokemonShapes             PokemonShapes               ;
        public static PokemonSpecies            PokemonSpecies              ;
        public static Stats                     Stats                       ;
        public static Types                     Types                       ;
        public static Languages                 Languages                   ;
        #endregion

        internal static string CacheFolder;
        internal static bool isInitialized = false;
        public static void Initialize(string CacheFolder = "")
        {
            if (Connector.isInitialized)
                throw new Exception("PokeAPI is initialized and can only be initialized once"); //May seems a bit over kill but this is nessecery for corrent usage.
            #region "Structure"
            Connector.Berries                       = new Berries();
            Connector.BerryFirmnesses               = new BerryFirmnesses();
            Connector.BerryFlavors                  = new BerryFlavors();
            Connector.ContestNames                  = new ContestNames();
            Connector.ContestEffects                = new ContestEffects();
            Connector.SuperContestEffects           = new SuperContestEffects();
            Connector.EncounterMethods              = new EncounterMethods();
            Connector.EncounterConditions           = new EncounterConditions();
            Connector.EncounterConditionValues      = new EncounterConditionValues();
            Connector.EvolutionChains               = new EvolutionChains();
            Connector.EvolutionTrigger              = new EvolutionTrigger();
            Connector.Generations                   = new Generations();
            Connector.Pokedexes                     = new Pokedexes();
            Connector.Versions                      = new Versions();
            Connector.VersionGroups                 = new VersionGroups();
            Connector.Items                         = new Items();
            Connector.ItemAttributes                = new ItemAttributes();
            Connector.ItemCategories                = new ItemCategories();
            Connector.ItemFlingEffects              = new ItemFlingEffects();
            Connector.ItemPockets                   = new ItemPockets();
            Connector.Locations                     = new Locations();
            Connector.LocationAreas                 = new LocationAreas();
            Connector.PalParkAreas                  = new PalParkAreas();
            Connector.Regions                       = new Regions();
            Connector.Machines                      = new Machines();
            Connector.Moves                         = new Moves();
            Connector.MoveAilments                  = new MoveAilments();
            Connector.MoveBattleStyles              = new MoveBattleStyles();
            Connector.MoveCategories                = new MoveCategories();
            Connector.MoveDamageClasses             = new MoveDamageClasses();
            Connector.MoveLearnMethods              = new MoveLearnMethods();
            Connector.MoveTargets                   = new MoveTargets();
            Connector.Abilities                     = new Abilities();
            Connector.Characteristics               = new Characteristics();
            Connector.EggGroups                     = new EggGroups();
            Connector.Genders                       = new Genders();
            Connector.GrowthRates                   = new GrowthRates();
            Connector.Natures                       = new Natures();
            Connector.PokeathlonStats               = new PokeathlonStats();
            Connector.Pokemons                      = new Pokemons();
            Connector.PokemonColors                 = new PokemonColors();
            Connector.PokemonForms                  = new PokemonForms();
            Connector.PokemonHabitats               = new PokemonHabitats();
            Connector.PokemonShapes                 = new PokemonShapes();
            Connector.PokemonSpecies                = new PokemonSpecies();
            Connector.Stats                         = new Stats();
            Connector.Types                         = new Types();
            Connector.Languages                     = new Languages();
            #endregion
            if (CacheFolder == "")
            {
                Connector.CacheFolder = AppDomain.CurrentDomain.BaseDirectory + "pokeAPI//";
            }
            else
            {
                if (!System.IO.Directory.Exists(CacheFolder))
                    throw new Exception("Directory : " + CacheFolder + " was not found");
                Connector.CacheFolder = CacheFolder;
                
            }
            Cacher.Initialize();
            Connector.isInitialized = true;
        }
    }
}

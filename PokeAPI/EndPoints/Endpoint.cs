using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace PokeAPI.EndPoints
{
    public class Endpoint
    {
        internal const string Domain = "http://127.0.0.1:8000/api/v2/";
        internal virtual string URL { get; }
        internal Primatives.EndpointBase All()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Primatives.EndpointBase>(Domain + URL);
        }
        public Primatives.EndpointBase All(uint limit, uint offset)
        {
            //Check cache

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Primatives.EndpointBase>(WebConnector.Request(Domain + URL, new System.Collections.Specialized.NameValueCollection()
            {
                {"limit",limit.ToString() },
                {"offset",offset.ToString() }
            }));

            return obj;

        }
        internal string SingleURL(uint id) { return Domain + URL + id.ToString(); }
        internal Endpoint() { }
    }
    public class Berries : Endpoint
    {
        internal override string URL { get { return "berry/"; } }
        public Berry.Bases.Berry this[uint index]
        { get 
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Berry.Bases.Berry>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Berry.Bases.Berry>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                } 
            } 
        }
        internal Berries() { }
    }
    public class BerryFirmnesses : Endpoint
    {
        internal override string URL { get { return "berry-firmness/"; } }
        public Berry.Bases.Firmness this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Berry.Bases.Firmness>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Berry.Bases.Firmness>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal BerryFirmnesses() { }
    }
    public class BerryFlavors : Endpoint
    {
        internal override string URL { get { return "berry-flavor/"; } }
        public Berry.Bases.Flavor this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Berry.Bases.Flavor>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Berry.Bases.Flavor>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal BerryFlavors() { }
    }
    public class ContestNames : Endpoint
    {
        internal override string URL { get { return "contest-type/"; } }
        public Contest.Bases.ContestName this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Contest.Bases.ContestName>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Contest.Bases.ContestName>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal ContestNames() { }
    }
    public class ContestEffects : Endpoint
    {
        internal override string URL { get { return "contest-effect/"; } }
        public Contest.Bases.Effect this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), -1))
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Contest.Bases.Effect>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), -1)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Contest.Bases.Effect>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal ContestEffects() { }
    }
    public class SuperContestEffects : Endpoint
    {
        internal override string URL { get { return "super-contest-effect/"; } }
        public SuperContest.Bases.Effect this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<SuperContest.Bases.Effect>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<SuperContest.Bases.Effect>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal SuperContestEffects() { }
    }
    public class EncounterMethods : Endpoint
    {
        internal override string URL { get { return "encounter-method/"; } }
        public Encounter.Bases.Method this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Encounter.Bases.Method>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Encounter.Bases.Method>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal EncounterMethods() { }
    }
    public class EncounterConditions : Endpoint
    {
        internal override string URL { get { return "encounter-condition/"; } }
        public Encounter.Bases.Condition this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Encounter.Bases.Condition>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Encounter.Bases.Condition>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal EncounterConditions() { }
    }
    public class EncounterConditionValues : Endpoint
    {
        internal override string URL { get { return "encounter-condition-value/"; } }
        public Encounter.Bases.ConditionValue this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Encounter.Bases.ConditionValue>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Encounter.Bases.ConditionValue>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal EncounterConditionValues() { }
    }
    public class EvolutionChains : Endpoint
    {
        internal override string URL { get { return "evolution-chain/"; } }
        public Evolution.Bases.Chain this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Evolution.Bases.Chain>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Evolution.Bases.Chain>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal EvolutionChains() { }
    }
    public class EvolutionTrigger : Endpoint
    {
        internal override string URL { get { return "evolution-trigger/"; } }
        public Evolution.Bases.Trigger this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Evolution.Bases.Trigger>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Evolution.Bases.Trigger>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal EvolutionTrigger() { }
    }
    public class Generations : Endpoint
    {
        internal override string URL { get { return "generation/"; } }
        public Generation.Bases.Generation this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Generation.Bases.Generation>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Generation.Bases.Generation>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Generations() { }
    }
    public class Pokedexes : Endpoint
    {
        internal override string URL { get { return "pokedex/"; } }
        public Pokedex.Bases.Pokedex this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokedex.Bases.Pokedex>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokedex.Bases.Pokedex>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Pokedexes() { }
    }
    public class Versions : Endpoint
    {
        internal override string URL { get { return "version/"; } }
        public Version.Bases.Version this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Version.Bases.Version>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Version.Bases.Version>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Versions() { }
    }
    public class VersionGroups : Endpoint
    {
        internal override string URL { get { return "version-group/"; } }
        public VersionGroup.Bases.VersionGroup this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<VersionGroup.Bases.VersionGroup>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<VersionGroup.Bases.VersionGroup>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal VersionGroups() { }
    }
    public class Items : Endpoint
    {
        internal override string URL { get { return "item/"; } }
        public Item.Bases.Item this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Item.Bases.Item>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Item.Bases.Item>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Items() { }
    }
    public class ItemAttributes : Endpoint
    {
        internal override string URL { get { return "item-attribute/"; } }
        public Item.Bases.Attribute this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Item.Bases.Attribute>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Item.Bases.Attribute>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal ItemAttributes() { }
    }
    public class ItemCategories : Endpoint
    {
        internal override string URL { get { return "item-category/"; } }
        public Item.Bases.Category this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Item.Bases.Category>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Item.Bases.Category>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal ItemCategories() { }
    }
    public class ItemFlingEffects : Endpoint
    {
        internal override string URL { get { return "item-fling-effect/"; } }
        public Item.Bases.FlingEffect this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Item.Bases.FlingEffect>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Item.Bases.FlingEffect>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal ItemFlingEffects() { }
    }
    public class ItemPockets : Endpoint
    {
        internal override string URL { get { return "item-pocket/"; } }
        public Item.Bases.Pocket this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Item.Bases.Pocket>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Item.Bases.Pocket>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal ItemPockets() { }
    }
    public class Locations : Endpoint
    {
        internal override string URL { get { return "location/"; } }
        public Location.Bases.Location this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Location.Bases.Location>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Location.Bases.Location>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Locations() { }
    }
    public class LocationAreas : Endpoint
    {
        internal override string URL { get { return "location-area/"; } }
        public Location.Bases.Area this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Location.Bases.Area>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Location.Bases.Area>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal LocationAreas() { }
    }
    public class PalParkAreas : Endpoint
    {
        internal override string URL { get { return "pal-park-area/"; } }
        public Location.Bases.PalParkArea this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Location.Bases.PalParkArea>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Location.Bases.PalParkArea>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PalParkAreas() { }
    }
    public class Regions : Endpoint
    {
        internal override string URL { get { return "region/"; } }
        public Location.Bases.Region this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Location.Bases.Region>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Location.Bases.Region>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Regions() { }
    }
    public class Machines : Endpoint
    {
        internal override string URL { get { return "machine/"; } }
        public Machine.Bases.Machine this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Machine.Bases.Machine>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Machine.Bases.Machine>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Machines() { }
    }
    public class Moves : Endpoint
    {
        internal override string URL { get { return "move/"; } }
        public Move.Bases.Move this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.Move>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.Move>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Moves() { }
    }
    public class MoveAilments : Endpoint
    {
        internal override string URL { get { return "move-ailment/"; } }
        public Move.Bases.Ailment this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.Ailment>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.Ailment>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal MoveAilments() { }
    }
    public class MoveBattleStyles : Endpoint
    {
        internal override string URL { get { return "move-battle-style/"; } }
        public Move.Bases.BattleStyle this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.BattleStyle>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.BattleStyle>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal MoveBattleStyles() { }
    }
    public class MoveCategories : Endpoint
    {
        internal override string URL { get { return "move-battle-style/"; } }
        public Move.Bases.ModelName this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.ModelName>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.ModelName>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal MoveCategories() { }
    }
    public class MoveDamageClasses : Endpoint
    {
        internal override string URL { get { return "move-damage-class/"; } }
        public Move.Bases.DamageClass this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.DamageClass>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.DamageClass>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal MoveDamageClasses() { }
    }
    public class MoveLearnMethods : Endpoint
    {
        internal override string URL { get { return "move-learn-method/"; } }
        public Move.Bases.LearnMethod this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.LearnMethod>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.LearnMethod>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal MoveLearnMethods() { }
    }
    public class MoveTargets : Endpoint
    {
        internal override string URL { get { return "move-target/"; } }
        public Move.Bases.Target this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Move.Bases.Target>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Move.Bases.Target>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal MoveTargets() { }
    }
    public class Abilities : Endpoint
    {
        internal override string URL { get { return "ability/"; } }
        public Pokemon.Bases.Ability this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Ability>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Ability>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Abilities() { }
    }
    public class Characteristics : Endpoint
    {
        internal override string URL { get { return "characteristic/"; } }
        public Pokemon.Bases.Characteristic this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Characteristic>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Characteristic>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Characteristics() { }
    }
    public class EggGroups : Endpoint
    {
        internal override string URL { get { return "egg-group/"; } }
        public Pokemon.Bases.EggGroup this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.EggGroup>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.EggGroup>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal EggGroups() { }
    }
    public class Genders : Endpoint
    {
        internal override string URL { get { return "gender/"; } }
        public Pokemon.Bases.Gender this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Gender>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Gender>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Genders() { }
    }
    public class GrowthRates : Endpoint
    {
        internal override string URL { get { return "growth-rate/"; } }
        public Pokemon.Bases.GrowthRate this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.GrowthRate>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.GrowthRate>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal GrowthRates() { }
    }
    public class Natures : Endpoint
    {
        internal override string URL { get { return "nature/"; } }
        public Pokemon.Bases.Nature this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Nature>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Nature>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Natures() { }
    }
    public class PokeathlonStats : Endpoint
    {
        internal override string URL { get { return "pokeathlon-stat/"; } }
        public Pokemon.Bases.PokeathlonStat this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.PokeathlonStat>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.PokeathlonStat>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PokeathlonStats() { }
    }
    public class Pokemons : Endpoint
    {
        internal override string URL { get { return "pokemon/"; } }
        public Pokemon.Bases.Pokemon this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Pokemon>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Pokemon>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Pokemons() { }
    }
    public class PokemonColors : Endpoint
    {
        internal override string URL { get { return "pokemon-color/"; } }
        public Pokemon.Bases.PokemonColor this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.PokemonColor>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.PokemonColor>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PokemonColors() { }
    }
    public class PokemonForms : Endpoint
    {
        internal override string URL { get { return "pokemon-form/"; } }
        public Pokemon.Bases.PokemonForm this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.PokemonForm>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.PokemonForm>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PokemonForms() { }
    }
    public class PokemonHabitats : Endpoint
    {
        internal override string URL { get { return "pokemon-habitat/"; } }
        public Pokemon.Bases.PokemonHabitat this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.PokemonHabitat>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.PokemonHabitat>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PokemonHabitats() { }
    }
    public class PokemonShapes : Endpoint
    {
        internal override string URL { get { return "pokemon-shape/"; } }
        public Pokemon.Bases.PokemonShape this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.PokemonShape>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.PokemonShape>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PokemonShapes() { }
    }
    public class PokemonSpecies : Endpoint
    {
        internal override string URL { get { return "pokemon-species/"; } }
        public Pokemon.Bases.PokemonSpecies this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.PokemonSpecies>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.PokemonSpecies>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal PokemonSpecies() { }
    }
    public class Stats : Endpoint
    {
        internal override string URL { get { return "stat/"; } }
        public Pokemon.Bases.Stat this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Stat>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Stat>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Stats() { }
    }
    public class Types : Endpoint
    {
        internal override string URL { get { return "type/"; } }
        public Pokemon.Bases.Type this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Pokemon.Bases.Type>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Pokemon.Bases.Type>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Types() { }
    }
    public class Languages : Endpoint
    {
        internal override string URL { get { return "language/"; } }
        public Primatives.Language this[uint index]
        {
            get
            {
                if (Cacher.HasEntry(URL.Replace("/", ""), (int)index))
                    return JsonConvert.DeserializeObject<Primatives.Language>(System.IO.File.ReadAllText(Cacher.Read(URL.Replace("/", ""), (int)index)));
                else
                {
                    var obj = JsonConvert.DeserializeObject<Primatives.Language>(WebConnector.Request(SingleURL(index)));
                    Cacher.Cache(URL.Replace("/", ""), (int)index, obj);
                    return obj;
                }
            }
        }
        internal Languages() { }
    }
}
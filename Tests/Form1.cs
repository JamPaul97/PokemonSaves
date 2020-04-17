﻿using System;
using Toolbox;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gen3;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;
namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var x in Gen3.Data.Data.Species)
                listBox1.Items.Add(x.Value.Name);
            //Console.WriteLine(&aa.arr);
        }
        string[] poke = new string[] {"??????????",
"Bulbasaur",
"Ivysaur",
"Venusaur",
"Charmander",
"Charmeleon",
"Charizard",
"Squirtle",
"Wartortle",
"Blastoise",
"Caterpie",
"Metapod",
"Butterfree",
"Weedle",
"Kakuna",
"Beedrill",
"Pidgey",
"Pidgeotto",
"Pidgeot",
"Rattata",
"Raticate",
"Spearow",
"Fearow",
"Ekans",
"Arbok",
"Pikachu",
"Raichu",
"Sandshrew",
"Sandslash",
"Nidoran♀",
"Nidorina",
"Nidoqueen",
"Nidoran♂",
"Nidorino",
"Nidoking",
"Clefairy",
"Clefable",
"Vulpix",
"Ninetales",
"Jigglypuff",
"Wigglytuff",
"Zubat",
"Golbat",
"Oddish",
"Gloom",
"Vileplume",
"Paras",
"Parasect",
"Venonat",
"Venomoth",
"Diglett",
"Dugtrio",
"Meowth",
"Persian",
"Psyduck",
"Golduck",
"Mankey",
"Primeape",
"Growlithe",
"Arcanine",
"Poliwag",
"Poliwhirl",
"Poliwrath",
"Abra",
"Kadabra",
"Alakazam",
"Machop",
"Machoke",
"Machamp",
"Bellsprout",
"Weepinbell",
"Victreebel",
"Tentacool",
"Tentacruel",
"Geodude",
"Graveler",
"Golem",
"Ponyta",
"Rapidash",
"Slowpoke",
"Slowbro",
"Magnemite",
"Magneton",
"Farfetch'd",
"Doduo",
"Dodrio",
"Seel",
"Dewgong",
"Grimer",
"Muk",
"Shellder",
"Cloyster",
"Gastly",
"Haunter",
"Gengar",
"Onix",
"Drowzee",
"Hypno",
"Krabby",
"Kingler",
"Voltorb",
"Electrode",
"Exeggcute",
"Exeggutor",
"Cubone",
"Marowak",
"Hitmonlee",
"Hitmonchan",
"Lickitung",
"Koffing",
"Weezing",
"Rhyhorn",
"Rhydon",
"Chansey",
"Tangela",
"Kangaskhan",
"Horsea",
"Seadra",
"Goldeen",
"Seaking",
"Staryu",
"Starmie",
"Mr. Mime",
"Scyther",
"Jynx",
"Electabuzz",
"Magmar",
"Pinsir",
"Tauros",
"Magikarp",
"Gyarados",
"Lapras",
"Ditto",
"Eevee",
"Vaporeon",
"Jolteon",
"Flareon",
"Porygon",
"Omanyte",
"Omastar",
"Kabuto",
"Kabutops",
"Aerodactyl",
"Snorlax",
"Articuno",
"Zapdos",
"Moltres",
"Dratini",
"Dragonair",
"Dragonite",
"Mewtwo",
"Mew",
"Chikorita",
"Bayleef",
"Meganium",
"Cyndaquil",
"Quilava",
"Typhlosion",
"Totodile",
"Croconaw",
"Feraligatr",
"Sentret",
"Furret",
"Hoothoot",
"Noctowl",
"Ledyba",
"Ledian",
"Spinarak",
"Ariados",
"Crobat",
"Chinchou",
"Lanturn",
"Pichu",
"Cleffa",
"Igglybuff",
"Togepi",
"Togetic",
"Natu",
"Xatu",
"Mareep",
"Flaaffy",
"Ampharos",
"Bellossom",
"Marill",
"Azumarill",
"Sudowoodo",
"Politoed",
"Hoppip",
"Skiploom",
"Jumpluff",
"Aipom",
"Sunkern",
"Sunflora",
"Yanma",
"Wooper",
"Quagsire",
"Espeon",
"Umbreon",
"Murkrow",
"Slowking",
"Misdreavus",
"Unown",
"Wobbuffet",
"Girafarig",
"Pineco",
"Forretress",
"Dunsparce",
"Gligar",
"Steelix",
"Snubbull",
"Granbull",
"Qwilfish",
"Scizor",
"Shuckle",
"Heracross",
"Sneasel",
"Teddiursa",
"Ursaring",
"Slugma",
"Magcargo",
"Swinub",
"Piloswine",
"Corsola",
"Remoraid",
"Octillery",
"Delibird",
"Mantine",
"Skarmory",
"Houndour",
"Houndoom",
"Kingdra",
"Phanpy",
"Donphan",
"Porygon2",
"Stantler",
"Smeargle",
"Tyrogue",
"Hitmontop",
"Smoochum",
"Elekid",
"Magby",
"Miltank",
"Blissey",
"Raikou",
"Entei",
"Suicune",
"Larvitar",
"Pupitar",
"Tyranitar",
"Lugia",
"Ho-Oh",
"Celebi",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"?",
"Treecko",
"Grovyle",
"Sceptile",
"Torchic",
"Combusken",
"Blaziken",
"Mudkip",
"Marshtomp",
"Swampert",
"Poochyena",
"Mightyena",
"Zigzagoon",
"Linoone",
"Wurmple",
"Silcoon",
"Beautifly",
"Cascoon",
"Dustox",
"Lotad",
"Lombre",
"Ludicolo",
"Seedot",
"Nuzleaf",
"Shiftry",
"Nincada",
"Ninjask",
"Shedinja",
"Taillow",
"Swellow",
"Shroomish",
"Breloom",
"Spinda",
"Wingull",
"Pelipper",
"Surskit",
"Masquerain",
"Wailmer",
"Wailord",
"Skitty",
"Delcatty",
"Kecleon",
"Baltoy",
"Claydol",
"Nosepass",
"Torkoal",
"Sableye",
"Barboach",
"Whiscash",
"Luvdisc",
"Corphish",
"Crawdaunt",
"Feebas",
"Milotic",
"Carvanha",
"Sharpedo",
"Trapinch",
"Vibrava",
"Flygon",
"Makuhita",
"Hariyama",
"Electrike",
"Manectric",
"Numel",
"Camerupt",
"Spheal",
"Sealeo",
"Walrein",
"Cacnea",
"Cacturne",
"Snorunt",
"Glalie",
"Lunatone",
"Solrock",
"Azurill",
"Spoink",
"Grumpig",
"Plusle",
"Minun",
"Mawile",
"Meditite",
"Medicham",
"Swablu",
"Altaria",
"Wynaut",
"Duskull",
"Dusclops",
"Roselia",
"Slakoth",
"Vigoroth",
"Slaking",
"Gulpin",
"Swalot",
"Tropius",
"Whismur",
"Loudred",
"Exploud",
"Clamperl",
"Huntail",
"Gorebyss",
"Absol",
"Shuppet",
"Banette",
"Seviper",
"Zangoose",
"Relicanth",
"Aron",
"Lairon",
"Aggron",
"Castform",
"Volbeat",
"Illumise",
"Lileep",
"Cradily",
"Anorith",
"Armaldo",
"Ralts",
"Kirlia",
"Gardevoir",
"Bagon",
"Shelgon",
"Salamence",
"Beldum",
"Metang",
"Metagross",
"Regirock",
"Regice",
"Registeel",
"Kyogre",
"Groudon",
"Rayquaza",
"Latias",
"Latios",
"Jirachi",
"Deoxys",
"Chimecho",
"Pokémon Egg",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"Unown",
"??????????",};
        List<ushort> aa = new List<ushort>();
        private void button1_Click(object sender, EventArgs e)
        {
            var b = new Gen1.Save.SaveFile(@"A:\Desktop\Pokemon Red.sav");
            var c = b.MainBank.Party[2].EV_Attack;
            var cc = b.MainBank.Party[2].EV_Defence;
            var ccc = b.MainBank.Party[2].EV_Speed;
            var cccc = b.MainBank.Party[1].Nickname;
            //var aa = BitConverter.ToUInt16(c, 0x01);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Gen3.Data.Data.Items[aa[listBox1.SelectedIndex]].Image;
        }
        public System.Drawing.Image GetImageFromURL( string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return System.Drawing.Bitmap.FromStream(stream);
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        public string ToBase( Image value)
        {
            using (MemoryStream m = new MemoryStream())
            {
                value.Save(m, value.RawFormat);
                byte[] imageBytes = m.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

    }
}

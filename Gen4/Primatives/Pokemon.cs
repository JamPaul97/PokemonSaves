using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gen4.Save;
namespace Gen4.Primatives
{
    public enum AlternativeForm
    {
        A = 0x00,
        B = 0x08,
        C = 0x10,
        D = 0x18,
        E = 0x20,
        F = 0x28,
        G = 0x30,
        H = 0x38,
        I = 0x40,
        J = 0x48,
        K = 0x50,
        L = 0x58,
        M = 0x60,
        N = 0x68,
        O = 0x70,
        P = 0x78,
        Q = 0x80,
        R = 0x88,
        S = 0x90,
        T = 0x98,
        U = 0xA0,
        V = 0xA8,
        W = 0xB0,
        X = 0xB8,
        Y = 0xC0,
        Z = 0xC8,
        Ex = 0xD0,
        Qu = 0xD8,
    }
    public enum Marking
    {
        Circle = 0x01,
        Triangle = 0x02,
        Square = 0x04,
        Heart = 0x08,
        Start = 0x10,
        Diamond = 0x20
    }
    public class Pokemon
    {
        internal Pokemon(Data data) {
            this.data = new PKM(data);
            this.owner = new Owner(data);
            this.leaves = new Leaves(data);
            this.Storage = new StorageData(data);
            this.EV = new Effort(data);
            this.IV = new IndividualValues(data);
            this.ribbons = new Ribbons(data);
            this.moves = new Moves(data);
        }
        public PKM data;
        public Owner owner;
        public Leaves leaves;
        public StorageData Storage;
        public Effort EV;
        public IndividualValues IV;
        public Ribbons ribbons;
        public Moves moves;
        //Data
        public class Owner
        {
            private Data data;
            internal Owner(Data data)       { this.data = data; }
            public ushort OTID              { get { return this.data.Read.Ushort(0x0C); } }
            public ushort OTSID             { get { return this.data.Read.Ushort(0x0E); } }
            public string OTName            { get { return this.data.Read.String(0x48, 0xF); } }
            public uint DateMet             { get { return this.data.Read.ThreeBytes(0x7B); } }
            public byte OriginalLanguage    { get { return this.data[0x17]; } }
            public byte OriginGame          { get { return this.data[0x5F]; } }
            public ushort EggLocation       { get { return this.data.Read.Ushort(0x44); } }
            public ushort MetLocation       { get { return this.data.Read.Ushort(0x46); } }
            public byte MetAtLevel          { get { var c = this.data.Read.Byte(0x84).GetBits(); c[7] = false;return c.GetByte(); } }
            public bool OTGender { get { return this.data.Read.Byte(0x84).GetBit(7); } }
        }
        public class PKM
        {
            private Data data;
            internal PKM(Data data) { this.data = data; }
            public ushort Species           { get { return this.data.Read.Ushort(0x08); } }
            public ushort HeldItem          { get { return this.data.Read.Ushort(0x0A); } }
            public uint ExperiencePoints    { get { return this.data.Read.ThreeBytes(0x10); } }
            public byte Friendship          { get { return this.data[0x15]; } }
            public byte Ability             { get { return this.data[0x15]; } }
            public bool isEgg               { get { return this.data[0x3B].GetBit(6); } }
            public bool isNicknamed         { get { return this.data[0x3B].GetBit(7); } }
            public bool FatefulEncounter    { get { return this.data[0x40].GetBit(0); } }
            public bool Female              { get { return this.data[0x40].GetBit(1); } }
            public bool Genderless          { get { return this.data[0x40].GetBit(2); } }
            public AlternativeForm Form     { get { var c = this.data[0x40].GetBits(); c[0] = false; c[1] = false; c[2] = false; return (AlternativeForm)(c.GetByte()); } }
            public string Nickname          { get { return this.data.Read.String(0x48, 0x15); } }
            public byte Pokerus             { get { return this.data[0x82]; } }
            public byte PokeBall            { get { return this.data[0x83]; } }
        }
        public class Leaves
        {
            private Data data;
            internal Leaves(Data data) { this.data = data; }
            public bool A       { get { return this.data[0x41].GetBit(0); } }
            public bool B       { get { return this.data[0x41].GetBit(1); } }
            public bool C       { get { return this.data[0x41].GetBit(2); } }
            public bool D       { get { return this.data[0x41].GetBit(3); } }
            public bool E       { get { return this.data[0x41].GetBit(4); } }
            public bool Crown   { get { return this.data[0x41].GetBit(5); } }
        }
        public class StorageData
        {
            private Data data;
            internal StorageData(Data data) { this.data = data; }
            public Marking Markings { get{ return (Marking) this.data[0x16]; } }
        }
        public class Effort
        {
            private Data data;
            internal Effort(Data data) { this.data = data; }
            public byte HP          { get { return this.data[0x18]; } }
            public byte Attacj      { get { return this.data[0x19]; } }
            public byte Defence     { get { return this.data[0x1A]; } }
            public byte Speed       { get { return this.data[0x1B]; } }
            public byte SPAttack    { get { return this.data[0x1C]; } }
            public byte SPDefence   { get { return this.data[0x1D]; } }
        }
        public class Contest
        {
            private Data data;
            internal Contest(Data data) { this.data = data; }
            public byte Cool    { get { return this.data[0x1E]; } }
            public byte Beauty  { get { return this.data[0x1F]; } }
            public byte Cute    { get { return this.data[0x20]; } }
            public byte Smart   { get { return this.data[0x21]; } }
            public byte Tought  { get { return this.data[0x22]; } }
            public byte Sheen   { get { return this.data[0x23]; } }
        }
        public class Ribbons
        {
            private Data data;
            public SinnohRib Sinnoh;
            public HoennRib Hoenn;
            internal Ribbons(Data data) { this.data = data; this.Sinnoh = new SinnohRib(data); this.Hoenn = new HoennRib(data); }
            
            public ushort Sinnoh2;
            public ushort Sinnoh3;
            public ushort Sinnoh4;
            public ushort Hoenn1;
            public ushort Hoenn2;
            public class SinnohRib
            {
                private Data data;
                internal SinnohRib(Data data) { this.data = data; }
                public bool Sinnoh_Champ        { get { return this.data[0x24].GetBit(0); } }
                public bool Ability             { get { return this.data[0x24].GetBit(1); } }
                public bool Great_Ability       { get { return this.data[0x24].GetBit(2); } }
                public bool Double_Ability      { get { return this.data[0x24].GetBit(3); } }
                public bool Multi_Ability       { get { return this.data[0x24].GetBit(4); } }
                public bool Pair_Ability        { get { return this.data[0x24].GetBit(5); } }
                public bool World_Ability       { get { return this.data[0x24].GetBit(6); } }
                public bool Alert               { get { return this.data[0x24].GetBit(7); } }
                public bool Shock               { get { return this.data[0x25].GetBit(0); } }
                public bool Downcast            { get { return this.data[0x25].GetBit(1); } }
                public bool Careless            { get { return this.data[0x25].GetBit(2); } }
                public bool Relax               { get { return this.data[0x25].GetBit(3); } }
                public bool Snooze              { get { return this.data[0x25].GetBit(4); } }
                public bool Smile               { get { return this.data[0x25].GetBit(5); } }
                public bool Gorgeous            { get { return this.data[0x25].GetBit(6); } }
                public bool Royal               { get { return this.data[0x25].GetBit(7); } }
                public bool Gorgeous_Royal      { get { return this.data[0x26].GetBit(0); } }
                public bool Footprint           { get { return this.data[0x26].GetBit(1); } }
                public bool Record              { get { return this.data[0x26].GetBit(2); } }
                public bool History             { get { return this.data[0x26].GetBit(3); } }
                public bool Legend              { get { return this.data[0x26].GetBit(4); } }
                public bool Red                 { get { return this.data[0x26].GetBit(5); } }
                public bool Green               { get { return this.data[0x26].GetBit(6); } }
                public bool Blue                { get { return this.data[0x26].GetBit(7); } }
                public bool Festival            { get { return this.data[0x27].GetBit(0); } }
                public bool Carnival            { get { return this.data[0x27].GetBit(1); } }
                public bool Classic             { get { return this.data[0x27].GetBit(2); } }
                public bool Premier             { get { return this.data[0x27].GetBit(3); } }
                public bool Cool                { get { return this.data[0x60].GetBit(0); } }
                public bool Cool_Great          { get { return this.data[0x60].GetBit(1); } }
                public bool Cool_Ultra          { get { return this.data[0x60].GetBit(2); } }
                public bool Cool_Master         { get { return this.data[0x60].GetBit(3); } }
                public bool Beauty              { get { return this.data[0x60].GetBit(4); } }
                public bool Beauty_Great        { get { return this.data[0x60].GetBit(5); } }
                public bool Beauty_Ultra        { get { return this.data[0x60].GetBit(6); } }
                public bool Beauty_Master       { get { return this.data[0x60].GetBit(7); } }
                public bool Cute                { get { return this.data[0x61].GetBit(0); } }
                public bool Cute_Great          { get { return this.data[0x61].GetBit(1); } }
                public bool Cute_Ultra          { get { return this.data[0x61].GetBit(2); } }
                public bool Cute_Master         { get { return this.data[0x61].GetBit(3); } }
                public bool Smart               { get { return this.data[0x61].GetBit(4); } }
                public bool Smart_Great         { get { return this.data[0x61].GetBit(5); } }
                public bool Smart_Ultra         { get { return this.data[0x61].GetBit(6); } }
                public bool Smart_Master        { get { return this.data[0x61].GetBit(7); } }
                public bool Tough               { get { return this.data[0x62].GetBit(0); } }
                public bool Tough_Great         { get { return this.data[0x62].GetBit(1); } }
                public bool Tough_Ultra         { get { return this.data[0x62].GetBit(2); } }
                public bool Tough_Master        { get { return this.data[0x62].GetBit(3); } }

            }
            public class HoennRib
            {
                private Data data;
                internal HoennRib(Data data) { this.data = data; }
                public bool Cool            { get { return this.data[0x3C].GetBit(0); } }
                public bool Cool_Super      { get { return this.data[0x3C].GetBit(1); } }
                public bool Cool_Hyper      { get { return this.data[0x3C].GetBit(2); } }
                public bool Cool_Master     { get { return this.data[0x3C].GetBit(3); } }
                public bool Beauty          { get { return this.data[0x3C].GetBit(4); } }
                public bool Beauty_Super    { get { return this.data[0x3C].GetBit(5); } }
                public bool Beauty_Hyper    { get { return this.data[0x3C].GetBit(6); } }
                public bool Beauty_Master   { get { return this.data[0x3C].GetBit(7); } }
                public bool Cute            { get { return this.data[0x3D].GetBit(0); } }
                public bool Cute_Super      { get { return this.data[0x3D].GetBit(1); } }
                public bool Cute_Hyper      { get { return this.data[0x3D].GetBit(2); } }
                public bool Cute_Master     { get { return this.data[0x3D].GetBit(3); } }
                public bool Smart           { get { return this.data[0x3D].GetBit(4); } }
                public bool Smart_Super     { get { return this.data[0x3D].GetBit(5); } }
                public bool Smart_Hyper     { get { return this.data[0x3D].GetBit(6); } }
                public bool Smart_Master    { get { return this.data[0x3D].GetBit(7); } }
                public bool Tough           { get { return this.data[0x3E].GetBit(0); } }
                public bool Tough_Super     { get { return this.data[0x3E].GetBit(1); } }
                public bool Tough_Hyper     { get { return this.data[0x3E].GetBit(2); } }
                public bool Tough_Master    { get { return this.data[0x3E].GetBit(3); } }
                public bool Champion        { get { return this.data[0x3E].GetBit(4); } }
                public bool Winning         { get { return this.data[0x3E].GetBit(5); } }
                public bool Victory         { get { return this.data[0x3E].GetBit(6); } }
                public bool Artist          { get { return this.data[0x3E].GetBit(7); } }
                public bool Effort          { get { return this.data[0x3F].GetBit(0); } }
                public bool Marine          { get { return this.data[0x3F].GetBit(1); } }
                public bool Land            { get { return this.data[0x3F].GetBit(2); } }
                public bool Sky             { get { return this.data[0x3F].GetBit(3); } }
                public bool Country         { get { return this.data[0x3F].GetBit(4); } }
                public bool National        { get { return this.data[0x3F].GetBit(5); } }
                public bool Earth           { get { return this.data[0x3F].GetBit(6); } }
                public bool World           { get { return this.data[0x3F].GetBit(7); } }
            }
        }
        public class Moves
        {
            private Data data;
            internal Moves(Data data) { this.data = data; }
            public ushort Move1;
            public ushort Move2;
            public ushort Move3;
            public ushort Move4;
            public byte Move1_PP;
            public byte Move2_PP;
            public byte Move3_PP;
            public byte Move4_PP;
            public ushort MoveePPUps;
        }
        public class IndividualValues
        {
            private Data data;
            internal IndividualValues(Data data) { this.data = data; }
            public byte HP;
            public byte Attack;
            public byte Defence;
            public byte Speed;
            public byte SPAttack;
            public byte SPDefence;
        }
    }
}

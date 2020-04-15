using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class PokemonData
    {
        private int size = 48;
        private byte[] data;
        public Growth Growth;
        public Attacks Attacks;
        public EVs EVs;
        public Misc Miscelanius;
        private uint encryptionKey;
        public PokemonData(byte[] arr, uint enc,uint type)
        {
            this.data = arr;
            this.encryptionKey = enc;
            var one     = CreateSub(data.SubArray(0 * 12, 12),(int)enc);
            var two     = CreateSub(data.SubArray(1 * 12, 12), (int)enc);
            var three   = CreateSub(data.SubArray(2 * 12, 12), (int)enc);
            var four    = CreateSub(data.SubArray(3 * 12, 12), (int)enc);
            switch (type)
            {
                case 0:                                                     //GAEM
                    { this.Growth = new Growth(one, this.encryptionKey); this.Attacks = new Attacks(two, this.encryptionKey); this.EVs = new EVs(three, this.encryptionKey); this.Miscelanius = new Misc(four, this.encryptionKey); break; }
                case 1:                                                     //GAME
                    { this.Growth = new Growth(one, this.encryptionKey); this.Attacks = new Attacks(two, this.encryptionKey); this.EVs = new EVs(four, this.encryptionKey); this.Miscelanius = new Misc(three, this.encryptionKey); break; }
                case 2:                                                     //GEAM
                    { this.Growth = new Growth(one, this.encryptionKey); this.Attacks = new Attacks(three, this.encryptionKey); this.EVs = new EVs(two, this.encryptionKey); this.Miscelanius = new Misc(four, this.encryptionKey); break; }
                case 3:                                                     //GEMA
                    { this.Growth = new Growth(one, this.encryptionKey); this.Attacks = new Attacks(four, this.encryptionKey); this.EVs = new EVs(two, this.encryptionKey); this.Miscelanius = new Misc(three, this.encryptionKey); break; }
                case 4:                                                     //GMAE
                    { this.Growth = new Growth(one, this.encryptionKey); this.Attacks = new Attacks(three, this.encryptionKey); this.EVs = new EVs(four, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 5:                                                     //GMEA
                    { this.Growth = new Growth(one, this.encryptionKey); this.Attacks = new Attacks(four, this.encryptionKey); this.EVs = new EVs(three, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 6:                                                     //AGEM
                    { this.Growth = new Growth(two, this.encryptionKey); this.Attacks = new Attacks(one, this.encryptionKey); this.EVs = new EVs(three, this.encryptionKey); this.Miscelanius = new Misc(four, this.encryptionKey); break; }
                case 7:                                                    //AGME
                    { this.Growth = new Growth(two, this.encryptionKey); this.Attacks = new Attacks(one, this.encryptionKey); this.EVs = new EVs(four, this.encryptionKey); this.Miscelanius = new Misc(three, this.encryptionKey); break; }
                case 8:                                                     //AEGM
                    { this.Growth = new Growth(three, this.encryptionKey); this.Attacks = new Attacks(one, this.encryptionKey); this.EVs = new EVs(two, this.encryptionKey); this.Miscelanius = new Misc(four, this.encryptionKey); break; }
                case 9:                                                     //AEMG
                    { this.Growth = new Growth(four, this.encryptionKey); this.Attacks = new Attacks(one, this.encryptionKey); this.EVs = new EVs(two, this.encryptionKey); this.Miscelanius = new Misc(three, this.encryptionKey); break; }
                case 10:                                                     //AMGE
                    { this.Growth = new Growth(three, this.encryptionKey); this.Attacks = new Attacks(one, this.encryptionKey); this.EVs = new EVs(four, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 11:                                                     //AMEG
                    { this.Growth = new Growth(four, this.encryptionKey); this.Attacks = new Attacks(one, this.encryptionKey); this.EVs = new EVs(three, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 12:                                                     //EGAM
                    { this.Growth = new Growth(two, this.encryptionKey); this.Attacks = new Attacks(three, this.encryptionKey); this.EVs = new EVs(one, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 13:                                                     //EGMA
                    { this.Growth = new Growth(two, this.encryptionKey); this.Attacks = new Attacks(four, this.encryptionKey); this.EVs = new EVs(one, this.encryptionKey); this.Miscelanius = new Misc(three, this.encryptionKey); break; }
                case 14:                                                     //EAGM
                    { this.Growth = new Growth(three, this.encryptionKey); this.Attacks = new Attacks(two, this.encryptionKey); this.EVs = new EVs(one, this.encryptionKey); this.Miscelanius = new Misc(four, this.encryptionKey); break; }
                case 15:                                                     //EAMG
                    { this.Growth = new Growth(four, this.encryptionKey); this.Attacks = new Attacks(two, this.encryptionKey); this.EVs = new EVs(one, this.encryptionKey); this.Miscelanius = new Misc(three, this.encryptionKey); break; }
                case 16:                                                     //EMGA
                    { this.Growth = new Growth(three, this.encryptionKey); this.Attacks = new Attacks(four, this.encryptionKey); this.EVs = new EVs(one, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 17:                                                     //EMAG
                    { this.Growth = new Growth(four, this.encryptionKey); this.Attacks = new Attacks(three, this.encryptionKey); this.EVs = new EVs(one, this.encryptionKey); this.Miscelanius = new Misc(two, this.encryptionKey); break; }
                case 18:                                                     //MGAE
                    { this.Growth = new Growth(two, this.encryptionKey); this.Attacks = new Attacks(three, this.encryptionKey); this.EVs = new EVs(four, this.encryptionKey); this.Miscelanius = new Misc(one, this.encryptionKey); break; }
                case 19:                                                     //MGEA
                    { this.Growth = new Growth(two, this.encryptionKey); this.Attacks = new Attacks(four, this.encryptionKey); this.EVs = new EVs(three, this.encryptionKey); this.Miscelanius = new Misc(one, this.encryptionKey); break; }
                case 20:                                                     //MAGE
                    { this.Growth = new Growth(three, this.encryptionKey); this.Attacks = new Attacks(two, this.encryptionKey); this.EVs = new EVs(four, this.encryptionKey); this.Miscelanius = new Misc(one, this.encryptionKey); break; }
                case 21:                                                     //MAEG
                    { this.Growth = new Growth(four, this.encryptionKey); this.Attacks = new Attacks(two, this.encryptionKey); this.EVs = new EVs(three, this.encryptionKey); this.Miscelanius = new Misc(one, this.encryptionKey); break; }
                case 22:                                                    //MEGA
                    { this.Growth = new Growth(three, this.encryptionKey); this.Attacks = new Attacks(four, this.encryptionKey); this.EVs = new EVs(two, this.encryptionKey); this.Miscelanius = new Misc(one, this.encryptionKey); break; }
                case 23:                                                    //MEAG
                    { this.Growth = new Growth(four, this.encryptionKey); this.Attacks = new Attacks(three, this.encryptionKey); this.EVs = new EVs(two, this.encryptionKey); this.Miscelanius = new Misc(one, this.encryptionKey); break; }

            }
        }
        private byte[] CreateSub(byte[] data,int enc)
        {
            byte[] one = BitConverter.GetBytes(BitConverter.ToInt32(data, 0) ^ enc);
            byte[] two = BitConverter.GetBytes(BitConverter.ToInt32(data, 4) ^ enc);
            byte[] three = BitConverter.GetBytes(BitConverter.ToInt32(data, 8) ^ enc);
            List<byte> results = new List<byte>();
            foreach (var x in one)
                results.Add(x);
            foreach (var x in two)
                results.Add(x);
            foreach (var x in three)
                results.Add(x);
            return results.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class Ribbons
    {
        public byte Cool;
        public byte Beauty;
        public byte Cute;
        public byte Smart;
        public byte Tough;
        public byte Champion;
        public byte Winning;
        public byte Victory;
        public byte Artist;
        public byte Effoct;
        public byte Special1;
        public byte Special2;
        public byte Special3;
        public byte Special4;
        public byte Special5;
        public byte Special6;
        public Ribbons(int value)
        {
            this.Cool       = (byte)(value & 0b00000000000000000000000000000111);
            this.Beauty     = (byte)((value & 0b00000000000000000000000000111000) >> 3);
            this.Cute       = (byte)((value & 0b00000000000000000000000111000000) >> 6);
            this.Smart      = (byte)((value & 0b00000000000000000000111000000000) >> 9);
            this.Tough      = (byte)((value & 0b00000000000000000111000000000000) >> 12);
            this.Champion   = (byte)((value & 0b00000000000000001000000000000000) >> 13);
            this.Winning    = (byte)((value & 0b00000000000000010000000000000000) >> 14);
            this.Victory    = (byte)((value & 0b00000000000000100000000000000000) >> 15);
            this.Artist     = (byte)((value & 0b00000000000001000000000000000000) >> 16);
            this.Effoct     = (byte)((value & 0b00000000000010000000000000000000) >> 17);
            this.Special1   = (byte)((value & 0b00000000000100000000000000000000) >> 18);
            this.Special2   = (byte)((value & 0b00000000001000000000000000000000) >> 19);
            this.Special3   = (byte)((value & 0b00000000010000000000000000000000) >> 20);
            this.Special4   = (byte)((value & 0b00000000100000000000000000000000) >> 21);
            this.Special5   = (byte)((value & 0b00000001000000000000000000000000) >> 22);
            this.Special6   = (byte)((value & 0b00000010000000000000000000000000) >> 23);
        
        }
    }
}

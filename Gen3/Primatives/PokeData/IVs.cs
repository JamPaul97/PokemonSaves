using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Primatives.PokeData
{
    public class IVs
    {
        public byte HP;
        public byte Attack;
        public byte Defence;
        public byte Speed;
        public byte SPAttack;
        public byte SPDefence;
        public byte Egg;
        public byte Ability;
        public IVs(int value)
        {
            //
            this.HP         = (byte)(value & 0b00000000000000000000000000011111);
            this.Attack     = (byte)((value & 0b00000000000000000000001111100000) >> 5);
            this.Defence    = (byte)((value & 0b00000000000000000111110000000000) >> 10);
            this.Speed      = (byte)((value & 0b00000000000011111000000000000000) >> 15);
            this.SPAttack   = (byte)((value & 0b00000001111100000000000000000000) >> 20);
            this.SPDefence  = (byte)((value & 0b00111110000000000000000000000000) >> 25);
            this.Egg        = (byte)((value & 0b01000000000000000000000000000000) >> 30);
            this.Ability    = (byte)((value & 0b10000000000000000000000011110000) >> 31);
        }
    }
}

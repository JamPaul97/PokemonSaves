using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum ButtonSet
    {
        Normal =0x01,
        LR = 0x02,
        LA = 0x03
    }
    public enum TextSpeed
    {
        Slow,Medium,Fast
    }
    public enum Sound
    {
        Mono,
        Stereo
    }
    public enum BattleStyle
    {
        Switch,Set
    }
    public enum BattleScene
    {
        On,Off
    }
    public enum Game
    {
        RS,FL,E
    }
    public enum Marking
    {
        Circle,Square,Triangle,Heart    
    }
    public enum Language
    {
        Egg         = 0x0601,
        Japanese    = 0x201,
        English     = 0x202,
        French      = 0x203,
        Italian     = 0x204,
        German      = 0x205,
        Korean      = 0x206,
        Spanish     = 0x207
    }
}

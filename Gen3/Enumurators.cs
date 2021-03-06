﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3
{
    public enum Gender
    {
        Male = 0x00,
        Female = 0x01
    }
    public enum ButtonMode
    {
        Normal = 0,
        LR = 1,
        LA = 2
    }
    public enum TextSpeed
    {
        Slow = 0b00000000,
        Medium = 0b00000001,
        Fast = 0b00000010
    }
    public enum Sound
    {
        Mono = 0x0,
        Stereo = 0x1
    }
    public enum BattleStyle
    {
        Switch,Set
    }
    public enum BattleScene
    {
        On,Off
    }
    public enum Version
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
    public enum Ball
    {
        MasterBall = 1,
        UltraBall = 2,
        GreatBall = 3,
        PokeBall = 4,
        SafariBall = 5,
        NetBall = 6,
        DiveBall = 7,
        NestBall = 8,
        RepeatBall = 9,
        TimerBall = 10,
        LuxuryBall = 11,
        PremierBall = 12
    }
    public enum GameOfOrigin
    {
        ColosseumB = 0,
        Sapphire = 1,
        Ruby = 2,
        Emerald = 3,
        FireRed = 4,
        LeafGreen = 5,
        ColosseumXD = 15
    }
    public enum ContestRibbon
    {
        None = 0,
        Norma = 1,
        Super = 2,
        Hyper = 3,
        Master = 4
    }
}

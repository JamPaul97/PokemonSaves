using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen3.Saves.GameSaves.Sections
{
    public class TrainerInfo
    {
        private const int size = 4096;
        private byte[] data;
        public string PlayerName
        {
            get { return string.Empty; }//(data.SubArray(0x0, 7)).Decode(); }
            set
            {
                throw new NotImplementedException();//data.Replace(0, value.Encode());
            }
        }
        public Gender PlayerGender
        {
            get { return (Gender)data[0x0008]; }
            set { throw new NotImplementedException(); }
        }
        public uint PublicTrainerID
        {
            get { return BitConverter.ToUInt16(data.SubArray(0x000A, 2), 0); }
            set { throw new NotImplementedException(); }
        }
        public uint HidderTrainerID
        {
            get { return BitConverter.ToUInt16(data.SubArray(0x000C, 2), 0); }
            set { throw new NotImplementedException(); }
        }
        public Primatives.TimePlayed TimePlayed
        {
            get { return new Primatives.TimePlayed(data.SubArray(0x000E, 5)); }
            set { throw new NotImplementedException(); }
        }
        public ButtonSet ButtonModeSetting
        {
            get { return (ButtonSet)data[0x13]; }
            set { throw new NotImplementedException(); }
        }
        public TextSpeed TextSpeedSetting
        {
            get
            {
                byte b = data[0x014];
                b &= 0b00000111;
                return (TextSpeed)b;
            }
            set { throw new NotImplementedException(); }
        }
        public uint FrameSetting
        {
            get
            {
                byte b = data[0x014];
                b &= 0b11111000;
                b = (byte)(b >> 3);
                return b;
            }
            set { throw new NotImplementedException(); }
        }
        public Sound SoundSetting
        {
            get
            {
                byte b = data[0x015];
                b &= 0b00000001;
                return (Sound)b;
            }
            set { throw new NotImplementedException(); }
        }
        public BattleStyle BattleStyleSetting
        {
            get
            {
                byte b = data[0x015];
                b &= 0b00000010;
                b = (byte)(b >> 1);
                return (BattleStyle)b;
            }
            set { throw new NotImplementedException(); }
        }
        public BattleScene BattleSceneSetting
        {
            get
            {
                byte b = data[0x015];
                b &= 0b00000100;
                b = (byte)(b >> 2);
                return (BattleScene)b;
            }
            set { throw new NotImplementedException(); }
        }
        public Game GameCode
        {
            get
            {
                byte b = data[0x0AC];
                if (b == 0)
                    return Game.RS;
                else if (b == 1)
                    return Game.FL;
                else return Game.E;
            }
            set { throw new NotImplementedException(); }
        }
        public uint SecurityKey
        {
            get
            {
                if (this.GameCode != Game.RS)
                {
                    if (this.GameCode == Game.E)
                        return BitConverter.ToUInt32(data.SubArray(0x00AC, 4), 0);
                    return BitConverter.ToUInt32(data.SubArray(0x0AF8, 4), 0);
                }
                else return 0;
            }
        }
        public TrainerInfo(byte[] arr)
        {
            if (arr.Length != size)
                throw new Exception("Wrong format");
            this.data = arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gen3.Saves.GameSaves;
namespace Gen3.Saves
{
    public class Savee
    {
        public const int Size = 131072;
        public byte[] data;
        public GameSave GameSaveA;
        public GameSave GameSaveB;
        public HoF HallOfFame;
        public MGER MysteryGiftEReader;
        public RB RecorderBattle;
        public Savee(string filename)
        {
            byte[] arr = System.IO.File.ReadAllBytes(filename);
            if (arr.Length != Size)
                throw new Exception("Wrong Format");
            this.GameSaveA = new GameSave       (arr.SubArray(0, 57344));
            this.GameSaveB = new GameSave       (arr.SubArray(0x00E000, 57344));
            this.HallOfFame = new HoF           (arr.SubArray(0x01C000, 8192));
            this.MysteryGiftEReader = new MGER  (arr.SubArray(0x01E000, 4096));
            this.RecorderBattle = new RB        (arr.SubArray(0x01F000, 4096));
        }

        
        
        //public Primatives.Pokemon Pokemon1
        //{
            //get
            //{
                //return new Primatives.Pokemon(ref GameSaveA.Sections[1].data.SubArray(0X0238, 100));
            //}
        //}
    }
}

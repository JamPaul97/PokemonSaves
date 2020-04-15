using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gen3.Saves.GameSaves.Sections;
namespace Gen3.Saves.GameSaves
{
    public class GameSave
    {
        private const int Size = 57344;
        private byte[] data;
        private Game type;
        //14 Sections
        public TrainerInfo TrainerInfo;
        public TeamItems TeamItems;
        public GameSave(byte[] arr)
        {
            if (arr.Length != Size)
                throw new FormatException();
            this.data = arr;
            this.TrainerInfo = new TrainerInfo(arr.SubArray(0, 4096));
            this.type = this.TrainerInfo.GameCode;
            this.TeamItems = new TeamItems(arr.SubArray(4096, 4096),this.type,this.TrainerInfo.SecurityKey);

        }
    }
}

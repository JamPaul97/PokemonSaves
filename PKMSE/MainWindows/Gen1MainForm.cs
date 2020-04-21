using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gen1;
namespace PKMSE.MainWindows
{
    public partial class Gen1MainForm : Form
    {
        internal Gen1.Save.SaveFile sv;
        public Gen1MainForm()
        {
            InitializeComponent();
            this.sv = new Gen1.Save.SaveFile(@"A:\Desktop\Pokemon Red.sav");
            //foreach (var x in Gen1.Resources.Pokemon.PokemonIndex)
                //panel1.Controls.Add(new Gen1Sub.PokedexEntry(x.Value));
            LoadResources();
            LoadInfo();

        }
        private void LoadResources()
        {
            this.leader1.Image = Resources.Gen1.Badges.Res.Badges[1].Leader_Image;
            this.leader2.Image = Resources.Gen1.Badges.Res.Badges[2].Leader_Image;
            this.leader3.Image = Resources.Gen1.Badges.Res.Badges[3].Leader_Image;
            this.leader4.Image = Resources.Gen1.Badges.Res.Badges[4].Leader_Image;
            this.leader5.Image = Resources.Gen1.Badges.Res.Badges[5].Leader_Image;
            this.leader6.Image = Resources.Gen1.Badges.Res.Badges[6].Leader_Image;
            this.leader7.Image = Resources.Gen1.Badges.Res.Badges[7].Leader_Image;
            this.leader8.Image = Resources.Gen1.Badges.Res.Badges[8].Leader_Image;
            this.badge1.Image = Resources.Gen1.Badges.Res.Badges[1].Badge_Image;
            this.badge2.Image = Resources.Gen1.Badges.Res.Badges[2].Badge_Image;
            this.badge3.Image = Resources.Gen1.Badges.Res.Badges[3].Badge_Image;
            this.badge4.Image = Resources.Gen1.Badges.Res.Badges[4].Badge_Image;
            this.badge5.Image = Resources.Gen1.Badges.Res.Badges[5].Badge_Image;
            this.badge6.Image = Resources.Gen1.Badges.Res.Badges[6].Badge_Image;
            this.badge7.Image = Resources.Gen1.Badges.Res.Badges[7].Badge_Image;
            this.badge8.Image = Resources.Gen1.Badges.Res.Badges[8].Badge_Image;
        }
        private void LoadInfo()
        {
            this.txt_PublicID.Text = (sv.MainBank.PlayerID).ToString();
            this.txt_PlayerName.Text = sv.MainBank.PlayerName;
            this.txt_PlayerMoney.Text = sv.MainBank.Money.ToString();
            this.txt_Coins.Text = sv.MainBank.SlotCoins.ToString();
            this.badge1.Visible = sv.MainBank.MainData.Badges[0];
            this.badge2.Visible = sv.MainBank.MainData.Badges[1];
            this.badge3.Visible = sv.MainBank.MainData.Badges[2];
            this.badge4.Visible = sv.MainBank.MainData.Badges[3];
            this.badge5.Visible = sv.MainBank.MainData.Badges[4];
            this.badge6.Visible = sv.MainBank.MainData.Badges[5];
            this.badge7.Visible = sv.MainBank.MainData.Badges[6];
            this.badge8.Visible = sv.MainBank.MainData.Badges[7];
            this.txt_TimePlayedHours.Text = sv.MainBank.PlayTimeHours.ToString();
            this.txt_TimePlayedMinutes.Text = sv.MainBank.PlayTimeMinutes.ToString();
            this.txt_TimePlayedSeconds.Text = sv.MainBank.PlayTimeSeconds.ToString();
            this.txt_TimePlayedFrames.Text = sv.MainBank.PlayTimeFrames.ToString();
            this.txt_RivalName.Text = sv.MainBank.RivalName;
            foreach (var x in sv.MainBank.MainData.BagItems.Items)
                list_BagItems.Items.Add(Resources.Gen1.Items.Res.Items[x.ID] + " - " + x.Amount);                
            foreach (var x in sv.MainBank.MainData.PCItems.Items)
                list_PCItems.Items.Add(Resources.Gen1.Items.Res.Items[x.ID] + " - " + x.Amount);
            //pictureBox1.Image = Gen1.Resources.Pokemon.PokemonIndex[3].ImageModern.FromBase64();
                
        }
    }
}

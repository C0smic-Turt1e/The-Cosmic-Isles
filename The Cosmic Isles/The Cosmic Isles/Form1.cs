using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace The_Cosmic_Isles
{
    public partial class Form1 : Form
    {
        //title song
        SoundPlayer summerInTheCosmos = new SoundPlayer(Properties.Resources.Summer_in_the_Cosmos);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            hideEverything();
            lobby();
        } //end btn New Game Click

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } //end btn Exit

        private void Form1_Load(object sender, EventArgs e)
        {
            summerInTheCosmos.PlayLooping();
        } //end Form1 Load

        private void hideEverything()
        {
            //hides everything
            picTitle.Visible = false;
            picCosmicTitle.Visible = false;
            btnNewGame.Visible = false;
            btnSettings.Visible = false;
            btnExit.Visible = false;

            //turns off music
            summerInTheCosmos.Stop();
        } //end hideEverything method

        private void lobby()
        {
            BackgroundImage = Properties.Resources.lobby;
        } //end lobby method
    }
}

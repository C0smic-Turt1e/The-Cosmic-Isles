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
        //generates title screen list
        List<Control> titleScreen = new List<Control>();
        //generates lobby screen list
        List<Control> lobbyScreen = new List<Control>();

        //title song
        SoundPlayer summerInTheCosmos = new SoundPlayer(Properties.Resources.Summer_in_the_Cosmos);

        //dialogue character name string
        string characterName;

        public Form1()
        {
            InitializeComponent();
            
            //adds things to title screen
            titleScreen.Add(btnNewGame);
            titleScreen.Add(btnContinue);
            titleScreen.Add(btnExit);
            titleScreen.Add(picLogo);
            titleScreen.Add(picTitleCharacter);

            //adds things to lobby screen
            lobbyScreen.Add(picBotto);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //not needed code
        } //old ignore

        private void btnExit_Click(object sender, EventArgs e)
        {
            //not needed code
        } //old ignore

        private void Form1_Load(object sender, EventArgs e)
        {
            showScreen(titleScreen);
            summerInTheCosmos.PlayLooping();
        } //end Form1 Load

        private void showScreen(List<Control> newScreen)
        {
            //shows all controls in the list
            foreach (Control item in newScreen)
            {
                item.Visible = true;
            }
            backgroundDecider(newScreen);
        } //end showScreen method

        private void hideScreen(List<Control> oldScreen)
        {
            //hides all controls in the list
            foreach (Control item in oldScreen)
            {
                item.Visible = false;
            }
        } //end hidScreen method

        private void backgroundDecider(List<Control> newScreen)
        {
            //switch for what background should be used
            if (newScreen == titleScreen)
            {
                BackgroundImage = Properties.Resources.title_background;
            }
            else if (newScreen == lobbyScreen)
            {
                BackgroundImage = Properties.Resources.lobby_background;
            }
        } //end backgroundDecider method

        private void dialogueScreen (string characterName, List<Control> currentScreen)
        {
            picDialogueCharacter.Visible = true;
            lblDialogue.Visible = true;
            if (characterName == "Botto")
            {
                if (currentScreen == lobbyScreen)
                {
                    lblDialogue.Text = "He He He Ha! I am Botto!";
                }
            }
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            //shows lobby and hides title
            showScreen(lobbyScreen);
            hideScreen(titleScreen);

        } //ends btnNewGame

        private void picBotto_Click(object sender, EventArgs e)
        {
            characterName = "Botto";
            dialogueScreen(characterName, lobbyScreen);
        }
    }
}

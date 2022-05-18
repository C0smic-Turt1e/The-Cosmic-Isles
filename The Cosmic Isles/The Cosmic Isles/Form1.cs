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

        //player name input
        string playerName;

        //bools for dialogue questions
        bool option1Selected = false;
        bool option2Selected = false;

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

            if (newScreen != titleScreen)
            {
                showInventoryBorder();
                picLeftScreen.Visible = true;
                picRIghtScreen.Visible = true;
            }
            else
            {
                hideInventoryBorder();
                picLeftScreen.Visible = false;
                picRIghtScreen.Visible = false;
            }
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

        private void dialogueScreen (string characterName, List<Control> currentScreen, PictureBox picCharacter)
        {
            picDialogueCharacter.Visible = true;
            picDialogueCharacter.BringToFront();
            lblDialogue.Visible = true;
            lblDialogue.BringToFront();
            btnOption1.Visible = true;
            btnOption2.Visible = true;
            btnLeaveDialogue.Visible = true;

            hideInventoryBorder();
        }

        private void hideDialogue()
        {
            picDialogueCharacter.Visible = false;
            lblDialogue.Visible = false;
            btnOption1.Visible = false;
            btnOption2.Visible = false;
            btnLeaveDialogue.Visible = false;

            showInventoryBorder();
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
            dialogueScreen(characterName, lobbyScreen, picBotto);
            bottoDialogue();
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            option1Selected = true;
            option2Selected = false;
            if (characterName == "Botto")
            {
                bottoDialogue();
            }
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            option1Selected = false;
            option2Selected = true;
            if (characterName == "Botto")
            {
                bottoDialogue();
            }
        }

        private void btnLeaveDialogue_Click(object sender, EventArgs e)
        {
            hideDialogue();
            showInventoryBorder();
        }

        private void bottoDialogue()
        {
            if (option1Selected == true & btnOption1.Text == "OK")
            {
                lblDialogue.Text = "Enjoy your stay!";
                btnOption1.Visible = false;
                btnOption2.Visible = false;
            }

            if (btnOption1.Text == "Yes")
            {
                lblDialogue.Text = "I am Botto! I run this resort using my bot powers! Can I get your name?";
                if (option1Selected == true)
                {
                    do
                    {
                        playerName = Microsoft.VisualBasic.Interaction.InputBox("Input Name!", "Botto wants your name!");
                    }
                    while (Name.Trim() == "");

                    lblPlayerName.Text = playerName;

                    lblDialogue.Text = "Welcome to The Cosmic Isles, " + playerName.ToUpper() + "! If you go up to the stairs to the right, you will find your room! There is a complementary outfit waiting for you!";
                    btnOption1.Text = "OK";
                    btnOption2.Visible = false;
                }
                else if (option2Selected == true)
                {
                    lblDialogue.Text = "You silly goose, I need your name! Otherwise you can't stay at the resort!";
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (grpTest.Visible == false)
            {
                grpTest.Visible = true;
                grpTest.BringToFront();
            }
            else
            {
                grpTest.Visible = false;
            }
        }

        private void btnTestMenu_Click(object sender, EventArgs e)
        {
            hideAll();
            showScreen(titleScreen);
        }

        private void btnTestLobby_Click(object sender, EventArgs e)
        {
            hideAll();
            showScreen(lobbyScreen);
        }

        private void hideAll()
        {
            hideScreen(titleScreen);
            hideScreen(lobbyScreen);
        }

        private void showInventoryBorder()
        {
            picInventoryBorder.Visible = true;
            picInventoryBorder.BringToFront();
            picPlayer.Visible = true;
            picPlayer.BringToFront();
            lblPlayerName.Visible = true;
            lblPlayerName.BringToFront();
            btnSaveTitle.Visible = true;
            btnSaveTitle.BringToFront();
            btnSaveExit.Visible = true;
            btnSaveExit.BringToFront();

            btnTest.BringToFront();
        }

        private void hideInventoryBorder()
        {
            picInventoryBorder.Visible = false;
            picPlayer.Visible = false;
            lblPlayerName.Visible = false;
            btnSaveTitle.Visible = false;
            btnSaveExit.Visible = false;
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveTitle_Click(object sender, EventArgs e)
        {
            hideAll();
        }
    }
}

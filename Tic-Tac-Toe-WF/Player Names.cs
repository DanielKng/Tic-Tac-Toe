using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tic_Tac_Toe_WF
{
    public partial class Playernames : Form
    {
        public static string player1Name = "";
        public static string player2Name = "";
        Game loadGame = new Game();
        public Playernames()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //First we need to get the names

            player1Name = Player1.Text;
            player2Name = Player2.Text;

            //Use Uppercase only! ~ Deleted, because it looks ugly

            //player1Name = player1Name.ToUpper();
            //player2Name = player2Name.ToUpper();



            //Check if the Boxes contain any letters, if they contain anything else than letters or nothing - Error
            //true if it doesn't contain letters
            //Bugfix for https://github.com/DanielKng/Tic-Tac-Toe/issues/6 and https://github.com/DanielKng/Tic-Tac-Toe/issues/5

            bool result = player1Name.Any(x => !char.IsLetter(x)) && player2Name.Any(x => !char.IsLetter(x)) || player1Name.Any(x => !char.IsLetter(x)) || player2Name.Any(x => !char.IsLetter(x));
            //IF the result is true, one or both of the Textboxes does contain special characters or a space without letters

            //even if you put in a name in "Player 2 Textbox" it will get deleted here if you enabled the AI
            if (player1Name == "")
            {
                result = true;
            }
            if (result)
            {
                Player1.Text = "Error! Please use a valid name!";

                if (loadGame.ai_enable)
                {
                    Player2.Text = "Error! Please use a valid name!";
                }
            }

            //Bugfix for https://github.com/DanielKng/Tic-Tac-Toe/issues/6 and https://github.com/DanielKng/Tic-Tac-Toe/issues/5
            //If the String is empty

            else if (string.IsNullOrEmpty(player1Name) || string.IsNullOrEmpty(player2Name) || string.IsNullOrEmpty(player1Name) && string.IsNullOrEmpty(player2Name))
            {
                if (ai_activate.Checked)                    //if you enabled the AI "Player 2 Name" will changed to "Computer"
                {
                    loadGame.ai_enable = true;
                    Playernames.player2Name = "Computer";
                    Hide();
                    loadGame.StartPosition = FormStartPosition.CenterScreen;
                    loadGame.Show();
                }
                else                                        //... otherwise you'll get a Error Message, because you didn't filled all "Name Textboxes"
                {
                    Player1.Text = "Error! The name cant be empty!";
                    Player2.Text = "Error! The name cant be empty!";
                }
            }
            else
            {
                //Load the Game
                //This is important. With this piece of code the Window gets centered and is at the same place as all other Windows!               
                loadGame.StartPosition = FormStartPosition.CenterScreen;
                loadGame.Show();
                this.Hide();
            }


        }

        private void ai_activate_CheckedChanged(object sender, EventArgs e)     //if you click the Checkbox "ai_enable" you'll jump in here
        {
            if (ai_activate.Checked)        //if you actiate the Checkbox, you diable the "Player 2 Textbox"
            {
                Player2.Enabled = false;
                Player2.Text = "";
            }
            else                            //if you deactivate the Checkbox, you enable the "Player 2 Textbox"
            {
                Player2.Enabled = true;
            }
        }
    }
}

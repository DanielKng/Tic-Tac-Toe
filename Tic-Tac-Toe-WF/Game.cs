using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_WF
{
    public partial class Game : Form
    {
        //If true = X if false = O
        bool player = true;
        String gameWon;
        int playerSteps = 0;
        public Game()
        {
            InitializeComponent();
            //Shows the name of the starting player
            PlayerTurnValue = "It's your turn, " + Playernames.player1Name;
        }
        private void Game_Load(object sender, EventArgs e)
        {
        }
        public string PlayerTurnValue
        {
            get { return player_turn.Text; }
            set { player_turn.Text = value; }
        }
        private void button_click(object sender, EventArgs e)
        {
            if (Playernames.player1Name != "X" && Playernames.player2Name != "O")
            {
                //Sends a Cast to buttons
                Button buttonsFirst = (Button)sender;
                if (player)
                {
                    //First, we need to delete everything except the first letter
                    string firstLetterP1 = Playernames.player1Name.Substring(0, 1);
                    //Set the first letter to the Button
                    buttonsFirst.Text = firstLetterP1;
                    //Which turn is it?
                    PlayerTurnValue = "It's your turn, " + Playernames.player2Name;

                }
                else
                {
                    //First, we need to delete everything except the first letter
                    string firstLetterP2 = Playernames.player2Name.Substring(0, 1);
                    //Set the first letter to the Button
                    buttonsFirst.Text = firstLetterP2;
                    //Which turn?
                    PlayerTurnValue = "It's your turn, " + Playernames.player1Name;
                }

            }
            //Sends a Cast to buttons
            Button buttons = (Button)sender;
            if (Playernames.player1Name == "X" && Playernames.player2Name == "O")
            {
                //Checks which bool is set, and sets the Button Text
                if (player)
                {
                    //True = Player X!
                    buttons.Text = "X";
                    PlayerTurnValue = "It's your turn, " + Playernames.player2Name;
                }
                else
                {
                    //False! Player O!
                    buttons.Text = "O";
                    PlayerTurnValue = "It's your turn, " + Playernames.player1Name;
                }
            }
            //The bool has to change, otherwise its Player X always
            player = !player;
            //Buttons cant clicked twice!
            buttons.Enabled = false;
            //Increase the Playersteps
            playerSteps++;
            //Check for the Winner after every Step!
            CheckWinner();
        }
        //As the Worksheet says: Check every possible end. Vertical, Horizontal, etc
        private void CheckWinner()
        {
            //There cant be a winner at the beginning
            bool winner = false;

            //If there are three of the same Symbols in the first row, win!
            //Horizontal Checks
            //Bug: After clicking one field, the player wins. Fix: Check if field is enabled
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                winner = true;
            }

            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }

            //Vertical Checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }

            //Diagonal Checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            //Check for winners
            if (winner)
            {
                //Player True, O won
                if (player)
                {
                    //Shows the winner Animation and changes the Text to the Winning player
                    Winscreen loadWinscreen = new Winscreen();
                    //Changes the "Value" and therefore the content in the Textbox from Winscreen.cs
                    loadWinscreen.TextBoxValue = Playernames.player2Name + " wins! Congratulations!";
                    loadWinscreen.Show();
                    //Github Issue #3 https://github.com/DanielKng/Tic-Tac-Toe/issues/3
                    DisableWinButton();
                }
                //Is it false, Player O won
                else
                {
                    //Shows the winner Animation and changes the Text to the Winning player
                    Winscreen loadWinscreen = new Winscreen();
                    //Changes the "Value" and therefore the content in the Textbox from Winscreen.cs
                    loadWinscreen.TextBoxValue = Playernames.player1Name + " wins! Congratulations!";
                    loadWinscreen.Show();
                    //Github Issue #3 https://github.com/DanielKng/Tic-Tac-Toe/issues/3
                    DisableWinButton();
                }
            }
            else
            {
                if (playerSteps == 9)
                {
                    MessageBox.Show("Draw. No one wins!", "Standoff", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //Github Issue #3 https://github.com/DanielKng/Tic-Tac-Toe/issues/3
                    DisableWinButton();
                }
            }
        }

        //Bugfix Version 0.0.3-A
        //After you won and clicked Okay, you can still click the Buttons. This is the bugfix

        private void DisableWinButton()
        {
            //We have to use a try, because we got an exception on (Button)c;

            foreach (Control c in Controls) 
            {
                try
                {
                    //Github Issue #3 https://github.com/DanielKng/Tic-Tac-Toe/issues/3
                    //The try & catch loop was outside of "foreeach" which leads to a unproper functionality
                    //Send the Cast
                    Button buttons = (Button)c;
                    //Disable all Buttons
                    buttons.Enabled = false;
                    //User should be able to click those
                    Exit_Game.Enabled = true;
                    New_Game.Enabled = true;
                }
                catch { }
            }
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            if (change_names.Checked)
            {
                //Shows the "Choose Playername" Window 
                Playernames loadPlayernames = new Playernames();
                loadPlayernames.Show();
                this.Close();
            }
            else
            {
                //Closes the window
                this.Close();
                //Opens up the new Game
                Game newGame = new Game();
                newGame.Show();
            }
            //Github Issue #4 https://github.com/DanielKng/Tic-Tac-Toe/issues/4 Bugfix
            Winscreen winscreenClose = new Winscreen();
            winscreenClose.CloseWinscreen();
        }
        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


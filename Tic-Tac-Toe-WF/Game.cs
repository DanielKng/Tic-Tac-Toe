using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_WF
{
    public partial class Game : Form
    {
        //If true = X if false = O
        public bool player = true;
        public int playerSteps = 0;
        
        public int player1Stats = 0;
        public int player2Stats = 0;
        //Loading needed Stuff
        Form1 loadMain = new Form1();
        Options loadOptions = new Options();
        //Now it gets interesting! Adding the AI!
        public bool ai_enable = false;
        public Game()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            //Set the Playername
            player1_label.Text = "Player " + Playernames.player1Name;
            player2_label.Text = "Player " + Playernames.player2Name;
            if (Playernames.player2Name == "Computer")
            {
                player2_label.Text = "1337 Cheater";
                //Bugfix for https://github.com/DanielKng/Tic-Tac-Toe/issues/9
                PlayerTurnValue = "It's your turn, " + Playernames.player1Name;
            }
            else if (player)
            {
                //Bugfix for https://github.com/DanielKng/Tic-Tac-Toe/issues/9
                PlayerTurnValue = "It's your turn, " + Playernames.player1Name;
            }
            //Shows how often Player XY won
            player1_stats_counter.Text = "won " + Properties.Settings.Default.player_1_stats + " time(s)";
            player2_stats_counter.Text = "won " + Properties.Settings.Default.player_2_stats + " time(s)";
        }
        public string PlayerTurnValue
        {
            get { return player_turn.Text; }
            set { player_turn.Text = value; }
        }
        //AI Logic
        private void ai_move()
        {
            //priority 1:  get tic tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = win_or_block("O"); //look for win
            if (move == null)
            {
                move = win_or_block("X"); //look for block
                if (move == null)
                {
                    move = open_corner();
                    if (move == null)
                    {
                        move = free_field();
                    }
                }
            }

            move.PerformClick();
        }

        private Button free_field()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button open_corner()
        {
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button win_or_block(string mark)
        {
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;
            //This should never be reached, but its neccesary!
            else
            {
                return null;
            }
        }//AI Logic END
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
                    buttonsFirst.BackColor = Properties.Settings.Default.color_playerX;
                    buttonsFirst.Text = firstLetterP1;
                    //Which turn is it?
                    PlayerTurnValue = "It's your turn, " + Playernames.player2Name;

                }
                else
                {
                    //First, we need to delete everything except the first letter
                    string firstLetterP2 = Playernames.player2Name.Substring(0, 1);
                    //Set the first letter to the Button
                    buttonsFirst.BackColor = Properties.Settings.Default.color_playerO;
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
                    buttons.BackColor = Properties.Settings.Default.color_playerX;                    
                    buttons.Text = "X";
                    PlayerTurnValue = "It's your turn, " + Playernames.player2Name;
                }
                //This is the AI stat
                else if (Playernames.player1Name == "X" && Playernames.player2Name == "AI")
                {
                    buttons.BackColor = Properties.Settings.Default.color_playerO;
                    buttons.Text = "A";
                    PlayerTurnValue = "It's your turn, " + Playernames.player1Name;
                }
                else
                {
                    //False! Player O!
                    buttons.BackColor = Properties.Settings.Default.color_playerO; 
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
            if ((!player) && ai_enable)
            {
                ai_move();
            }
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
                    
                    //We need to increase the Stats first
                    Properties.Settings.Default.player_2_stats = Properties.Settings.Default.player_2_stats + 1;
                    //Shows how often Player XY won
                    player2_stats_counter.Text = "won " + Properties.Settings.Default.player_2_stats + " time(s)";

                    //Shows the winner Animation and changes the Text to the Winning player
                    //Changes the "Value" and therefore the content in the Textbox from Winscreen.cs
                    //INPORTANT TO CLOSE THE WINDOW TROUGH THE NEW GAME BUTTON!
                    Winscreen loadWinscreen = new Winscreen(this);
                    loadWinscreen.TextBoxValue = Playernames.player2Name + " wins! Congratulations!";
                    loadWinscreen.StartPosition = FormStartPosition.CenterScreen;
                    //Playing the Sound
                    if (Properties.Settings.Default.enable_sounds)
                    {
                        SoundPlayer snd = new SoundPlayer(loadOptions.fileName_win);
                        snd.Play();
                    }
                    loadWinscreen.ShowDialog();
                    //Github Issue #3 https://github.com/DanielKng/Tic-Tac-Toe/issues/3
                    DisableWinButton();
                }
                //Is it false, Player X won
                else
                {
                    //Increasing the Stats here also
                    Properties.Settings.Default.player_1_stats++;
                    //Shows how often Player XY won
                    player1_stats_counter.Text = "won " + Properties.Settings.Default.player_1_stats + " time(s)";
                    //Shows the winner Animation and changes the Text to the Winning player
                    //INPORTANT TO CLOSE THE WINDOW TROUGH THE NEW GAME BUTTON!
                    Winscreen loadWinscreen = new Winscreen(this);
                    //Changes the "Value" and therefore the content in the Textbox from Winscreen.cs
                    loadWinscreen.TextBoxValue = Playernames.player1Name + " wins! Congratulations!";
                    loadWinscreen.StartPosition = FormStartPosition.CenterScreen;
                    //Play Sound
                    if (Properties.Settings.Default.enable_sounds)
                    {
                        SoundPlayer snd = new SoundPlayer(loadOptions.fileName_win);
                        snd.Play();
                    }
                    loadWinscreen.ShowDialog();
                    //Github Issue #3 https://github.com/DanielKng/Tic-Tac-Toe/issues/3
                    DisableWinButton();
                }
            }
            else
            {
                if (playerSteps == 9)
                {
                    //Shows the winner Animation and changes the Text to the Winning player
                    GameOver_Screen loadGameOver = new GameOver_Screen();
                    //Center Screen
                    loadGameOver.StartPosition = FormStartPosition.CenterScreen;
                    if (Properties.Settings.Default.enable_sounds)
                    {
                        SoundPlayer snd = new SoundPlayer(loadOptions.fileName_lose);
                        snd.Play();
                    }
                    loadGameOver.Show();
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
        //If you click on "New Game"
        private void New_Game_Click(object sender, EventArgs e)
        {
            //And have checked the Playname Checkbox
            if (change_names.Checked && stat_reset_checkbox.Checked)
            {
                //Reset the Stats!
                Properties.Settings.Default.player_1_stats = 0;
                Properties.Settings.Default.player_2_stats = 0;
                //Show the new Stats
                player1_stats_counter.Text = Properties.Settings.Default.player_1_stats.ToString();
                player2_stats_counter.Text = Properties.Settings.Default.player_2_stats.ToString();
                //Open up the UI 
                Playernames loadPlayernames = new Playernames();
                //Center
                loadPlayernames.StartPosition = FormStartPosition.CenterScreen;
                loadPlayernames.Show();
                this.Hide();
            }
            else if (change_names.Checked)
            {
                //Open up the UI 
                Playernames loadPlayernames = new Playernames();
                //Center
                loadPlayernames.StartPosition = FormStartPosition.CenterScreen;
                loadPlayernames.ShowDialog();
                this.Hide();
            }
            else if (stat_reset_checkbox.Checked)
            {
                //Reset the Stats!
                Properties.Settings.Default.player_1_stats = 0;
                Properties.Settings.Default.player_2_stats = 0;
                //Shows how often Player XY won
                player1_stats_counter.Text = "won " + Properties.Settings.Default.player_1_stats + " time(s)";
                player2_stats_counter.Text = "won " + Properties.Settings.Default.player_2_stats + " time(s)";
                //Reset which Player is next
                player = true;
                //Reset how many clicks are done
                playerSteps = 0;
                //I cant explain this, but it works.
                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        //Re-Enable all Buttons
                        b.Enabled = true;
                        //Reset the Text
                        b.Text = "";
                        //Because the Text on the other Buttons gets reset too, we have to rewrite them!
                        New_Game.Text = "New Game";
                        Exit_Game.Text = "Back";
                    }
                    catch { }
                }
            }
            //Else, you did not checked the Box, normal "New-Game"
            else
            {
                //Reset which Player is next
                player = true;
                //Reset how many clicks are done
                playerSteps = 0;
                //I cant explain this, but it works.
                foreach (Control c in Controls)
                {
                    try
                    {
                        //Reset all the Backgroundcolors, otherwise they wont disappear
                        A1.BackColor = DefaultBackColor;
                        A2.BackColor = DefaultBackColor;
                        A3.BackColor = DefaultBackColor;

                        B1.BackColor = DefaultBackColor;
                        B2.BackColor = DefaultBackColor;
                        B3.BackColor = DefaultBackColor;

                        C1.BackColor = DefaultBackColor;
                        C2.BackColor = DefaultBackColor;
                        C3.BackColor = DefaultBackColor;
                        
                        //Shows how often Player XY won
                        player1_stats_counter.Text = "won " + Properties.Settings.Default.player_1_stats + " time(s)";
                        player2_stats_counter.Text = "won " + Properties.Settings.Default.player_2_stats + " time(s)";
                        Button b = (Button)c;
                        //Re-Enable all Buttons
                        b.Enabled = true;
                        //Reset the Text
                        b.Text = "";
                        //Because the Text on the other Buttons gets reset too, we have to rewrite them!
                        New_Game.Text = "New Game";
                        Exit_Game.Text = "Back";
                    }
                    catch { }
                }
            }
        }
        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Close();
            loadMain.Show();
        }
    }
}


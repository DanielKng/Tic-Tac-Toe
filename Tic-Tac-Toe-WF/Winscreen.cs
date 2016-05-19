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
    public partial class Winscreen : Form
    {
        // Variable to catch the old playfield
        Game oldPlayfield;
        // the old playfield is passed in the constructor
        public Winscreen(Game opf)
        {
            this.oldPlayfield = opf;
            InitializeComponent();
        }
        //Since we want to show the winning Player in our Textbox, we need to set the winner with "value" from Game.cs
        public string TextBoxValue
        {            
            get { return winscreenTextbox.Text; }
            set { winscreenTextbox.Text = value; }
        }
       
        private void winscreen_again_Click(object sender, EventArgs e)
        {
            //Load Classes
            Playernames loadPlayernames = new Playernames();
            Game loadGame = new Game();
            //Center
            loadPlayernames.StartPosition = FormStartPosition.CenterScreen;
            loadGame.StartPosition = FormStartPosition.CenterScreen;
            //And have checked the Playname Checkbox
            if (changename_winscreen.Checked && reset_stats_winscreen.Checked)
            {
                this.Close();
                //Reset the Stats!
                loadGame.player1Stats = 0;
                loadGame.player2Stats = 0;
                //Show the new Stats
                loadGame.player1_stats_counter.Text = loadGame.player1Stats.ToString();
                loadGame.player2_stats_counter.Text = loadGame.player2Stats.ToString();

                //Closes the old Playfield. Thanks to http://stackoverflow.com/users/5174469/mong-zhu for answering my Question! http://stackoverflow.com/questions/37243401/close-form2-from-form3-that-has-been-opened-in-form1

                this.oldPlayfield.Close();
                //Open up the UI 
                loadPlayernames.ShowDialog();
            }
            else if (changename_winscreen.Checked)
            {
                //Open up the UI 
                loadPlayernames.ShowDialog();
                this.Hide();
            }
            else if (reset_stats_winscreen.Checked)
            {
                
                //Reset the Stats!
                Properties.Settings.Default.player_1_stats = 0;
                Properties.Settings.Default.player_2_stats = 0;
                //Shows how often Player XY won
                loadGame.player1_stats_counter.Text = "won " + Properties.Settings.Default.player_1_stats.ToString() + " time(s)";
                loadGame.player2_stats_counter.Text = "won " + Properties.Settings.Default.player_2_stats.ToString() + " time(s)";
                //Reset which Player is next
                loadGame.player = true;
                //Reset how many clicks are done
                loadGame.playerSteps = 0;
                //Closes the old Playfield. Thanks to http://stackoverflow.com/users/5174469/mong-zhu for answering my Question! http://stackoverflow.com/questions/37243401/close-form2-from-form3-that-has-been-opened-in-form1
                this.oldPlayfield.Close();
                //Close the current form
                Close();
                //I cant explain this, but it works.
                loadGame.Show();
            }
            //Else, you did not checked the Box, normal "New-Game"
            else 
            {

                Properties.Settings.Default.player_2_stats = loadGame.player2Stats + Properties.Settings.Default.player_2_stats;
                              
                //Reset which Player is next
                loadGame.player = true;
                //Reset how many clicks are done
                loadGame.playerSteps = 0;
                //I cant explain this, but it works.                
                loadGame.Show();
                //Close the old Field
                this.oldPlayfield.Close();
                //Close the current Window

                
                Close();
            }
        }

        private void winscreen_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (enable_playernames.Checked == true)
            {
                //Load custom names
                Playernames loadPlayernames = new Playernames();
                //This is important. With this piece of code the Window gets centered               
                loadPlayernames.StartPosition = FormStartPosition.CenterScreen;
                loadPlayernames.Show();
                this.Hide();
            }
            else
            {
                //Load default names
                Playernames.player1Name = "X";
                Playernames.player2Name = "O";
                Game loadGame = new Game();
                //This is important. With this piece of code the Window gets centered               
                loadGame.StartPosition = FormStartPosition.CenterScreen;
                loadGame.Show();
                Hide();
            }
        }
        //If the user clicked on the Credits-Button, hide the Menu and open the credit form
        private void Credits_Click(object sender, EventArgs e)
        { 
            //Load every IInformation from Credits into openCredits
            Credits openCredits = new Credits();
            //This is important. With this piece of code the Window gets centered               
            openCredits.StartPosition = FormStartPosition.CenterScreen;
            openCredits.Show();
            //Hide Mainform
            this.Hide();
        }
        //If clicked on Exit, Shutdown the Application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changelog_Click(object sender, EventArgs e)
        {
            //Load the PDF a bit before the UI gets called
            Changelog loadChangelog = new Changelog();
            loadChangelog.changelog_browser.Navigate("http://puu.sh/oSCFr/7e47c74977.png");
            //We don't need to center this, we did it already in the Window prefs!
            //Call the UI
            loadChangelog.Show();

        }
    }
}

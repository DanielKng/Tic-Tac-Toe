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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //If the user clicked on the Credits-Button, hide the Menu and open the credit form
        private void Credits_Click(object sender, EventArgs e)
        {
            //Open
            Credits openCredits = new Credits();
            openCredits.Show();
            //Hide Mainform
            this.Hide();
        }
        //If clicked on Exit, Shutdown the Application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //If clicked on Start, open the Game!
        private void Start_Click(object sender, EventArgs e)
        {
            if(enable_playernames.Checked == true)
            {
                //Load custom names
                Playernames loadPlayernames = new Playernames();
                loadPlayernames.Show();
                this.Hide();
            }
            else
            {
                //Load default names
                Game openGame = new Game();
                openGame.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Changelog loadChangelog = new Changelog();
            loadChangelog.Show();
        }
    }
}

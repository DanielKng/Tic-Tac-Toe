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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }
        //Checks if "Beenden" is pressed
        private void Exit_Click(object sender, EventArgs e)
        {
            //Exit the Application
            Application.Exit();
        }
        //If the User clicked on back, open up the MainMenu
        private void Back_Click(object sender, EventArgs e)
        {
            //Open
            Form1 openMainMenu = new Form1();
            openMainMenu.Show();
            //Close Creditform
            this.Hide();
        }
    }
}

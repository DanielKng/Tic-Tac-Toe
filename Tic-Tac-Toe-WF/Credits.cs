using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe_WF
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        //Checks if "Exit" is pressed
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
            //We dont need to center this! We did it already in the Window-Prefs!
            openMainMenu.Show();
            //Close Creditform
            this.Hide();
        }
    }
}
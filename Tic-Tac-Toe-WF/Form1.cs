using System;
using System.IO;
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
            //Load Classes
            Game loadGame = new Game();
            Playernames loadPlayernames = new Playernames();

            //Center Windows
            loadGame.StartPosition = FormStartPosition.CenterScreen;
            loadPlayernames.StartPosition = FormStartPosition.CenterScreen;

            if (enable_playernames.Checked == true)
            {
                loadPlayernames.Show();
                Hide();
            }
            else
            {
                //Load default names
                Playernames.player1Name = "X";
                Playernames.player2Name = "O";
                Hide();
                loadGame.Show();
            }
        }

        //If the user clicked on the Credits-Button, hide the Menu and open the credit form
        private void Credits_Click(object sender, EventArgs e)
        {
            //Load Class
            Credits openCredits = new Credits();
            //Center Window
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
            Changelog loadChangelog = new Changelog();
            //We now load the Changelog trough a file! Thanks to Patrick for the Idea!
            loadChangelog.changelog_box.Text = Properties.Resources.changelog;
            //Call the UI
            loadChangelog.Show();
        }

        private void options_Click(object sender, EventArgs e)
        {
            //TODO: Put into method
            //First Create the Directory. It will NOT be created if its there already!
            Directory.CreateDirectory(@"C:\Ultimate Tic-Tac-Toe\Audios");
            //Check the Directory for files
            string[] dFiles = Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios");
            //Convert the Content into a String
            string fCount = dFiles.Length.ToString();
            //If we have have 4 files, we dont need to Open the Download Window
            if (fCount != "4")
            {
                //True means you really want to get into the Options, otherwise the "You need to Download" PopUp shows every time
                Properties.Settings.Default.options_clicked = true;
                Options loadOptions = new Options();
                loadOptions.ShowDialog();
            }
            else
            {
                //True means you really want to get into the Options, otherwise the "You need to Download" PopUp shows every time
                Properties.Settings.Default.options_clicked = false;
                Options loadOptions = new Options();
                loadOptions.Positions();
                loadOptions.ShowDialog();
            }
        }

        private void bugs_button_Click(object sender, EventArgs e)
        {
            Bugs loadBugs = new Bugs();
            //We now load the Changelog trough a file! Thanks to Patrick for the Idea!
            loadBugs.bugs_text.Text = Properties.Resources.bugs;
            //Call the UI
            loadBugs.Show();
        }
    }
}
using System;
//Imported Library!
using NAudio;
using NAudio.Wave;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Drawing;
using System.Security.Permissions;

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
                if (ai_enabled.Text == "ai_enable")
                {
                    loadGame.ai_enable = true;
                    Playernames.player1Name = "X";
                    Playernames.player2Name = "AI";
                    loadGame.Show();
                    Hide();
                }
                //Load default names
                Playernames.player1Name = "X";
                Playernames.player2Name = "O";
                loadGame.Show();
                Hide();
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
            string[] dFiles = Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios");
            string fCount = dFiles.Length.ToString();

            //If we have have 4 files, we dont need to Open the Download Window
            if (fCount != "4")
            {
                //True means you really want to get into the Options, otherwise the "You need to Download" PopUp shows every time
                Properties.Settings.Default.options_clicked = true;
                Options loadOptions = new Options();
                Directory.CreateDirectory(@"C:\Ultimate Tic-Tac-Toe\Audios");
                loadOptions.ShowDialog();
            }
            else
            {
                //True means you really want to get into the Options, otherwise the "You need to Download" PopUp shows every time
                Properties.Settings.Default.options_clicked = false;
                Options loadOptions = new Options();
                Directory.CreateDirectory(@"C:\Ultimate Tic-Tac-Toe\Audios");
                loadOptions.Positions();
                loadOptions.ShowDialog();
            }
        }
    }
}

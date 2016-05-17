using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_WF
{
    public partial class Options : Form
    {

        //Where to get the files?
        string remoteUri_dark = "https://www.dropbox.com/s/eww4jlt6z64j15h/dark_mode_music.wav?dl=1";
        string remoteUri_standard = "https://www.dropbox.com/s/9qjfih3ppksqmer/standard_mode_enabled.wav?dl=1";
        string remoteUri_win = "https://www.dropbox.com/s/87727v027oiny08/win_sound.wav?dl=1";
        string remoteUri_lose = "https://www.dropbox.com/s/la7nx6f6471b16k/lose_sound.wav?dl=1";
        //Where to save?
        public string fileName_dark = @"C:\Ultimate Tic-Tac-Toe\Audios\dark_mode_music.wav";
        public string fileName_standard = @"C:\Ultimate Tic-Tac-Toe\Audios\standard_mode_music.wav";
        public string fileName_win = @"C:\Ultimate Tic-Tac-Toe\Audios\win_sound.wav";
        public string fileName_lose = @"C:\Ultimate Tic-Tac-Toe\Audios\lose_sound.wav";
        public string path = @"C:\Ultimate Tic-Tac-Toe\Audios\";
        //Standard variable for the Message Box
        bool download_no = true;
        Form1 loadMain = new Form1();
        public Options()
        {
            string[] dFiles = Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios");
            string fCount = dFiles.Length.ToString();
            InitializeComponent();
            //THis only happens if you clicked on the Option Button!
            if(fCount != "4" && Properties.Settings.Default.options_clicked)
            {
                CheckForFiles();
            }
        }

        public async Task DownloadFiles()
        {
            //Make Visible what we need to give the User in case of Downloading things (otherwise hide it)
            download_info.Visible = true;
            //Download all
            WebClient webClient = new WebClient();
            download_info.Text = "File 1/4 loading...\r\n\r\n" + remoteUri_dark;
            await webClient.DownloadFileTaskAsync(new Uri(remoteUri_dark), fileName_dark);
            // if here, you know the first download is finished
            download_info.Text = "File 2/4 loading...\r\n\r\n" + remoteUri_standard;
            await webClient.DownloadFileTaskAsync(new Uri(remoteUri_standard), fileName_standard);
            // if here: 2nd file downloaded
            download_info.Text = "File 3/4 loading...\r\n\r\n"+remoteUri_win;
            await webClient.DownloadFileTaskAsync(new Uri(remoteUri_win), fileName_win);
            download_info.Text = "File 4/4 loading...\r\n\r\n"+remoteUri_lose;
            await webClient.DownloadFileTaskAsync(new Uri(remoteUri_lose), fileName_lose);
            //Change our Label Color to green - Success
            download_info.ForeColor = Color.Green;
            download_info.Text = "Download complete!";
            //Hide the Content we only need if we Download Stuff
            download_info.Visible = false;
        }

        public void CheckForFiles()
        {
            string[] dFiles = Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios");
            string fCount = dFiles.Length.ToString();
            //If there are NOT all of the Audiofiles, delete all of them and re-download!
            if (fCount != "4")
            {
                if (MessageBox.Show("Attention! In order to use the Audio features, a one time download is needed! Proceed?", "Files missing!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                 
                    //We clicked yes, change the Variable
                    download_no = false;
                    //Just to be sure, delete all previous files!
                    Array.ForEach(Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios"), File.Delete);
                    //Set the Warning Text
                    warning_text.Text = "Attention! Downloading files! DO NOT interrupt the process!";
                    //SHow the Download-Progress Bar
                    //Download all
                    DownloadFiles();
                }
                else if (download_no)
                {
                    //If the Button says "Apply!" the user has not downloaded our Content, but tried to Activate it!
                    apply_options.Text = "Apply!";
                    //This is more of a Psycho thing. If the User sees what he could do, he wants it. So lets make the Buttuns visible, but only show text
                    enable_music.ForeColor = Color.Gray;
                    enable_sound.ForeColor = Color.Gray;
                    enable_darkmode.ForeColor = Color.Gray;
                    Positions();
                    //Otherwise the PopUp shows every time you play a game
                    Properties.Settings.Default.options_clicked = false;
                }
            }
            //The files exists if the Setting is set and we have 3 files, or if just 3 files are there
            else if (fCount == "4")
            {
                Positions();

            }
        }
        private void CheckboxesDisabel()
        {
            Checkboxes_Disabled loadCheckboxEasteregg = new Checkboxes_Disabled();
            loadCheckboxEasteregg.ShowDialog();
        }
        private void apply_options_Click(object sender, EventArgs e)
        {
            //Check if the User downloaded something. If not..Scare him!
            if (enable_darkmode.Checked && apply_options.Text == "Apply!")
            {
                CheckboxesDisabel();
            }
            else if(enable_darkmode.Checked && enable_music.Checked && download_no)
            { 
                Properties.Settings.Default.darkmode_checked = false;
                Properties.Settings.Default.enable_music = false;
            }
            //If you checked Dark Mode and the File exists
            else if (enable_darkmode.Checked && enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.darkmode_checked = true;
                Properties.Settings.Default.enable_sounds = true;
                //Load Music
                SoundPlayer snd = new SoundPlayer(fileName_dark);
                //We need to call the Sound only if we won or lost, so we save the Preference and call it in the Winscreen
                Properties.Settings.Default.enable_sounds = true;
                //Play the files
                snd.Play();
                Close();
            }
            else if (enable_music.Checked && enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_music = true;
                Properties.Settings.Default.enable_sounds = true;
                //Load Music
                SoundPlayer snd = new SoundPlayer(fileName_standard);
                //We need to call the Sound only if we won or lost, so we save the Preference and call it in the Winscreen
                Properties.Settings.Default.enable_sounds = true;
                //Play the files
                snd.Play();
                Close();
            }
            else if (enable_music.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_music = true;
                //Load Music
                SoundPlayer snd = new SoundPlayer(fileName_standard);
                //Play the files
                snd.Play();
                Close();
            }
            else if (enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_sounds = true;
                Close();
            }
            //If the User pressed the "Delete Files" Button
            else if (delete_files.Checked)
            {
                if((MessageBox.Show("This will DELETE all files downloaded by this Application!", "ATTENTION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    int fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
                    Array.ForEach(Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios"), File.Delete);
                    Close();
                }
                else
                {
                    MessageBox.Show("Whoa! That just went barely wrong! Thank God that you saved me!");
                }
            }
        }
        public void Positions()
        {
            //Hide the Warning
            warning_text.Visible = false;
            //Options can be smaller now
            Size = new Size(231, 270);
            //New Poitions 
            enable_music.Location = new Point(69, 36);
            //Since we hide the Warning, we have more Space to work, but we want a small Menu, so move stuff around
            enable_sound.Location = new Point(69, 75);
            enable_darkmode.Location = new Point(69, 115);
            delete_files.Visible = true;
            delete_files.Location = new Point(69, 155);
            back_button.Location = new Point(12, 200);
            apply_options.Location = new Point(115, 200);
        }
        private void back_button_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

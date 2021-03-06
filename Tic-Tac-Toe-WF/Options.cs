﻿using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_WF
{
    public partial class Options : Form
    {
        //Where to get the files?
        private string remoteUri_dark = "https://www.dropbox.com/s/eww4jlt6z64j15h/dark_mode_music.wav?dl=1";

        private string remoteUri_standard = "https://www.dropbox.com/s/9qjfih3ppksqmer/standard_mode_enabled.wav?dl=1";
        private string remoteUri_win = "https://www.dropbox.com/s/87727v027oiny08/win_sound.wav?dl=1";
        private string remoteUri_lose = "https://www.dropbox.com/s/la7nx6f6471b16k/lose_sound.wav?dl=1";

        //Where to save?
        public string fileName_dark = @"C:\Ultimate Tic-Tac-Toe\Audios\dark_mode_music.wav";

        public string fileName_standard = @"C:\Ultimate Tic-Tac-Toe\Audios\standard_mode_music.wav";
        public string fileName_win = @"C:\Ultimate Tic-Tac-Toe\Audios\win_sound.wav";
        public string fileName_lose = @"C:\Ultimate Tic-Tac-Toe\Audios\lose_sound.wav";
        public string path = @"C:\Ultimate Tic-Tac-Toe\Audios\";

        //Standard variable for the Message Box
        private bool download_no = true;

        private Form1 loadMain = new Form1();

        public Options()
        {
            Directory.CreateDirectory(@"C:\Ultimate Tic-Tac-Toe\Audios");
            string[] dFiles = Directory.GetFiles(@"C:\Ultimate Tic-Tac-Toe\Audios");
            string fCount = dFiles.Length.ToString();
            InitializeComponent();
            //THis only happens if you clicked on the Option Button!
            if (fCount != "4" && Properties.Settings.Default.options_clicked)
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
            download_info.Text = "File 3/4 loading...\r\n\r\n" + remoteUri_win;
            await webClient.DownloadFileTaskAsync(new Uri(remoteUri_win), fileName_win);
            download_info.Text = "File 4/4 loading...\r\n\r\n" + remoteUri_lose;
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
                choose_color_player1.Visible = true;
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
            choose_color_player1_SelectedIndexChanged();
            choose_color_player2_SelectedIndexChanged();
            //ACTIVATE SOUND
            //Check if the User downloaded something. If not..Scare him!
            if (enable_darkmode.Checked && apply_options.Text == "Apply!")
            {
                CheckboxesDisabel();
            }
            else if (enable_darkmode.Checked && enable_music.Checked && download_no)
            {
                Properties.Settings.Default.darkmode_checked = false;
                Properties.Settings.Default.enable_music = false;
                MessageBox.Show("These two can't be enabled at the same time!");
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
                //Play the file
                PlayMusic(snd);
                Close();
            }
            else if (enable_music.Checked && enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_music = true;
                Properties.Settings.Default.enable_sounds = true;
                //Load Music
                SoundPlayer snd = new SoundPlayer(fileName_standard);
                PlayMusic(snd);
                //We need to call the Sounds only if we won or lost, so we save the Preference and call it in the Winscreen
                Properties.Settings.Default.enable_sounds = true;
                Close();
            }
            else if (enable_music.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_music = true;
                //Load Music
                SoundPlayer snd = new SoundPlayer(fileName_standard);
                //Play the files
                PlayMusic(snd);
                Close();
            }
            else if (enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_sounds = true;
                Close();
            }
            else if (enable_darkmode.Checked && download_no)
            {
                SoundPlayer snd = new SoundPlayer(fileName_dark);
                PlayMusic(snd);
                Close();
            }
            //If the User pressed the "Delete Files" Button
            else if (delete_files.Checked)
            {
                if ((MessageBox.Show("This will DELETE all files downloaded by this Application!", "ATTENTION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
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
            //DISABLE SOUND
            else if (!enable_music.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_music = false;
                //Load Music
                SoundPlayer snd = new SoundPlayer(fileName_standard);
                //Play the files
                StopMusic(snd);
                Close();
            }
            else if (!enable_music.Checked && !enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_music = false;
                Properties.Settings.Default.enable_sounds = false;
                //Load Music to stop it
                SoundPlayer snd = new SoundPlayer(fileName_standard);
                //Stop the Music
                StopMusic(snd);
                Close();
            }
            else if (!enable_darkmode.Checked && !enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.darkmode_checked = false;
                Properties.Settings.Default.enable_sounds = false;
                //Load Music to Stop it
                SoundPlayer snd = new SoundPlayer(fileName_dark);
                //Play the files
                StopMusic(snd);
                Close();
            }
            else if (enable_sound.Checked && download_no)
            {
                //Store the State of the Application
                Properties.Settings.Default.enable_sounds = false;
                Close();
            }
        }

        public void Positions()
        {
            //Hide the Warning
            warning_text.Visible = false;
            choose_color_player1.Visible = true;
            choose_color_player2.Visible = true;
            //Options can be smaller now
            Size = new Size(231, 320);
            //New Poitions
            enable_music.Location = new Point(69, 36);
            //Since we hide the Warning, we have more Space to work, but we want a small Menu, so move stuff around
            enable_sound.Location = new Point(69, 75);
            enable_darkmode.Location = new Point(69, 115);
            delete_files.Visible = true;
            delete_files.Location = new Point(69, 155);
            back_button.Location = new Point(12, 250);
            apply_options.Location = new Point(115, 250);
        }

        private void StopMusic(SoundPlayer snd)
        {
            if (!Properties.Settings.Default.enable_music || !Properties.Settings.Default.enable_sounds || !Properties.Settings.Default.darkmode_checked)
            {
                snd.Stop();
            }
        }

        private async Task PlayMusic(SoundPlayer snd)
        {
            snd.Play();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.enable_music = false;
            Properties.Settings.Default.enable_sounds = false;
            Properties.Settings.Default.darkmode_checked = false;
            Close();
        }

        private void choose_color_player1_SelectedIndexChanged()                //all colors for player 1
        {
            int index = choose_color_player1.SelectedIndex;

            if (index == 0)      // 0 = Red
            {
                Properties.Settings.Default.color_playerX = Color.Red;
            }

            if (index == 1)       // 1 == Blue
            {
                Properties.Settings.Default.color_playerX = Color.Blue;
            }

            if (index == 2)       // 2 == Green
            {
                Properties.Settings.Default.color_playerX = Color.LawnGreen;
            }

            if (index == 3)       // 3 == Yellow
            {
                Properties.Settings.Default.color_playerX = Color.Yellow;
            }

            if (index == 4)       // 4 == Pink
            {
                Properties.Settings.Default.color_playerX = Color.Pink;
            }

            if (index == 5)       // 5 == Brown
            {
                Properties.Settings.Default.color_playerX = Color.Brown;
            }
        }

        private void choose_color_player2_SelectedIndexChanged()                        //all colors for player 2
        {
            int index = choose_color_player2.SelectedIndex;

            if (index == 0)      // 0 = Red
            {
                Properties.Settings.Default.color_playerO = Color.Red;
            }

            if (index == 1)       // 1 == Blue
            {
                Properties.Settings.Default.color_playerO = Color.Blue;
            }

            if (index == 2)       // 2 == Green
            {
                Properties.Settings.Default.color_playerO = Color.LawnGreen;
            }

            if (index == 3)       // 3 == Yellow
            {
                Properties.Settings.Default.color_playerO = Color.Yellow;
            }

            if (index == 4)       // 4 == Pink
            {
                Properties.Settings.Default.color_playerO = Color.Pink;
            }

            if (index == 5)       // 5 == Brown
            {
                Properties.Settings.Default.color_playerO = Color.Brown;
            }
        }
    }
}
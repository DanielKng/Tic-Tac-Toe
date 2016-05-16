﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tic_Tac_Toe_WF
{
    public partial class Playernames : Form
    {
        public static string player1Name = "";
        public static string player2Name = "";
        Game loadGame = new Game();
        public Playernames()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //First we need to get the names

            player1Name = Player1.Text;
            player2Name = Player2.Text;

            //Use Uppercase only! ~ Deleted, because it looks ugly

            //player1Name = player1Name.ToUpper();
            //player2Name = player2Name.ToUpper();

            //Check if the Boxes contain any letters, if they contain anything else than letters or nothing - Error
            //true if it doesn't contain letters
            //Bugfix for https://github.com/DanielKng/Tic-Tac-Toe/issues/6 and https://github.com/DanielKng/Tic-Tac-Toe/issues/5

            bool result = player1Name.Any(x => !char.IsLetter(x)) && player2Name.Any(x => !char.IsLetter(x)) || player1Name.Any(x => !char.IsLetter(x)) || player2Name.Any(x => !char.IsLetter(x));

            //IF the result is true, one or both of the Textboxes does contain special characters or a space without letters

            if (result)
            {
                Player1.Text = "Error! Please use a valid name!";
                Player2.Text = "Error! Please use a valid name!";
            }
            //Bugfix for https://github.com/DanielKng/Tic-Tac-Toe/issues/6 and https://github.com/DanielKng/Tic-Tac-Toe/issues/5
            //If the String is empty

            else if (string.IsNullOrEmpty(player1Name) || string.IsNullOrEmpty(player2Name) || string.IsNullOrEmpty(player1Name) && string.IsNullOrEmpty(player2Name))
            {
                Player1.Text = "Error! The name cant be empty!";
                Player2.Text = "Error! The name cant be empty!";
            }
            else
            {
                //Load the Game
                //This is important. With this piece of code the Window gets centered and is at the same place as all other Windows!               
                loadGame.StartPosition = FormStartPosition.CenterScreen;
                loadGame.Show();
                this.Hide();
            }
        }
        //If you typed in the secret command, you can play against the AI!
        private void Player2_TextChanged(object sender, EventArgs e)
        {
            //If the Text in our Player2 Textbox equals "Computer", you can play against the AI!
            if (Player2.Text == "Computer")
            {
                loadGame.ai_enable = true;
            }
            else
            {
                loadGame.ai_enable = false;
            }
        }
    }
}

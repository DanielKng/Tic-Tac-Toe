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
    public partial class Playernames : Form
    {
        public static string player1Name = "X";
        public static string player2Name = "O";
        public Playernames()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //First we need to get the names
            player1Name = Player1.Text;
            player2Name = Player2.Text;

            if (player1Name == "")
            {
                player1Name = "X";
            }

            if (player2Name == "")
            {
                player2Name = "O";
            }
            //Load the Game
            Game loadGame = new Game();
            loadGame.Show();
            this.Hide();
        }
    }
}

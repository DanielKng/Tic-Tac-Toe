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
    public partial class Winscreen : Form
    {
        public Winscreen()
        {
            InitializeComponent();
        }
        //Since we want to show the winning Player in our Textbox, we need to set the winner with "value" from Game.cs
        public string TextBoxValue
        {            
            get { return winscreenTextbox.Text; }
            set { winscreenTextbox.Text = value; }
        }
    }
}

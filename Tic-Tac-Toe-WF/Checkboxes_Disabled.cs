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
    public partial class Checkboxes_Disabled : Form
    {
        public Checkboxes_Disabled()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Blink();
        }
            private async void Blink()
        {
            while (true)
            {
                await Task.Delay(100);
                label1.BackColor = label1.BackColor == Color.Red ? Color.White : Color.Red;
                label1.ForeColor = label1.ForeColor == Color.White ? Color.Green : Color.White;
            }
        }
    }
}

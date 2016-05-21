using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_WF
{
    public partial class Checkboxes_Disabled : Form
    {
        public Checkboxes_Disabled()
        {
            InitializeComponent();
            Blink();
        }

        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(100);
                textBox1.BackColor = textBox1.BackColor == Color.Red ? Color.White : Color.Red;
                textBox1.ForeColor = textBox1.ForeColor == Color.White ? Color.Green : Color.White;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterCreator
{
    public partial class ColorGamma : Form
    {
        public ColorGamma()
        {
            InitializeComponent();
        }

        public double r, g, b;
        public bool sw = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sw)
            {
                instruct.Text = "Введите значения от 0.1 до 5.0";
            }
            else
            {
                instruct.Text = "Введите значения от -255 до 255";
            }
        }

        private void apply_but_Click(object sender, EventArgs e)
        {
            if (sw)
            {
                if (double.TryParse(R.Text, out r) || double.TryParse(G.Text, out g) || double.TryParse(B.Text, out b))
                    if (r > 5.0 || r < 0.1 || g > 5.0 || g < 0.1 || b > 5.0 || b < 0.1) this.DialogResult = DialogResult.OK;
                        else MessageBox.Show("Введенные данные не корректны!");
                else MessageBox.Show("Введенные данные не корректны!");
            }
            else
            {
                if (double.TryParse(R.Text, out r) || double.TryParse(G.Text, out g) || double.TryParse(B.Text, out b))
                    if (r > 255.0 || r < -255 || g > 255 || g < -255 || b > 255 || b < -255) this.DialogResult = DialogResult.OK;
                    else MessageBox.Show("Введенные данные не корректны!");
                else MessageBox.Show("Введенные данные не корректны!");
            }

        }
    }
}

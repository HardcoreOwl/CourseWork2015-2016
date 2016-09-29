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
    public partial class FreqForm : Form
    {
        public FreqForm()
        {
            InitializeComponent();
        }
        public bool pass = true;
        public int style = 0, range=1, power=1;
       
        private void highpass_CheckedChanged(object sender, EventArgs e)
        {
            if (highpass.Checked) lowpass.Checked = false;
            else lowpass.Checked = true;
        }

        private void lowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (lowpass.Checked) highpass.Checked = false;
            else highpass.Checked = true;
        }

        private void gobut_Click(object sender, EventArgs e)
        {
            if (lowpass.Checked) pass = false;
            else pass = true;
            if (!int.TryParse(freqbox.Text.ToString(), out range)||range>256||range<1) MessageBox.Show("Некорретное значение среза.\nВведите значение от 1 до 256.");
            else
            {
                style = stylebox.SelectedIndex;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FreqForm_Load(object sender, EventArgs e)
        {
            stylebox.SelectedIndex = 0;
        }

        private void stylebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stylebox.SelectedIndex != 2) powBox.Enabled = false;
            else powBox.Enabled = true;
        }

        private void track_Scroll(object sender, EventArgs e)
        {
            freqbox.Text = track.Value.ToString();
        }

        private void freqbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(freqbox.Text, out range) && range > 0 && range < 256) track.Value = range;
            else MessageBox.Show("Некорректная частота среза!");
        }
    }
}

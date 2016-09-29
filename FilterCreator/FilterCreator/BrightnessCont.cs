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
    public partial class BrightnessCont : Form
    {
        public double valu;
        public bool sw=true;

        public BrightnessCont()
        {
            InitializeComponent();
        }

        private void apply_but_Click(object sender, EventArgs e)
        {
            if(sw)
            {
                if (double.TryParse(level.Text, out valu) && Math.Abs(valu) <= 255) this.DialogResult = DialogResult.OK;
                else MessageBox.Show("Введенные данные не корректны!");
            }
            else
                if (double.TryParse(level.Text, out valu) && Math.Abs(valu) <= 100) this.DialogResult = DialogResult.OK;
                else MessageBox.Show("Введенные данные не корректны!");
        }

        private void Brightness_Load(object sender, EventArgs e)
        {
            if (sw)
            {
                func.Text = "Ведите значение яркости:"; 
            }
            else func.Text = "Ведите значение контраста:";
        }

    }
}

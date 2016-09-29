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
    public partial class LinearMatrix : Form
    {
        public double[,] Matr;

        private int n, m;

        public LinearMatrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            InitializeComponent();
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
        }

        private void LinearMatrix_Load(object sender, EventArgs e)
        {
            for(int i=0;i<n;i++)
                for(int j=0;j<m;j++)
                {
                    if (i * 2 + 1 == n && j * 2 + 1 == m) dataGridView1[j,i].Value = 1;
                    else dataGridView1[j,i].Value = 0;
                }
            Matr = new double[n, m];
        }

        private void accept_but_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (double.TryParse(dataGridView1[i, j].Value.ToString(), out Matr[i, j])) 
                        this.DialogResult=DialogResult.OK;
                    else
                    {
                        MessageBox.Show("В одной из ячеек указано недействительное значение!");
                    }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            label1.Text = string.Format("Ячейка ({0},{1})",dataGridView1.SelectedCells[0].RowIndex+1,dataGridView1.SelectedCells[0].ColumnIndex+1);
        }

    }
}

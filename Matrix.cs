using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComplexNumers
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CompleNum.Main M = new CompleNum.Main();
            this.Hide();
            M.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MatrixExp ME = new MatrixExp();
            this.Hide();
            ME.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwoUnknows TU = new TwoUnknows();
            this.Hide();
            TU.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreeUnknows TU = new ThreeUnknows();
            this.Hide();
            TU.ShowDialog();
            this.Close();
        }
    }
}

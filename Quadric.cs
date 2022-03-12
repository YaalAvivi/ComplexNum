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
    public partial class Quadric : Form
    {
        public Quadric()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string z1=CompleNum.Program.QadraticEquationNegtaive(a.Text, b.Text, c.Text),z2=CompleNum.Program.QadraticEquationPositive(a.Text, b.Text, c.Text);
            MessageBox.Show("z1=" + z1 + "\nz2=" + z2);
        }

        private void a_TextChanged(object sender, EventArgs e)
        {
            if (a.Text == "" || b.Text == "" || c.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void b_TextChanged(object sender, EventArgs e)
        {
            if (a.Text == "" || b.Text == "" || c.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void c_TextChanged(object sender, EventArgs e)
        {
            if (a.Text == "" || b.Text == "" || c.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CompleNum.BasicMain BM = new CompleNum.BasicMain();
            this.Hide();
            BM.ShowDialog();
            this.Close();
        }
    }
}

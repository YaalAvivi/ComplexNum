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
        private void Back_Click(object sender, EventArgs e)
        {
            CompleNum.BasicMain BM = new CompleNum.BasicMain();
            this.Hide();
            BM.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CompleNum.Program.QadraticEquationNegtaive(a.Text, b.Text, c.Text) + "\n" + CompleNum.Program.QadraticEquationPositive(a.Text, b.Text, c.Text));
        }

    }
}

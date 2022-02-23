using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompleNum
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuadraticSolver BS = new QuadraticSolver();
            this.Hide();
            BS.ShowDialog();
            this.Show();
            this.BringToFront();
        }

        private void ToBasic_Click(object sender, EventArgs e)
        {
            BasicMain BM = new BasicMain();
            this.Hide();
            BM.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ComplexPlane CP = new ComplexPlane();
            this.Hide();
            CP.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComplexNumers.ElectricPower EP = new ComplexNumers.ElectricPower();
            this.Hide();
            EP.ShowDialog();
            this.Close();
        }


    }
}

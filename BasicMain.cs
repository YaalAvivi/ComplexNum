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
    public partial class BasicMain : Form
    {
        public BasicMain()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            this.Hide();
            M.ShowDialog();
            this.Close();
        }

        private void BasicSolver_Click(object sender, EventArgs e)
        {
            BasicSolver BS = new BasicSolver();
            this.Hide();
            BS.ShowDialog();
            this.Close();
        }

        private void BasicExplanation_Click(object sender, EventArgs e)
        {
            BasicExplantion BE = new BasicExplantion();
            this.Hide();
            BE.ShowDialog();
            this.Close();
        }

        private void BasicPractice_Click(object sender, EventArgs e)
        {
            PracticeBasic PB = new PracticeBasic();
            this.Hide();
            PB.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ComplexNumers.Quadric Q = new ComplexNumers.Quadric();
            this.Hide();
            Q.ShowDialog();
            this.Close();
        }

        private void Progressions_Click(object sender, EventArgs e)
        {
            ComplexNumers.Progression P = new ComplexNumers.Progression();
            this.Hide();
            P.ShowDialog();
            this.Close();
        }
    }
}

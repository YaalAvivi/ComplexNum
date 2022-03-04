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
    public partial class Progression : Form
    {
        public Progression()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                label3.Text = "d:";
            else
                label3.Text = "q:";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((a1.Text != "") && (dq.Text != "") && (a.Text != ""))
                aCalculate.Enabled = true;
            else
                aCalculate.Enabled = false;
        }

        private void a1_TextChanged(object sender, EventArgs e)
        {
            if ((a1.Text != "") && (dq.Text != "") && (a.Text != ""))
                aCalculate.Enabled = true;
            else
                aCalculate.Enabled = false;
            if ((a1.Text != "") && (dq.Text != "") && (s.Text != ""))
                sCalculate.Enabled = true;
            else
                sCalculate.Enabled = false;
        }

        private void d_TextChanged(object sender, EventArgs e)
        {
            if ((a1.Text != "") && (dq.Text != "") && (a.Text != ""))
                aCalculate.Enabled = true;
            else
                aCalculate.Enabled = false;
            if ((a1.Text != "") && (dq.Text != "") && (s.Text != ""))
                sCalculate.Enabled = true;
            else
                sCalculate.Enabled = false;
        }

        private void s_TextChanged(object sender, EventArgs e)
        {
            if ((a1.Text != "") && (dq.Text != "") && (s.Text != ""))
                sCalculate.Enabled = true;
            else
                sCalculate.Enabled = false;
        }

        private void aCalculate_Click(object sender, EventArgs e)
        {
            string A1 = a1.Text;
            string DQ = dq.Text;
            string AnsweA = A1 ;
            if (comboBox1.SelectedIndex == 0)
                for (int i = 2; i <= Convert.ToDouble(a.Text); i++)
                    AnsweA = CompleNum.Program.AddTwoComplex(AnsweA, DQ);
            else
            {
                string q = DQ;
                for (int i = 3; i <= Convert.ToDouble(a.Text); i++)
                    DQ = CompleNum.Program.MultiTwoComplex(DQ, q);
                AnsweA = CompleNum.Program.MultiTwoComplex(DQ, AnsweA);
            }
            answerA.Text = "=" + AnsweA;
        }

        private void sCalculate_Click(object sender, EventArgs e)
        {
            string A1 = a1.Text;
            string DQ = dq.Text;
            string AnsweA="";
            if (comboBox1.SelectedIndex == 0)
            {
                AnsweA = ""
                    + CompleNum.Program.MultiTwoComplex("" 
                    + Convert.ToDouble(s.Text) / 2, (CompleNum.Program.AddTwoComplex(CompleNum.Program.MultiTwoComplex("2", A1), CompleNum.Program.MultiTwoComplex("" + (Convert.ToDouble(s.Text) - 1), DQ))));
            }
            else
            {
                string q = DQ;
                for (int i = 2; i <= Convert.ToDouble(s.Text); i++)
                    DQ = CompleNum.Program.MultiTwoComplex(DQ, q);
                DQ = CompleNum.Program.SubstractTwoComplex(DQ,"1");
                AnsweA = CompleNum.Program.MultiTwoComplex(DQ, A1);
                AnsweA = CompleNum.Program.DivideTwoComplex(AnsweA, CompleNum.Program.SubstractTwoComplex(q, "1"));
            }
            AnswerS.Text = "=" + AnsweA;
        }

    }
}

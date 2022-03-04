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
    public partial class PracticeBasic : Form
    {
        //private int _ticks;
        public static int time = 0, questions = 0;
        public static string Paolot="";
        public PracticeBasic()
        {
            InitializeComponent();
            StartButton.Enabled = false;
        }
        public void StartButton_Click(object sender, EventArgs e)
        {
                if (comboBox1.Text.ToString() != "")
                    time = int.Parse(comboBox1.Text.ToString());
                if (NumOfQuestions.Text != "")
                    questions = int.Parse(NumOfQuestions.Text);
                if(plus.Checked)
                    Paolot+="+";
                if(minus.Checked)
                    Paolot+="-";
                if(multi.Checked)
                    Paolot+="*";
                if(divide.Checked)
                    Paolot+="/";
                if ((time > 0) && (questions > 0))
                {
                    PracticeBasic2 PB2 = new PracticeBasic2();
                    this.Hide();
                    PB2.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Time and Questions should be bigger then 0");
        }

        private void NumOfQuestions_TextChanged(object sender, EventArgs e)
        {
            bool flag;
            if (plus.Checked || minus.Checked || multi.Checked || divide.Checked)
                flag = true;
            else
                flag = false;
            if ((NumOfQuestions.Text == "") || (comboBox1.Text == "") || !flag)
                StartButton.Enabled = false;
            else
                StartButton.Enabled = true;
        }


        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            bool flag;
            if (plus.Checked || minus.Checked || multi.Checked || divide.Checked)
                flag = true;
            else
                flag = false;
            if ((NumOfQuestions.Text == "") || (comboBox1.Text == "") || !flag)
                StartButton.Enabled = false;
            else
                StartButton.Enabled = true;
        }

        private void plus_CheckedChanged(object sender, EventArgs e)
        {
            bool flag;
            if (plus.Checked || minus.Checked || multi.Checked || divide.Checked)
                flag = true;
            else
                flag = false;
            if ((NumOfQuestions.Text == "") || (comboBox1.Text == "") || !flag)
                StartButton.Enabled = false;
            else
                StartButton.Enabled = true;
        }

        private void minus_CheckedChanged(object sender, EventArgs e)
        {
            bool flag;
            if (plus.Checked || minus.Checked || multi.Checked || divide.Checked)
                flag = true;
            else
                flag = false;
            if ((NumOfQuestions.Text == "") || (comboBox1.Text == "") || !flag)
                StartButton.Enabled = false;
            else
                StartButton.Enabled = true;
        }

        private void multi_CheckedChanged(object sender, EventArgs e)
        {
            bool flag;
            if (plus.Checked || minus.Checked || multi.Checked || divide.Checked)
                flag = true;
            else
                flag = false;
            if ((NumOfQuestions.Text == "") || (comboBox1.Text == "") || !flag)
                StartButton.Enabled = false;
            else
                StartButton.Enabled = true;
        }

        private void divide_CheckedChanged(object sender, EventArgs e)
        {
            bool flag;
            if (plus.Checked || minus.Checked || multi.Checked || divide.Checked)
                flag = true;
            else
                flag = false;
            if ((NumOfQuestions.Text == "") || (comboBox1.Text == "") || !flag)
                StartButton.Enabled = false;
            else
                StartButton.Enabled = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BasicMain BM = new BasicMain();
            this.Hide();
            BM.ShowDialog();
            this.Close();
        }


    }
}

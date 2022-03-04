using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CompleNum
{
    public partial class PracticeBasic2 : Form
    {

        private int _ticks=PracticeBasic.time;
        private int questions = PracticeBasic.questions;
        private int CountRight = 0,Count=1;
        public static string[] firstNum = new string[PracticeBasic.questions];
        public static string[] secondNum = new string[PracticeBasic.questions];
        public static string[] answerKeep = new string[PracticeBasic.questions];
        public static string[] yourAnswer = new string[PracticeBasic.questions];
        public static bool[] KeepRightAnswers = new bool[PracticeBasic.questions];
        public static string signCount = "";
        string Paolot = PracticeBasic.Paolot;
        Random rnd = new Random();
        public PracticeBasic2()
        {
            for(int g=0;g<questions;g++)
            {
                firstNum[g] = Program.createImaginryNumber(rnd.Next(-21, 21), rnd.Next(-21, 21));
                int milliseconds = 20;
                Thread.Sleep(milliseconds);
                secondNum[g]=Program.createImaginryNumber(rnd.Next(-21,21),rnd.Next(-21,21));                
                signCount+=Paolot[rnd.Next(0,Paolot.Length)];
                switch (signCount[g])
                {
                    case '+':
                        answerKeep[g] = Program.AddTwoComplex(firstNum[g], secondNum[g]);
                        break;
                    case '-':
                        answerKeep[g] = Program.SubstractTwoComplex(firstNum[g], secondNum[g]);
                        break;
                    case '*':
                        answerKeep[g] = Program.MultiTwoComplex(firstNum[g], secondNum[g]);
                        break;
                    default:
                        answerKeep[g] = Program.DivideTwoComplex(firstNum[g], secondNum[g]);
                        break;
                }
                yourAnswer[g] = "";
            }
           
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            timer1.Enabled = true;
            label6.Text = Count + "/" + questions;
            textBox3.Text = firstNum[0];
            textBox2.Text = secondNum[0];
            label3.Text = "" + signCount[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            label5.Text = _ticks / 60 + ":" + _ticks % 60;

            if (_ticks == 0)
            {               
                timer1.Stop();
                MessageBox.Show("Time out! You were correct on " + CountRight + " questions out of " + questions);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (Count + 1 == questions)
            {
                button1.Text = "Finish";
            }
            if (Count == questions)
            {
                yourAnswer[Count - 1] = textBox1.Text;
                textBox1.Text = "";
                timer1.Stop();
                for (int j = 0; j < questions; j++)
                {
                    if ((Program.GetImaginryPart(yourAnswer[j]) == Program.GetImaginryPart(answerKeep[j]) && (Program.GetRealPart(yourAnswer[j]) == Program.GetRealPart(answerKeep[j]))))
                    {
                        CountRight++;
                        KeepRightAnswers[j] = true;
                    }
                    else
                        KeepRightAnswers[j] = false;
                }
                MessageBox.Show("You were correct on " + CountRight + " questions out of " + questions);
                BasicShowAnswers BSA = new BasicShowAnswers();
                this.Hide();
                BSA.ShowDialog();
                this.Close();
            }
            else
            {
                yourAnswer[Count - 1] = textBox1.Text;
                textBox3.Text = firstNum[Count];
                textBox2.Text = secondNum[Count];
                label3.Text = "" + signCount[Count];
                Count++;
                textBox1.Text = yourAnswer[Count - 1];
                label6.Text = Count + "/" + questions;
            }
            }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
                button1.Enabled=true;
            else
                button1.Enabled=false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            PracticeBasic PB = new PracticeBasic();
            this.Hide();
            PB.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yourAnswer[Count - 1] = textBox1.Text;
            button1.Text = "Next question";
            Count--;
            if(Count==1)
                button2.Enabled=false;
            textBox3.Text = firstNum[Count-1];
            label3.Text=""+signCount[Count - 1];
            textBox2.Text = secondNum[Count - 1];
            textBox1.Text = yourAnswer[Count - 1];
            label6.Text = Count + "/" + questions;
        }
    }
}

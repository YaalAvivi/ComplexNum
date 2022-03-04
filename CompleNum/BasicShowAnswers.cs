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
    public partial class BasicShowAnswers : Form
    {
        public static string[] firstNum = PracticeBasic2.firstNum;
        public static string[] secondNum = PracticeBasic2.secondNum;
        public static string[] answerKeep = PracticeBasic2.answerKeep;
        public static bool[] KeepRightAnswers = PracticeBasic2.KeepRightAnswers;
        public static string signCount = PracticeBasic2.signCount;
        public static string[] yourAnswer = PracticeBasic2.yourAnswer;
        public BasicShowAnswers()
        {
            InitializeComponent();
            for (int i = 0; i < signCount.Length; i++)
            {
                if(KeepRightAnswers[i])
                    comboBox1.Items.Add((i+1)+".  "+firstNum[i] + "" + signCount[i] + "(" + secondNum[i] + ")=" + answerKeep[i] + "  (Correct)");
                else
                    comboBox1.Items.Add((i+1) + ".  " + firstNum[i] + "" + signCount[i] + "(" + secondNum[i] + ")=" + answerKeep[i] + "  (Wrong)");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumOfQuestion = comboBox1.SelectedIndex;
            if (signCount[NumOfQuestion] == '+')
            {
                string z1 = firstNum[NumOfQuestion];
                string z2 = secondNum[NumOfQuestion];
                string way = "";
                string z1z2 = "";
                double rz1, rz2, iz1, iz2, real, imaginry;
                rz1 = CompleNum.Program.GetRealPart(z1);
                rz2 = CompleNum.Program.GetRealPart(z2);
                iz1 = CompleNum.Program.GetImaginryPart(z1);
                iz2 = CompleNum.Program.GetImaginryPart(z2);
                real = rz1 + rz2;
                imaginry = iz1 + iz2;
                z1z2 = Program.AddTwoComplex(z1, z2);
                way += ("1. Add the Real part of the equation:" + "\n     " + rz1 + "+(" + rz2 + ")=" + (real) + "\n" +
       "2. Add the Imganiry part of the equation:" + "\n     " + iz1 + "i+(" + iz2 + "i)=" + (imaginry) + "i" + "\n" +
       "3. Add both and you get:" + "\n                    " + "(" + z1 + ")+(" + z2 + ")=" + z1z2);
                    MessageBox.Show(way);
            }
            else if (signCount[NumOfQuestion] == '-')
            {
                string z1 = firstNum[NumOfQuestion];
                string z2 = secondNum[NumOfQuestion];
                string way = "";
                string z1z2 = "";
                double rz1, rz2, iz1, iz2, real, imaginry;
                rz1 = CompleNum.Program.GetRealPart(z1);
                rz2 = CompleNum.Program.GetRealPart(z2);
                iz1 = CompleNum.Program.GetImaginryPart(z1);
                iz2 = CompleNum.Program.GetImaginryPart(z2);
                real = rz1 + rz2;
                imaginry = iz1 + iz2;
                z1z2 = Program.SubstractTwoComplex(z1, z2);
                way += ("1. Substract the Real part of the equation:" + "\n     " + rz1 + "-(" + rz2 + ")=" + (real) + "\n" +
                "2. Substract the Imganiry part of the equation:" + "\n     " + iz1 + "i-(" + iz2 + "i)=" + (imaginry) + "i" + "\n" +
                "3. Substract both and you get:" + "\n                    " + "(" + z1 + ")-(" + z2 + ")=" + z1z2);
                MessageBox.Show(way);
            }
            else if (signCount[NumOfQuestion] == '*')
            {
                string z1 = firstNum[NumOfQuestion];
                string z2 = secondNum[NumOfQuestion];
                string way = "";
                string z1z2 = "";
                double rz1, rz2, iz1, iz2, real, imaginry;
                rz1 = CompleNum.Program.GetRealPart(z1);
                rz2 = CompleNum.Program.GetRealPart(z2);
                iz1 = CompleNum.Program.GetImaginryPart(z1);
                iz2 = CompleNum.Program.GetImaginryPart(z2);
                real = rz1 + rz2;
                imaginry = iz1 + iz2;
                z1z2 = Program.MultiTwoComplex(z1, z2);
                way += "1. Open the bracket:" + "\n     " + "(" + z1 + ")*(" + z2 + ")=(" + rz1 + ")*(" + rz2 + ")+(" + rz1 + ")*(" + iz2 + "i)+(" + iz1 + "i)*(" + rz2 + ")+(" + iz1 + "i*" + iz2 + "i)" +
                      "\n" + "2.Calculate (remember:i*i=-1):" + "\n     " + (rz1 * rz2) + "+(" + (rz1 * iz2) + "i)+(" + (iz1 * rz2) + "i)+(" + (-1 * iz1 * iz2) + ")" + "\n" +
                     "3. Add the Real part of the equation:" + "\n     " + rz1 * rz2 + "+(" + -iz1 * iz2 + ")=" + (real) + "\n" +
                    "4. Add the Imganiry part of the equation:" + "\n     " + rz1 * iz2 + "i+(" + rz2 * iz1 + "i)=" + imaginry + "i" + "\n" +
                     "5. Sum up:" + "\n                    " + "(" + z1 + ")*(" + z2 + ")=" + z1z2;
                MessageBox.Show(way);
            }
            else
            {
                string z1 = firstNum[NumOfQuestion];
                string z2 = secondNum[NumOfQuestion];
                string z2c = Program.GetConjugate(z2);
                string way = "";
                string numerator = "", z1z2 = "";
                double rz1, rz2, iz1, iz2, NumReal, NumImaginry, izc, divider, real, imaginry;
                rz1 = CompleNum.Program.GetRealPart(z1);
                rz2 = CompleNum.Program.GetRealPart(z2);
                iz1 = CompleNum.Program.GetImaginryPart(z1);
                iz2 = CompleNum.Program.GetImaginryPart(z2);
                izc = Program.GetImaginryPart(z2c);
                NumReal = rz1 * rz2 - iz1 * izc;
                NumImaginry = rz1 * izc + rz2 * iz1;
                numerator = Program.createImaginryNumber(NumReal, NumImaginry);
                way += "1.Multiply both denominator and numerator by the Conjugate of the denominator:" + "\n";
                way += "2.1 Open the bracket:" + "\n       " + "(" + z1 + ")*(" + z2c + ")=(" + rz1 + "*" + rz2 + ")+(" + rz1 + "*" + izc + "i)+(" + iz1 + "*" + rz2 + "i)+(" + iz1 + "i*" + izc + "i)" +
"\n" + "2.2 Calculate (remember:i*i=-1):" + "\n       " + (rz1 * rz2) + "+(" + (rz1 * izc) + "i)+(" + (iz1 * rz2) + "i)+(" + (-1 * iz1 * izc) + ")" + "\n" +
"2.3 Add the Real part of the equation:" + "\n       " + rz1 * rz2 + "+(" + -iz1 * izc + ")=" + (NumReal) + "\n" +
        "2.4 Add the Imganiry part of the equation:" + "\n       " + rz1 * izc + "i+(" + rz2 * iz1 + "i)=" + NumImaginry + "i" + "\n" +
        "2.5 Sum up:" + "\n       " + "(" + z1 + ")*(" + z2c + ")=" + numerator + "\n";
                divider = rz2 * rz2 - iz2 * izc;
                real = NumReal / divider;
                imaginry = NumImaginry / divider;
                z1z2 = Program.DivideTwoComplex(z1, z2);
                way += "3.1 Open the bracket:" + "\n       " + "(" + z2 + ")*(" + z2c + ")=" + rz2 + "*" + rz2 + "+" + rz2 + "*" + izc + "i+" + iz2 + "*" + rz2 + "i+" + iz2 + "i*" + izc + "i" +
                      "\n" + "3.2 Calculate (remember:i*i=-1):" + "\n       " + (rz2 * rz2) + "+(" + (rz2 * izc) + "i)+(" + (iz2 * rz2) + "i)+(" + (-1 * iz2 * izc) + ")" + "\n" +
                      "3.3 Add the real part:" + "\n       " + (rz2 * rz2) + "+(" + (-1 * iz2 * izc) + ")=" + divider + "\n" +
                      "4. Divide each part of the numerator by the denominator:" + "\n       " + NumReal + ":" + divider + "=" + real + "\n       " +
                    NumImaginry + "i:" + divider + "=" + imaginry + "i\n" +
                    "5.Sum up:" + "\n                    " + "(" + z1 + "):(" + z2 + ")=" + z1z2;
                    MessageBox.Show(way);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            PracticeBasic PB = new PracticeBasic();
            this.Hide();
             PB.ShowDialog();
             this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NumOfQuestion = comboBox1.SelectedIndex;
            textBox2.Text = yourAnswer[NumOfQuestion];
        }
    }
}

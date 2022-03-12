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
    public partial class ComplexPlane : Form
    {
        public ComplexPlane()
        {
            InitializeComponent();
        }
        Brush MyBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Pen MyPen = new Pen(Color.Black);
        Font drawFont = new Font("Arial", 8);
        private void ComplexPlane_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(MyPen, 250, 100, 250, 350);
            g.DrawLine(MyPen, 50, 250, 450, 250);
            g.DrawString("imaginry",drawFont , MyBrush, 230,80);
            g.DrawString("real", drawFont, MyBrush, 450, 240);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating the Graph
            this.Refresh();
            Graphics g = this.CreateGraphics();
            g.DrawLine(MyPen, 250, 100, 250, 350);
            g.DrawLine(MyPen, 50, 250, 450, 250);
            g.DrawString("imaginry", drawFont, MyBrush, 230, 80);
            g.DrawString("real", drawFont, MyBrush, 450, 240);
            //
            //Drawing the line
            string z = ComplexNum.Text;
            double real = Program.GetRealPart(z), imaginry = Program.GetImaginryPart(z);
            double realForMark = real, imaginryForMark = imaginry;
            int zoom = Convert.ToInt16(textBox1.Text);
            real *= zoom;
            imaginry *= zoom;

            real += 247;
            imaginry += 247;
            imaginry *= -1;
            imaginry = 250 * 2 + imaginry;
            float realF = (float)(real);
            float imaginryF = (float)(imaginry);
            g.DrawLine(MyPen, 250, 250, realF, imaginryF);
            g.DrawLine(MyPen, realF, 245, realF, 255);
            g.DrawLine(MyPen, 245, imaginryF, 255, imaginryF);
            g.DrawString("" + realForMark, new Font("Tahoma", 7), MyBrush, realF + 2, 250);
            g.DrawString("" + imaginryForMark, new Font("Tahoma", 7), MyBrush, 250, imaginryF+2);
            //
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (BasicSolver.flag)
            {
                BasicSolver BS = new BasicSolver();
                this.Hide();
                BS.ShowDialog();
                this.Close();
            }
            else
            {
                Main M = new Main();
                this.Hide();
                M.ShowDialog();
                this.Close();
            }
        }

        private void ComplexPlane_Load(object sender, EventArgs e)
        {
            if (BasicSolver.flag)
                ComplexNum.Text = BasicSolver.num;
        }

        private void ComplexNum_TextChanged(object sender, EventArgs e)
        {
            if (ComplexNum.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

    }
}

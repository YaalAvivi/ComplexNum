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
    public partial class ElectricPower : Form
    {
        public ElectricPower()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(V.Text);
            double i = Convert.ToDouble(I.Text);
            double angle = (Convert.ToDouble(Angle.Text) / 180) * Math.PI;
            P.Text = ""+v*i * Math.Cos(angle);
            Q.Text = "" + v * i * Math.Sin(angle);
            S.Text = "" + v * i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompleNum.Main M = new CompleNum.Main();
            this.Hide();
            M.ShowDialog();
            this.Close();
        }

        private void V_TextChanged(object sender, EventArgs e)
        {
            if (V.Text == "" || I.Text == "" || Angle.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
        private void I_TextChanged(object sender, EventArgs e)
        {
            if (V.Text == "" || I.Text == "" || Angle.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
                    private void Angle_TextChanged(object sender, EventArgs e)
        {
            if (V.Text == "" || I.Text == "" || Angle.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
                    }
        }
        }

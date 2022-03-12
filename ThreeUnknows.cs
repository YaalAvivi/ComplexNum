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
    public partial class ThreeUnknows : Form
    {
        public ThreeUnknows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] arr = new string[3, 3];
            string[] arr2 = new string[3];
            arr[0, 0] =a11.Text;
            arr[0, 1] = a21.Text;
            arr[0, 2] = a31.Text;
            arr[1, 0] = a12.Text;
            arr[1, 1] = a22.Text;
            arr[1, 2] = a32.Text;
            arr[2, 0] = a13.Text;
            arr[2, 1] = a23.Text;
            arr[2, 2] = a33.Text;
            arr2[0] = A1.Text;
            arr2[1] = A2.Text;
            arr2[2] = A3.Text;
            a1A.Text = ""+CompleNum.Program.Det3a1(arr, arr2);
            a2A.Text = "" + CompleNum.Program.Det3a2(arr, arr2);
            a3A.Text = "" + CompleNum.Program.Det3a3(arr, arr2);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Matrix M = new Matrix();
            this.Hide();
            M.ShowDialog();
            this.Close();
        }

        private void a11_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a21_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a31_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" ||a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void A1_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a12_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a22_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a32_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void A2_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a13_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a23_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a33_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void A3_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || a31.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || a32.Text == "" || A3.Text == "" || a13.Text == "" || a23.Text == "" || a33.Text == "" || A3.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

    }
}

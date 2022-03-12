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
    public partial class TwoUnknows : Form
    {
        public TwoUnknows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] arr = new string[2, 2];
            string[] arr2 = new string[2];
            arr[0, 0] = (a11.Text);
            arr[0, 1] = (a21.Text);
            arr[1, 0] = (a12.Text);
            arr[1, 1] = (a22.Text);
            arr2[0] = (A1.Text);
            arr2[1] = (A2.Text);
            a1A.Text = ""+CompleNum.Program.Det2a1(arr, arr2);
            a2A.Text = "" + CompleNum.Program.Det2a2(arr, arr2);
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
            if (a11.Text == "" || a21.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || A2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a21_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || A2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void A1_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || A2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a12_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || A2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void a22_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || A2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void A2_TextChanged(object sender, EventArgs e)
        {
            if (a11.Text == "" || a21.Text == "" || A1.Text == "" || a12.Text == "" || a22.Text == "" || A2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}

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
    public partial class BasicExplantion : Form
    {
        public BasicExplantion()
        {
            InitializeComponent();
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

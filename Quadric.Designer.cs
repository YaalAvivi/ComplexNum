namespace ComplexNumers
{
    partial class Quadric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComplexNumberEx = new System.Windows.Forms.ToolTip(this.components);
            this.c = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BasicHeadline = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(193, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "=0";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(285, 83);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(67, 20);
            this.c.TabIndex = 29;
            this.c.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "z+";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(201, 83);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(67, 20);
            this.b.TabIndex = 27;
            this.b.TextChanged += new System.EventHandler(this.b_TextChanged);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(115, 83);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(67, 20);
            this.a.TabIndex = 26;
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "z²+";
            // 
            // BasicHeadline
            // 
            this.BasicHeadline.AutoSize = true;
            this.BasicHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicHeadline.Location = new System.Drawing.Point(118, 9);
            this.BasicHeadline.Name = "BasicHeadline";
            this.BasicHeadline.Size = new System.Drawing.Size(208, 29);
            this.BasicHeadline.TabIndex = 24;
            this.BasicHeadline.Text = "Quadratic Solver";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(20, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 23);
            this.Back.TabIndex = 23;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "NOTICE: if the solutions include huge numbers (such as with 8 digitis),\r\nthe solu" +
                "tion is not true and can\'t be calculated.";
            // 
            // Quadric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BasicHeadline);
            this.Controls.Add(this.Back);
            this.MaximizeBox = false;
            this.Name = "Quadric";
            this.Text = "Quadric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip ComplexNumberEx;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BasicHeadline;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label4;
    }
}
namespace ComplexNumers
{
    partial class Progression
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
            this.BasicHeadline = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.answerA = new System.Windows.Forms.Label();
            this.AnswerS = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aCalculate = new System.Windows.Forms.Button();
            this.sCalculate = new System.Windows.Forms.Button();
            this.dq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BasicHeadline
            // 
            this.BasicHeadline.AutoSize = true;
            this.BasicHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicHeadline.Location = new System.Drawing.Point(140, 9);
            this.BasicHeadline.Name = "BasicHeadline";
            this.BasicHeadline.Size = new System.Drawing.Size(168, 29);
            this.BasicHeadline.TabIndex = 26;
            this.BasicHeadline.Text = "Progressions";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(5, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 23);
            this.Back.TabIndex = 25;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arithmetic Progression",
            "Geometric Progression"});
            this.comboBox1.Location = new System.Drawing.Point(145, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "Arithmetic progression";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "a1:";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(145, 137);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(30, 20);
            this.a1.TabIndex = 30;
            this.a1.TextChanged += new System.EventHandler(this.a1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "d:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "a";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(120, 249);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(19, 20);
            this.a.TabIndex = 33;
            this.a.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.Location = new System.Drawing.Point(146, 252);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(13, 13);
            this.answerA.TabIndex = 34;
            this.answerA.Text = "=";
            // 
            // AnswerS
            // 
            this.AnswerS.AutoSize = true;
            this.AnswerS.Location = new System.Drawing.Point(146, 288);
            this.AnswerS.Name = "AnswerS";
            this.AnswerS.Size = new System.Drawing.Size(13, 13);
            this.AnswerS.TabIndex = 37;
            this.AnswerS.Text = "=";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(120, 285);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(19, 20);
            this.s.TabIndex = 36;
            this.s.TextChanged += new System.EventHandler(this.s_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "S";
            // 
            // aCalculate
            // 
            this.aCalculate.Enabled = false;
            this.aCalculate.Location = new System.Drawing.Point(233, 247);
            this.aCalculate.Name = "aCalculate";
            this.aCalculate.Size = new System.Drawing.Size(75, 23);
            this.aCalculate.TabIndex = 38;
            this.aCalculate.Text = "Calculate";
            this.aCalculate.UseVisualStyleBackColor = true;
            this.aCalculate.Click += new System.EventHandler(this.aCalculate_Click);
            // 
            // sCalculate
            // 
            this.sCalculate.Enabled = false;
            this.sCalculate.Location = new System.Drawing.Point(233, 285);
            this.sCalculate.Name = "sCalculate";
            this.sCalculate.Size = new System.Drawing.Size(75, 23);
            this.sCalculate.TabIndex = 39;
            this.sCalculate.Text = "Calculate";
            this.sCalculate.UseVisualStyleBackColor = true;
            this.sCalculate.Click += new System.EventHandler(this.sCalculate_Click);
            // 
            // dq
            // 
            this.dq.Location = new System.Drawing.Point(145, 168);
            this.dq.Name = "dq";
            this.dq.Size = new System.Drawing.Size(30, 20);
            this.dq.TabIndex = 40;
            this.dq.TextChanged += new System.EventHandler(this.d_TextChanged);
            // 
            // Progression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 351);
            this.Controls.Add(this.dq);
            this.Controls.Add(this.sCalculate);
            this.Controls.Add(this.aCalculate);
            this.Controls.Add(this.AnswerS);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.answerA);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BasicHeadline);
            this.Controls.Add(this.Back);
            this.MaximizeBox = false;
            this.Name = "Progression";
            this.Text = "Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BasicHeadline;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label answerA;
        private System.Windows.Forms.Label AnswerS;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button aCalculate;
        private System.Windows.Forms.Button sCalculate;
        private System.Windows.Forms.TextBox dq;
    }
}
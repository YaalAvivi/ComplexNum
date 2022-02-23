namespace CompleNum
{
    partial class QuadraticSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuadraticSolver));
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.zForm1 = new System.Windows.Forms.TextBox();
            this.zForm2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.multi = new System.Windows.Forms.Button();
            this.fraction = new System.Windows.Forms.Button();
            this.wayCheck = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            this.ComplexNumberEx = new System.Windows.Forms.ToolTip(this.components);
            this.PolarAnswer = new System.Windows.Forms.Label();
            this.PolerAnswerText = new System.Windows.Forms.TextBox();
            this.BasicHeadline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(140, 167);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(38, 23);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(200, 167);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(38, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // zForm1
            // 
            this.zForm1.Location = new System.Drawing.Point(260, 70);
            this.zForm1.Name = "zForm1";
            this.zForm1.Size = new System.Drawing.Size(100, 20);
            this.zForm1.TabIndex = 2;
            // 
            // zForm2
            // 
            this.zForm2.Location = new System.Drawing.Point(260, 109);
            this.zForm2.Name = "zForm2";
            this.zForm2.Size = new System.Drawing.Size(100, 20);
            this.zForm2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "z1:";
            this.ComplexNumberEx.SetToolTip(this.label1, "A number in the form a+bi");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "z2:";
            this.ComplexNumberEx.SetToolTip(this.label2, "A number in the form a+bi");
            // 
            // AnswerText
            // 
            this.AnswerText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerText.Location = new System.Drawing.Point(115, 227);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.ReadOnly = true;
            this.AnswerText.Size = new System.Drawing.Size(100, 23);
            this.AnswerText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Answer:";
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(260, 167);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(38, 23);
            this.multi.TabIndex = 9;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // fraction
            // 
            this.fraction.Location = new System.Drawing.Point(320, 167);
            this.fraction.Name = "fraction";
            this.fraction.Size = new System.Drawing.Size(38, 23);
            this.fraction.TabIndex = 10;
            this.fraction.Text = ":";
            this.fraction.UseVisualStyleBackColor = true;
            this.fraction.Click += new System.EventHandler(this.fraction_Click);
            // 
            // wayCheck
            // 
            this.wayCheck.AutoSize = true;
            this.wayCheck.Checked = true;
            this.wayCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wayCheck.Location = new System.Drawing.Point(200, 197);
            this.wayCheck.Name = "wayCheck";
            this.wayCheck.Size = new System.Drawing.Size(48, 17);
            this.wayCheck.TabIndex = 11;
            this.wayCheck.Text = "Way";
            this.wayCheck.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 23);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PolarAnswer
            // 
            this.PolarAnswer.AutoSize = true;
            this.PolarAnswer.Location = new System.Drawing.Point(37, 260);
            this.PolarAnswer.Name = "PolarAnswer";
            this.PolarAnswer.Size = new System.Drawing.Size(72, 13);
            this.PolarAnswer.TabIndex = 14;
            this.PolarAnswer.Text = "Polar Answer:";
            // 
            // PolerAnswerText
            // 
            this.PolerAnswerText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolerAnswerText.Location = new System.Drawing.Point(115, 256);
            this.PolerAnswerText.Name = "PolerAnswerText";
            this.PolerAnswerText.ReadOnly = true;
            this.PolerAnswerText.Size = new System.Drawing.Size(100, 23);
            this.PolerAnswerText.TabIndex = 13;
            // 
            // BasicHeadline
            // 
            this.BasicHeadline.AutoSize = true;
            this.BasicHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicHeadline.Location = new System.Drawing.Point(204, 12);
            this.BasicHeadline.Name = "BasicHeadline";
            this.BasicHeadline.Size = new System.Drawing.Size(88, 29);
            this.BasicHeadline.TabIndex = 15;
            this.BasicHeadline.Text = "Solver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(0, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Notice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 52);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter the number in the form \r\na+bi,where \"i\"is the last character.\r\nIf b=0, writ" +
                "e the value of a\r\n(same goes for a=0).\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(216, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Show On \r\nComplex Plane\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BasicSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BasicHeadline);
            this.Controls.Add(this.PolarAnswer);
            this.Controls.Add(this.PolerAnswerText);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.wayCheck);
            this.Controls.Add(this.fraction);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zForm2);
            this.Controls.Add(this.zForm1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BasicSolver";
            this.Text = "Basic Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox zForm1;
        private System.Windows.Forms.TextBox zForm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button fraction;
        private System.Windows.Forms.CheckBox wayCheck;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ToolTip ComplexNumberEx;
        private System.Windows.Forms.Label PolarAnswer;
        private System.Windows.Forms.TextBox PolerAnswerText;
        private System.Windows.Forms.Label BasicHeadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}


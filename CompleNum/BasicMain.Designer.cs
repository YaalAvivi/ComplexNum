namespace CompleNum
{
    partial class BasicMain
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
            this.BasicExplanation = new System.Windows.Forms.Button();
            this.BasicSolver = new System.Windows.Forms.Button();
            this.BasicPractice = new System.Windows.Forms.Button();
            this.BasicHeadline = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Progressions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BasicExplanation
            // 
            this.BasicExplanation.Location = new System.Drawing.Point(190, 80);
            this.BasicExplanation.Name = "BasicExplanation";
            this.BasicExplanation.Size = new System.Drawing.Size(86, 39);
            this.BasicExplanation.TabIndex = 0;
            this.BasicExplanation.Text = "Explanation";
            this.BasicExplanation.UseVisualStyleBackColor = true;
            this.BasicExplanation.Click += new System.EventHandler(this.BasicExplanation_Click);
            // 
            // BasicSolver
            // 
            this.BasicSolver.Location = new System.Drawing.Point(190, 125);
            this.BasicSolver.Name = "BasicSolver";
            this.BasicSolver.Size = new System.Drawing.Size(86, 39);
            this.BasicSolver.TabIndex = 1;
            this.BasicSolver.Text = "Solver";
            this.BasicSolver.UseVisualStyleBackColor = true;
            this.BasicSolver.Click += new System.EventHandler(this.BasicSolver_Click);
            // 
            // BasicPractice
            // 
            this.BasicPractice.Location = new System.Drawing.Point(190, 170);
            this.BasicPractice.Name = "BasicPractice";
            this.BasicPractice.Size = new System.Drawing.Size(86, 39);
            this.BasicPractice.TabIndex = 2;
            this.BasicPractice.Text = "Practice";
            this.BasicPractice.UseVisualStyleBackColor = true;
            this.BasicPractice.Click += new System.EventHandler(this.BasicPractice_Click);
            // 
            // BasicHeadline
            // 
            this.BasicHeadline.AutoSize = true;
            this.BasicHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicHeadline.Location = new System.Drawing.Point(199, 32);
            this.BasicHeadline.Name = "BasicHeadline";
            this.BasicHeadline.Size = new System.Drawing.Size(77, 29);
            this.BasicHeadline.TabIndex = 3;
            this.BasicHeadline.Text = "Basic";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(13, 13);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(49, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quadratic Solver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Progressions
            // 
            this.Progressions.Location = new System.Drawing.Point(190, 260);
            this.Progressions.Name = "Progressions";
            this.Progressions.Size = new System.Drawing.Size(86, 39);
            this.Progressions.TabIndex = 6;
            this.Progressions.Text = "Progressions";
            this.Progressions.UseVisualStyleBackColor = true;
            this.Progressions.Click += new System.EventHandler(this.Progressions_Click);
            // 
            // BasicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Progressions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.BasicHeadline);
            this.Controls.Add(this.BasicPractice);
            this.Controls.Add(this.BasicSolver);
            this.Controls.Add(this.BasicExplanation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BasicMain";
            this.Text = "Main Basic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BasicExplanation;
        private System.Windows.Forms.Button BasicSolver;
        private System.Windows.Forms.Button BasicPractice;
        private System.Windows.Forms.Label BasicHeadline;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Progressions;
    }
}
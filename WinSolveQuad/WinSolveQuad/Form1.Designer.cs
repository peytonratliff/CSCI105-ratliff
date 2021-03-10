namespace WinSolveQuad
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTermC = new System.Windows.Forms.TextBox();
            this.tbTermB = new System.Windows.Forms.TextBox();
            this.tbTermA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.x2Solution = new System.Windows.Forms.Label();
            this.x1Solution = new System.Windows.Forms.Label();
            this.EquationLabel = new System.Windows.Forms.Label();
            this.x2Label = new System.Windows.Forms.Label();
            this.x1Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.solveEquation = new System.Windows.Forms.Button();
            this.resetEquation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.tbTermC);
            this.groupBox1.Controls.Add(this.tbTermB);
            this.groupBox1.Controls.Add(this.tbTermA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equation Terms:";
            // 
            // tbTermC
            // 
            this.tbTermC.Location = new System.Drawing.Point(94, 65);
            this.tbTermC.Name = "tbTermC";
            this.tbTermC.Size = new System.Drawing.Size(100, 21);
            this.tbTermC.TabIndex = 5;
            this.tbTermC.TextChanged += new System.EventHandler(this.TermUpdated);
            // 
            // tbTermB
            // 
            this.tbTermB.Location = new System.Drawing.Point(94, 40);
            this.tbTermB.Name = "tbTermB";
            this.tbTermB.Size = new System.Drawing.Size(100, 21);
            this.tbTermB.TabIndex = 4;
            this.tbTermB.TextChanged += new System.EventHandler(this.TermUpdated);
            // 
            // tbTermA
            // 
            this.tbTermA.Location = new System.Drawing.Point(94, 16);
            this.tbTermA.Name = "tbTermA";
            this.tbTermA.Size = new System.Drawing.Size(100, 21);
            this.tbTermA.TabIndex = 3;
            this.tbTermA.TextChanged += new System.EventHandler(this.TermUpdated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Term C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Term B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Term A:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.x2Solution);
            this.groupBox2.Controls.Add(this.x1Solution);
            this.groupBox2.Controls.Add(this.EquationLabel);
            this.groupBox2.Controls.Add(this.x2Label);
            this.groupBox2.Controls.Add(this.x1Label);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(234, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Solutions:";
            // 
            // x2Solution
            // 
            this.x2Solution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.x2Solution.Location = new System.Drawing.Point(64, 71);
            this.x2Solution.Name = "x2Solution";
            this.x2Solution.Size = new System.Drawing.Size(96, 21);
            this.x2Solution.TabIndex = 5;
            // 
            // x1Solution
            // 
            this.x1Solution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.x1Solution.Location = new System.Drawing.Point(64, 44);
            this.x1Solution.Name = "x1Solution";
            this.x1Solution.Size = new System.Drawing.Size(96, 21);
            this.x1Solution.TabIndex = 4;
            // 
            // EquationLabel
            // 
            this.EquationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EquationLabel.Location = new System.Drawing.Point(64, 17);
            this.EquationLabel.Name = "EquationLabel";
            this.EquationLabel.Size = new System.Drawing.Size(96, 21);
            this.EquationLabel.TabIndex = 3;
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Location = new System.Drawing.Point(36, 74);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(22, 13);
            this.x2Label.TabIndex = 2;
            this.x2Label.Text = "X2:";
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Location = new System.Drawing.Point(36, 48);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(22, 13);
            this.x1Label.TabIndex = 1;
            this.x1Label.Text = "X1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Equation:";
            // 
            // solveEquation
            // 
            this.solveEquation.Enabled = false;
            this.solveEquation.Location = new System.Drawing.Point(13, 120);
            this.solveEquation.Name = "solveEquation";
            this.solveEquation.Size = new System.Drawing.Size(200, 23);
            this.solveEquation.TabIndex = 2;
            this.solveEquation.Text = "Solve";
            this.solveEquation.UseVisualStyleBackColor = true;
            this.solveEquation.Click += new System.EventHandler(this.solveEquation_Click);
            // 
            // resetEquation
            // 
            this.resetEquation.Enabled = false;
            this.resetEquation.Location = new System.Drawing.Point(234, 120);
            this.resetEquation.Name = "resetEquation";
            this.resetEquation.Size = new System.Drawing.Size(200, 23);
            this.resetEquation.TabIndex = 3;
            this.resetEquation.Text = "Reset";
            this.resetEquation.UseVisualStyleBackColor = true;
            this.resetEquation.Click += new System.EventHandler(this.resetEquation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(450, 158);
            this.Controls.Add(this.resetEquation);
            this.Controls.Add(this.solveEquation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quadratic Formula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTermC;
        private System.Windows.Forms.TextBox tbTermB;
        private System.Windows.Forms.TextBox tbTermA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EquationLabel;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label x2Solution;
        private System.Windows.Forms.Label x1Solution;
        private System.Windows.Forms.Button solveEquation;
        private System.Windows.Forms.Button resetEquation;
    }
}


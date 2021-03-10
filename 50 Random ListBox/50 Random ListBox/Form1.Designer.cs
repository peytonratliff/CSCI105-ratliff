namespace _50_Random_ListBox
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
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberListBox
            // 
            this.numberListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.ItemHeight = 21;
            this.numberListBox.Location = new System.Drawing.Point(17, 33);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(103, 361);
            this.numberListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numbers:";
            // 
            // genNumbers
            // 
            this.genNumbers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genNumbers.Location = new System.Drawing.Point(136, 33);
            this.genNumbers.Name = "genNumbers";
            this.genNumbers.Size = new System.Drawing.Size(129, 61);
            this.genNumbers.TabIndex = 2;
            this.genNumbers.Text = "Generate Numbers";
            this.genNumbers.UseVisualStyleBackColor = true;
            this.genNumbers.Click += new System.EventHandler(this.genNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(300, 412);
            this.Controls.Add(this.genNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberListBox);
            this.Name = "Form1";
            this.Text = "Number Generation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genNumbers;
    }
}


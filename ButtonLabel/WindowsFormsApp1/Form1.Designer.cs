namespace WindowsFormsApp1
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fixedLabel = new System.Windows.Forms.Label();
            this.notFixedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fixedLabel
            // 
            this.fixedLabel.AutoSize = true;
            this.fixedLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixedLabel.Location = new System.Drawing.Point(51, 47);
            this.fixedLabel.Name = "fixedLabel";
            this.fixedLabel.Size = new System.Drawing.Size(147, 19);
            this.fixedLabel.TabIndex = 0;
            this.fixedLabel.Text = "This is the fixed label";
            // 
            // notFixedLabel
            // 
            this.notFixedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notFixedLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFixedLabel.Location = new System.Drawing.Point(55, 79);
            this.notFixedLabel.Name = "notFixedLabel";
            this.notFixedLabel.Size = new System.Drawing.Size(166, 23);
            this.notFixedLabel.TabIndex = 1;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Red;
            this.changeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(55, 119);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(166, 31);
            this.changeLabel.TabIndex = 2;
            this.changeLabel.Text = "Change label";
            this.changeLabel.UseVisualStyleBackColor = false;
            this.changeLabel.Click += new System.EventHandler(this.changeLabel_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(27, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(569, 332);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 567);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.notFixedLabel);
            this.Controls.Add(this.fixedLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fixedLabel;
        private System.Windows.Forms.Label notFixedLabel;
        private System.Windows.Forms.Button changeLabel;
    }
}


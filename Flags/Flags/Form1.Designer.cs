namespace Flags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxFinland = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrance = new System.Windows.Forms.PictureBox();
            this.pictureBoxGermany = new System.Windows.Forms.PictureBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGermany)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(-6, -2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(565, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Click a flag to see the name of the country";
            // 
            // pictureBoxFinland
            // 
            this.pictureBoxFinland.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFinland.Image")));
            this.pictureBoxFinland.Location = new System.Drawing.Point(12, 76);
            this.pictureBoxFinland.Name = "pictureBoxFinland";
            this.pictureBoxFinland.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFinland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFinland.TabIndex = 1;
            this.pictureBoxFinland.TabStop = false;
            this.pictureBoxFinland.Click += new System.EventHandler(this.pictureBoxFinland_Click);
            // 
            // pictureBoxFrance
            // 
            this.pictureBoxFrance.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrance.Image")));
            this.pictureBoxFrance.Location = new System.Drawing.Point(225, 76);
            this.pictureBoxFrance.Name = "pictureBoxFrance";
            this.pictureBoxFrance.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrance.TabIndex = 2;
            this.pictureBoxFrance.TabStop = false;
            this.pictureBoxFrance.Click += new System.EventHandler(this.pictureBoxFrance_Click);
            // 
            // pictureBoxGermany
            // 
            this.pictureBoxGermany.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGermany.Image")));
            this.pictureBoxGermany.Location = new System.Drawing.Point(438, 76);
            this.pictureBoxGermany.Name = "pictureBoxGermany";
            this.pictureBoxGermany.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGermany.TabIndex = 3;
            this.pictureBoxGermany.TabStop = false;
            this.pictureBoxGermany.Click += new System.EventHandler(this.pictureBoxGermany_Click);
            // 
            // labelCountryName
            // 
            this.labelCountryName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCountryName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryName.Location = new System.Drawing.Point(225, 198);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(100, 23);
            this.labelCountryName.TabIndex = 4;
            this.labelCountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 271);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.pictureBoxGermany);
            this.Controls.Add(this.pictureBoxFrance);
            this.Controls.Add(this.pictureBoxFinland);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGermany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxFinland;
        private System.Windows.Forms.PictureBox pictureBoxFrance;
        private System.Windows.Forms.PictureBox pictureBoxGermany;
        private System.Windows.Forms.Label labelCountryName;
    }
}


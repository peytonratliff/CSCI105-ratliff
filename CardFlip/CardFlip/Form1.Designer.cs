namespace CardFlip
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
            this.pictureBoxCardBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxCardFront = new System.Windows.Forms.PictureBox();
            this.buttonShowBack = new System.Windows.Forms.Button();
            this.buttonShowFront = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardFront)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCardBack
            // 
            this.pictureBoxCardBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCardBack.Image")));
            this.pictureBoxCardBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCardBack.Name = "pictureBoxCardBack";
            this.pictureBoxCardBack.Size = new System.Drawing.Size(128, 199);
            this.pictureBoxCardBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCardBack.TabIndex = 0;
            this.pictureBoxCardBack.TabStop = false;
            this.pictureBoxCardBack.Visible = false;
            // 
            // pictureBoxCardFront
            // 
            this.pictureBoxCardFront.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCardFront.Image")));
            this.pictureBoxCardFront.Location = new System.Drawing.Point(190, 12);
            this.pictureBoxCardFront.Name = "pictureBoxCardFront";
            this.pictureBoxCardFront.Size = new System.Drawing.Size(128, 199);
            this.pictureBoxCardFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCardFront.TabIndex = 1;
            this.pictureBoxCardFront.TabStop = false;
            this.pictureBoxCardFront.Visible = false;
            // 
            // buttonShowBack
            // 
            this.buttonShowBack.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowBack.Location = new System.Drawing.Point(12, 386);
            this.buttonShowBack.Name = "buttonShowBack";
            this.buttonShowBack.Size = new System.Drawing.Size(75, 43);
            this.buttonShowBack.TabIndex = 2;
            this.buttonShowBack.Text = "Show the card back";
            this.buttonShowBack.UseVisualStyleBackColor = true;
            this.buttonShowBack.Click += new System.EventHandler(this.buttonShowBack_Click);
            // 
            // buttonShowFront
            // 
            this.buttonShowFront.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowFront.Location = new System.Drawing.Point(243, 386);
            this.buttonShowFront.Name = "buttonShowFront";
            this.buttonShowFront.Size = new System.Drawing.Size(75, 43);
            this.buttonShowFront.TabIndex = 3;
            this.buttonShowFront.Text = "Show the card front";
            this.buttonShowFront.UseVisualStyleBackColor = true;
            this.buttonShowFront.Click += new System.EventHandler(this.buttonShowFront_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 441);
            this.Controls.Add(this.buttonShowFront);
            this.Controls.Add(this.buttonShowBack);
            this.Controls.Add(this.pictureBoxCardFront);
            this.Controls.Add(this.pictureBoxCardBack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCardFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCardBack;
        private System.Windows.Forms.PictureBox pictureBoxCardFront;
        private System.Windows.Forms.Button buttonShowBack;
        private System.Windows.Forms.Button buttonShowFront;
    }
}


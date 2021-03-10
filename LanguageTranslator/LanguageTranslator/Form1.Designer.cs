namespace LanguageTranslator
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.ButtonItalian = new System.Windows.Forms.Button();
            this.ButtonSpanish = new System.Windows.Forms.Button();
            this.ButtonGerman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(2, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(484, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Select a language and I will say \"Good Morning\"";
            // 
            // labelTranslation
            // 
            this.labelTranslation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTranslation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTranslation.Location = new System.Drawing.Point(38, 89);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(391, 23);
            this.labelTranslation.TabIndex = 1;
            this.labelTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonItalian
            // 
            this.ButtonItalian.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonItalian.Location = new System.Drawing.Point(38, 173);
            this.ButtonItalian.Name = "ButtonItalian";
            this.ButtonItalian.Size = new System.Drawing.Size(75, 23);
            this.ButtonItalian.TabIndex = 2;
            this.ButtonItalian.Text = "Italian";
            this.ButtonItalian.UseVisualStyleBackColor = true;
            this.ButtonItalian.Click += new System.EventHandler(this.ButtonItalian_Click);
            // 
            // ButtonSpanish
            // 
            this.ButtonSpanish.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSpanish.Location = new System.Drawing.Point(199, 173);
            this.ButtonSpanish.Name = "ButtonSpanish";
            this.ButtonSpanish.Size = new System.Drawing.Size(75, 23);
            this.ButtonSpanish.TabIndex = 3;
            this.ButtonSpanish.Text = "Spanish";
            this.ButtonSpanish.UseVisualStyleBackColor = true;
            this.ButtonSpanish.Click += new System.EventHandler(this.ButtonSpanish_Click);
            // 
            // ButtonGerman
            // 
            this.ButtonGerman.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGerman.Location = new System.Drawing.Point(359, 173);
            this.ButtonGerman.Name = "ButtonGerman";
            this.ButtonGerman.Size = new System.Drawing.Size(75, 23);
            this.ButtonGerman.TabIndex = 4;
            this.ButtonGerman.Text = "German";
            this.ButtonGerman.UseVisualStyleBackColor = true;
            this.ButtonGerman.Click += new System.EventHandler(this.ButtonGerman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 258);
            this.Controls.Add(this.ButtonGerman);
            this.Controls.Add(this.ButtonSpanish);
            this.Controls.Add(this.ButtonItalian);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.Button ButtonItalian;
        private System.Windows.Forms.Button ButtonSpanish;
        private System.Windows.Forms.Button ButtonGerman;
    }
}


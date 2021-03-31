namespace CharacterGeneratorGUI
{
    partial class Stats
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
            this.labelCharacterName = new System.Windows.Forms.Label();
            this.labelRaceClass = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelAgility = new System.Windows.Forms.Label();
            this.labelIntellect = new System.Windows.Forms.Label();
            this.labelStamina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCharacterName
            // 
            this.labelCharacterName.AutoSize = true;
            this.labelCharacterName.Location = new System.Drawing.Point(9, 11);
            this.labelCharacterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCharacterName.Name = "labelCharacterName";
            this.labelCharacterName.Size = new System.Drawing.Size(35, 13);
            this.labelCharacterName.TabIndex = 0;
            this.labelCharacterName.Text = "label1";
            // 
            // labelRaceClass
            // 
            this.labelRaceClass.AutoSize = true;
            this.labelRaceClass.Location = new System.Drawing.Point(9, 24);
            this.labelRaceClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRaceClass.Name = "labelRaceClass";
            this.labelRaceClass.Size = new System.Drawing.Size(35, 13);
            this.labelRaceClass.TabIndex = 1;
            this.labelRaceClass.Text = "label1";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(9, 37);
            this.labelStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(35, 13);
            this.labelStrength.TabIndex = 3;
            this.labelStrength.Text = "label1";
            // 
            // labelAgility
            // 
            this.labelAgility.AutoSize = true;
            this.labelAgility.Location = new System.Drawing.Point(9, 51);
            this.labelAgility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgility.Name = "labelAgility";
            this.labelAgility.Size = new System.Drawing.Size(35, 13);
            this.labelAgility.TabIndex = 4;
            this.labelAgility.Text = "label1";
            // 
            // labelIntellect
            // 
            this.labelIntellect.AutoSize = true;
            this.labelIntellect.Location = new System.Drawing.Point(9, 65);
            this.labelIntellect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIntellect.Name = "labelIntellect";
            this.labelIntellect.Size = new System.Drawing.Size(35, 13);
            this.labelIntellect.TabIndex = 5;
            this.labelIntellect.Text = "label1";
            // 
            // labelStamina
            // 
            this.labelStamina.AutoSize = true;
            this.labelStamina.Location = new System.Drawing.Point(9, 78);
            this.labelStamina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStamina.Name = "labelStamina";
            this.labelStamina.Size = new System.Drawing.Size(35, 13);
            this.labelStamina.TabIndex = 6;
            this.labelStamina.Text = "label1";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(286, 165);
            this.Controls.Add(this.labelStamina);
            this.Controls.Add(this.labelIntellect);
            this.Controls.Add(this.labelAgility);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelRaceClass);
            this.Controls.Add(this.labelCharacterName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCharacterName;
        private System.Windows.Forms.Label labelRaceClass;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelAgility;
        private System.Windows.Forms.Label labelIntellect;
        private System.Windows.Forms.Label labelStamina;
    }
}
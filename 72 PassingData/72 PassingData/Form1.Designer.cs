namespace _72_PassingData
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.fullNameTB = new System.Windows.Forms.TextBox();
         this.raceTB = new System.Windows.Forms.TextBox();
         this.occupationTB = new System.Windows.Forms.TextBox();
         this.strengthTB = new System.Windows.Forms.TextBox();
         this.integrityTB = new System.Windows.Forms.TextBox();
         this.summaryButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(22, 21);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(90, 21);
         this.label1.TabIndex = 0;
         this.label1.Text = "Full Name:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(57, 54);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(55, 21);
         this.label2.TabIndex = 1;
         this.label2.Text = "Race:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(2, 87);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(110, 21);
         this.label3.TabIndex = 2;
         this.label3.Text = "Occupation:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(30, 120);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(82, 21);
         this.label4.TabIndex = 3;
         this.label4.Text = "Strength:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(32, 153);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(80, 21);
         this.label5.TabIndex = 4;
         this.label5.Text = "Integrity:";
         // 
         // fullNameTB
         // 
         this.fullNameTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.fullNameTB.Location = new System.Drawing.Point(118, 18);
         this.fullNameTB.Name = "fullNameTB";
         this.fullNameTB.Size = new System.Drawing.Size(100, 27);
         this.fullNameTB.TabIndex = 5;
         this.fullNameTB.TextChanged += new System.EventHandler(this.fullNameTB_TextChanged);
         // 
         // raceTB
         // 
         this.raceTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.raceTB.Location = new System.Drawing.Point(118, 51);
         this.raceTB.Name = "raceTB";
         this.raceTB.Size = new System.Drawing.Size(100, 27);
         this.raceTB.TabIndex = 6;
         this.raceTB.TextChanged += new System.EventHandler(this.raceTB_TextChanged);
         // 
         // occupationTB
         // 
         this.occupationTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.occupationTB.Location = new System.Drawing.Point(118, 84);
         this.occupationTB.Name = "occupationTB";
         this.occupationTB.Size = new System.Drawing.Size(100, 27);
         this.occupationTB.TabIndex = 7;
         this.occupationTB.TextChanged += new System.EventHandler(this.occupationTB_TextChanged);
         // 
         // strengthTB
         // 
         this.strengthTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.strengthTB.Location = new System.Drawing.Point(118, 117);
         this.strengthTB.Name = "strengthTB";
         this.strengthTB.Size = new System.Drawing.Size(100, 27);
         this.strengthTB.TabIndex = 8;
         this.strengthTB.TextChanged += new System.EventHandler(this.CheckData_TextChanged);
         // 
         // integrityTB
         // 
         this.integrityTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.integrityTB.Location = new System.Drawing.Point(118, 150);
         this.integrityTB.Name = "integrityTB";
         this.integrityTB.Size = new System.Drawing.Size(100, 27);
         this.integrityTB.TabIndex = 9;
         this.integrityTB.TextChanged += new System.EventHandler(this.CheckData_TextChanged);
         // 
         // summaryButton
         // 
         this.summaryButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.summaryButton.Location = new System.Drawing.Point(61, 200);
         this.summaryButton.Name = "summaryButton";
         this.summaryButton.Size = new System.Drawing.Size(129, 59);
         this.summaryButton.TabIndex = 10;
         this.summaryButton.Text = "Summary Information";
         this.summaryButton.UseVisualStyleBackColor = true;
         this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(242, 271);
         this.Controls.Add(this.summaryButton);
         this.Controls.Add(this.integrityTB);
         this.Controls.Add(this.strengthTB);
         this.Controls.Add(this.occupationTB);
         this.Controls.Add(this.raceTB);
         this.Controls.Add(this.fullNameTB);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Player Data";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox fullNameTB;
      private System.Windows.Forms.TextBox raceTB;
      private System.Windows.Forms.TextBox occupationTB;
      private System.Windows.Forms.TextBox strengthTB;
      private System.Windows.Forms.TextBox integrityTB;
      private System.Windows.Forms.Button summaryButton;
   }
}


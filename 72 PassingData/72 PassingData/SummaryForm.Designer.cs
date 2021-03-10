namespace _72_PassingData
{
   partial class SummaryForm
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
         this.summaryLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // summaryLabel
         // 
         this.summaryLabel.AutoSize = true;
         this.summaryLabel.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.summaryLabel.Location = new System.Drawing.Point(12, 18);
         this.summaryLabel.Name = "summaryLabel";
         this.summaryLabel.Size = new System.Drawing.Size(62, 21);
         this.summaryLabel.TabIndex = 0;
         this.summaryLabel.Text = "label1";
         // 
         // SummaryForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(318, 191);
         this.Controls.Add(this.summaryLabel);
         this.Name = "SummaryForm";
         this.Text = "SummaryForm";
         this.Load += new System.EventHandler(this.SummaryForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label summaryLabel;
   }
}
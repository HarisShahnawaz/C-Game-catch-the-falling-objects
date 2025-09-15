namespace CatchTheObjects
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(20, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 21);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: ";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLives.Location = new System.Drawing.Point(250, 20);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(58, 21);
            this.lblLives.TabIndex = 1;
            this.lblLives.Text = "Lives: ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Catch The Objects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace CSC240_06_01_BedAndBreakfast_LDM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label rateLabel;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(88, 50);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(300, 36);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Bailey's";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateLabel.Location = new System.Drawing.Point(144, 110);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(181, 29);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Check our rates";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "BaileysForm";
            this.Text = "Bailey's Bed and Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

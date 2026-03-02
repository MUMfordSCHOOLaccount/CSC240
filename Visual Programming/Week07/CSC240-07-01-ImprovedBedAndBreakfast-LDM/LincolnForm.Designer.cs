namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
{
    partial class LincolnForm
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
        private System.Windows.Forms.Label lincolnDescriptionLabel;
        private System.Windows.Forms.Label lincolnPriceLabel;
        private System.Windows.Forms.PictureBox lincolnPictureBox;

        private void InitializeComponent()
        {
            this.lincolnDescriptionLabel = new System.Windows.Forms.Label();
            this.lincolnPriceLabel = new System.Windows.Forms.Label();
            this.lincolnPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lincolnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lincolnDescriptionLabel
            // 
            this.lincolnDescriptionLabel.AutoSize = true;
            this.lincolnDescriptionLabel.Location = new System.Drawing.Point(30, 30);
            this.lincolnDescriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.lincolnDescriptionLabel.Name = "lincolnDescriptionLabel";
            this.lincolnDescriptionLabel.Size = new System.Drawing.Size(350, 15);
            this.lincolnDescriptionLabel.TabIndex = 0;
            this.lincolnDescriptionLabel.Text = "Return to the 1850s in this lovely room with private bath.";
            // 
            // lincolnPriceLabel
            // 
            this.lincolnPriceLabel.AutoSize = true;
            this.lincolnPriceLabel.Location = new System.Drawing.Point(30, 60);
            this.lincolnPriceLabel.Name = "lincolnPriceLabel";
            this.lincolnPriceLabel.Size = new System.Drawing.Size(100, 15);
            this.lincolnPriceLabel.TabIndex = 1;
            this.lincolnPriceLabel.Text = "$110 per night";
            // 
            // lincolnPictureBox
            // 
            this.lincolnPictureBox.Location = new System.Drawing.Point(30, 90);
            this.lincolnPictureBox.Name = "lincolnPictureBox";
            this.lincolnPictureBox.Size = new System.Drawing.Size(150, 200);
            this.lincolnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lincolnPictureBox.TabIndex = 2;
            this.lincolnPictureBox.TabStop = false;
            // 
            // LincolnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.lincolnPictureBox);
            this.Controls.Add(this.lincolnPriceLabel);
            this.Controls.Add(this.lincolnDescriptionLabel);
            this.Name = "LincolnForm";
            this.Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)(this.lincolnPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

namespace CSC240_06_01_BedAndBreakfast_LDM
{
    partial class BelleAireForm
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
        private System.Windows.Forms.Label belleAireDescriptionLabel;
        private System.Windows.Forms.Label belleAirePriceLabel;

        private void InitializeComponent()
        {
            this.belleAireDescriptionLabel = new System.Windows.Forms.Label();
            this.belleAirePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // belleAireDescriptionLabel
            // 
            this.belleAireDescriptionLabel.AutoSize = true;
            this.belleAireDescriptionLabel.Location = new System.Drawing.Point(30, 30);
            this.belleAireDescriptionLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.belleAireDescriptionLabel.Name = "belleAireDescriptionLabel";
            this.belleAireDescriptionLabel.Size = new System.Drawing.Size(380, 30);
            this.belleAireDescriptionLabel.TabIndex = 0;
            this.belleAireDescriptionLabel.Text = "The Belle Aire suite has two bedrooms,\r\ntwo baths, and a private balcony.";
            // 
            // belleAirePriceLabel
            // 
            this.belleAirePriceLabel.AutoSize = true;
            this.belleAirePriceLabel.Location = new System.Drawing.Point(30, 80);
            this.belleAirePriceLabel.Name = "belleAirePriceLabel";
            this.belleAirePriceLabel.Size = new System.Drawing.Size(120, 15);
            this.belleAirePriceLabel.TabIndex = 1;
            this.belleAirePriceLabel.Text = "$199.99 per night";
            // 
            // BelleAireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(450, 150);
            this.Controls.Add(this.belleAirePriceLabel);
            this.Controls.Add(this.belleAireDescriptionLabel);
            this.Name = "BelleAireForm";
            this.Text = "BelleAireForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

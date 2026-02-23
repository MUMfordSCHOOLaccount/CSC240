namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
{
    partial class BreakfastOptionForm
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
        private System.Windows.Forms.Label breakfastLabel;
        private System.Windows.Forms.RadioButton contRadioButton;
        private System.Windows.Forms.RadioButton fullRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label selectionLabel;

        private void InitializeComponent()
        {
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.contRadioButton = new System.Windows.Forms.RadioButton();
            this.fullRadioButton = new System.Windows.Forms.RadioButton();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.AutoSize = true;
            this.breakfastLabel.Location = new System.Drawing.Point(30, 30);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(200, 15);
            this.breakfastLabel.TabIndex = 0;
            this.breakfastLabel.Text = "Select your breakfast option";
            // 
            // contRadioButton
            // 
            this.contRadioButton.AutoSize = true;
            this.contRadioButton.Checked = true;
            this.contRadioButton.Location = new System.Drawing.Point(50, 60);
            this.contRadioButton.Name = "contRadioButton";
            this.contRadioButton.Size = new System.Drawing.Size(100, 19);
            this.contRadioButton.TabIndex = 1;
            this.contRadioButton.TabStop = true;
            this.contRadioButton.Text = "Continental";
            this.contRadioButton.UseVisualStyleBackColor = true;
            this.contRadioButton.CheckedChanged += new System.EventHandler(this.ContRadioButton_CheckedChanged);
            // 
            // fullRadioButton
            // 
            this.fullRadioButton.AutoSize = true;
            this.fullRadioButton.Location = new System.Drawing.Point(50, 90);
            this.fullRadioButton.Name = "fullRadioButton";
            this.fullRadioButton.Size = new System.Drawing.Size(50, 19);
            this.fullRadioButton.TabIndex = 2;
            this.fullRadioButton.Text = "Full";
            this.fullRadioButton.UseVisualStyleBackColor = true;
            this.fullRadioButton.CheckedChanged += new System.EventHandler(this.FullBreakfastButton_CheckedChanged);
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Location = new System.Drawing.Point(50, 120);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(65, 19);
            this.deluxeRadioButton.TabIndex = 3;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            this.deluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeBreakfastButton_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(70, 160);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(54, 21);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // selectionLabel
            // 
            this.selectionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.selectionLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.selectionLabel.Location = new System.Drawing.Point(30, 195);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(290, 25);
            this.selectionLabel.TabIndex = 5;
            this.selectionLabel.Text = "Current: Continental Breakfast - $6.00";
            this.selectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.LightGreen;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okButton.Location = new System.Drawing.Point(110, 230);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(130, 40);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Confirm";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(350, 290);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deluxeRadioButton);
            this.Controls.Add(this.fullRadioButton);
            this.Controls.Add(this.contRadioButton);
            this.Controls.Add(this.breakfastLabel);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

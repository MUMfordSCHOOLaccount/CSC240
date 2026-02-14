using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_LDM
{
    partial class CarDetailsForm
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
        
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label featuresHeaderLabel;
        private System.Windows.Forms.TextBox featuresTextBox;
        private System.Windows.Forms.Button closeButton;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.engineLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.featuresHeaderLabel = new System.Windows.Forms.Label();
            this.featuresTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Location = new System.Drawing.Point(200, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(250, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Vehicle Details";

            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modelNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.modelNameLabel.Location = new System.Drawing.Point(30, 80);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(200, 26);
            this.modelNameLabel.TabIndex = 1;
            this.modelNameLabel.Text = "Model Name";

            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.priceLabel.Location = new System.Drawing.Point(30, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(150, 22);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price: $XX,XXX";

            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engineLabel.ForeColor = System.Drawing.Color.Black;
            this.engineLabel.Location = new System.Drawing.Point(30, 160);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(180, 18);
            this.engineLabel.TabIndex = 3;
            this.engineLabel.Text = "Engine: X.XL Type";

            // 
            // mpgLabel
            // 
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mpgLabel.ForeColor = System.Drawing.Color.Black;
            this.mpgLabel.Location = new System.Drawing.Point(30, 190);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(200, 18);
            this.mpgLabel.TabIndex = 4;
            this.mpgLabel.Text = "MPG: XX City / XX Hwy";

            // 
            // featuresHeaderLabel
            // 
            this.featuresHeaderLabel.AutoSize = true;
            this.featuresHeaderLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.featuresHeaderLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.featuresHeaderLabel.Location = new System.Drawing.Point(30, 230);
            this.featuresHeaderLabel.Name = "featuresHeaderLabel";
            this.featuresHeaderLabel.Size = new System.Drawing.Size(160, 22);
            this.featuresHeaderLabel.TabIndex = 5;
            this.featuresHeaderLabel.Text = "Standard Features";

            // 
            // featuresTextBox
            // 
            this.featuresTextBox.BackColor = System.Drawing.Color.White;
            this.featuresTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.featuresTextBox.Location = new System.Drawing.Point(30, 260);
            this.featuresTextBox.Multiline = true;
            this.featuresTextBox.Name = "featuresTextBox";
            this.featuresTextBox.ReadOnly = true;
            this.featuresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.featuresTextBox.Size = new System.Drawing.Size(540, 180);
            this.featuresTextBox.TabIndex = 6;

            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkBlue;
            this.closeButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(230, 460);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 50);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);

            // 
            // CarDetailsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 530);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.featuresTextBox);
            this.Controls.Add(this.featuresHeaderLabel);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.engineLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.modelNameLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle Information";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

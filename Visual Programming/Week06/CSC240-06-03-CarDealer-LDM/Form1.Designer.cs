namespace CSC240_06_03_CarDealer_LDM
{
    partial class CarSelectionForm
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
        
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Button sedanButton;
        private System.Windows.Forms.Button suvButton;
        private System.Windows.Forms.Button truckButton;
        private System.Windows.Forms.Button sportsButton;
        private System.Windows.Forms.PictureBox logoBox;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.sedanButton = new System.Windows.Forms.Button();
            this.suvButton = new System.Windows.Forms.Button();
            this.truckButton = new System.Windows.Forms.Button();
            this.sportsButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();

            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Location = new System.Drawing.Point(180, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(440, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "🚗 Premier Auto Sales 🚗";

            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.subtitleLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.subtitleLabel.Location = new System.Drawing.Point(220, 85);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(360, 23);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Select a vehicle to view details";

            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Navy;
            this.logoBox.Location = new System.Drawing.Point(340, 130);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(120, 120);
            this.logoBox.TabIndex = 2;
            this.logoBox.TabStop = false;

            // 
            // sedanButton
            // 
            this.sedanButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.sedanButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sedanButton.ForeColor = System.Drawing.Color.White;
            this.sedanButton.Location = new System.Drawing.Point(100, 280);
            this.sedanButton.Name = "sedanButton";
            this.sedanButton.Size = new System.Drawing.Size(280, 70);
            this.sedanButton.TabIndex = 3;
            this.sedanButton.Tag = "Sedan";
            this.sedanButton.Text = "🚘 Luxury Sedan\r\n2024 Model";
            this.sedanButton.UseVisualStyleBackColor = false;
            this.sedanButton.Click += new System.EventHandler(this.carButton_Click);

            // 
            // suvButton
            // 
            this.suvButton.BackColor = System.Drawing.Color.ForestGreen;
            this.suvButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suvButton.ForeColor = System.Drawing.Color.White;
            this.suvButton.Location = new System.Drawing.Point(420, 280);
            this.suvButton.Name = "suvButton";
            this.suvButton.Size = new System.Drawing.Size(280, 70);
            this.suvButton.TabIndex = 4;
            this.suvButton.Tag = "SUV";
            this.suvButton.Text = "🚙 Family SUV\r\n2024 Model";
            this.suvButton.UseVisualStyleBackColor = false;
            this.suvButton.Click += new System.EventHandler(this.carButton_Click);

            // 
            // truckButton
            // 
            this.truckButton.BackColor = System.Drawing.Color.DarkOrange;
            this.truckButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.truckButton.ForeColor = System.Drawing.Color.White;
            this.truckButton.Location = new System.Drawing.Point(100, 380);
            this.truckButton.Name = "truckButton";
            this.truckButton.Size = new System.Drawing.Size(280, 70);
            this.truckButton.TabIndex = 5;
            this.truckButton.Tag = "Truck";
            this.truckButton.Text = "🚚 Pickup Truck\r\n2024 Model";
            this.truckButton.UseVisualStyleBackColor = false;
            this.truckButton.Click += new System.EventHandler(this.carButton_Click);

            // 
            // sportsButton
            // 
            this.sportsButton.BackColor = System.Drawing.Color.Crimson;
            this.sportsButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sportsButton.ForeColor = System.Drawing.Color.White;
            this.sportsButton.Location = new System.Drawing.Point(420, 380);
            this.sportsButton.Name = "sportsButton";
            this.sportsButton.Size = new System.Drawing.Size(280, 70);
            this.sportsButton.TabIndex = 6;
            this.sportsButton.Tag = "Sports";
            this.sportsButton.Text = "🏎️ Sports Car\r\n2024 Model";
            this.sportsButton.UseVisualStyleBackColor = false;
            this.sportsButton.Click += new System.EventHandler(this.carButton_Click);

            // 
            // CarSelectionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.sportsButton);
            this.Controls.Add(this.truckButton);
            this.Controls.Add(this.suvButton);
            this.Controls.Add(this.sedanButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "CarSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premier Auto Sales - Vehicle Selection";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

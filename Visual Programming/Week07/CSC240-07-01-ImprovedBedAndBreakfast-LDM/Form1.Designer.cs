namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
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
        private System.Windows.Forms.Button showRatesButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button amenitiesButton;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.RadioButton belleAireRadioButton;
        private System.Windows.Forms.RadioButton lincolnRadioButton;
        private System.Windows.Forms.RadioButton continentalRadioButton;
        private System.Windows.Forms.RadioButton fullRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.Label roomSelectionLabel;
        private System.Windows.Forms.Label mealSelectionLabel;
        private System.Windows.Forms.GroupBox roomGroupBox;
        private System.Windows.Forms.GroupBox mealGroupBox;
        private System.Windows.Forms.NumericUpDown nightsNumericUpDown;
        private System.Windows.Forms.Label nightsLabel;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.Label totalPriceLabel;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.showRatesButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.reservationButton = new System.Windows.Forms.Button();
            this.amenitiesButton = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.belleAireRadioButton = new System.Windows.Forms.RadioButton();
            this.lincolnRadioButton = new System.Windows.Forms.RadioButton();
            this.continentalRadioButton = new System.Windows.Forms.RadioButton();
            this.fullRadioButton = new System.Windows.Forms.RadioButton();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.roomSelectionLabel = new System.Windows.Forms.Label();
            this.mealSelectionLabel = new System.Windows.Forms.Label();
            this.roomGroupBox = new System.Windows.Forms.GroupBox();
            this.mealGroupBox = new System.Windows.Forms.GroupBox();
            this.nightsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nightsLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightsNumericUpDown)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.roomGroupBox.SuspendLayout();
            this.mealGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(220, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(360, 45);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Bailey's";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rateLabel.ForeColor = System.Drawing.Color.SlateGray;
            this.rateLabel.Location = new System.Drawing.Point(280, 70);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(240, 25);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Your home away from home";
            // 
            // showRatesButton
            // 
            this.showRatesButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.showRatesButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showRatesButton.Location = new System.Drawing.Point(30, 40);
            this.showRatesButton.Name = "showRatesButton";
            this.showRatesButton.Size = new System.Drawing.Size(180, 45);
            this.showRatesButton.TabIndex = 2;
            this.showRatesButton.Text = "Room Information";
            this.showRatesButton.UseVisualStyleBackColor = false;
            this.showRatesButton.Click += new System.EventHandler(this.RoomInfoButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.LightBlue;
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Location = new System.Drawing.Point(30, 20);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(150, 150);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // reservationButton
            // 
            this.reservationButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reservationButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reservationButton.Location = new System.Drawing.Point(250, 40);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(180, 45);
            this.reservationButton.TabIndex = 4;
            this.reservationButton.Text = "Make Reservation";
            this.reservationButton.UseVisualStyleBackColor = false;
            this.reservationButton.Click += new System.EventHandler(this.reservationButton_Click);
            // 
            // amenitiesButton
            // 
            this.amenitiesButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.amenitiesButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amenitiesButton.Location = new System.Drawing.Point(470, 40);
            this.amenitiesButton.Name = "amenitiesButton";
            this.amenitiesButton.Size = new System.Drawing.Size(180, 45);
            this.amenitiesButton.TabIndex = 5;
            this.amenitiesButton.Text = "Breakfast Information";
            this.amenitiesButton.UseVisualStyleBackColor = false;
            this.amenitiesButton.Click += new System.EventHandler(this.MealInfoButton_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loadingLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.loadingLabel.Location = new System.Drawing.Point(280, 440);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(120, 19);
            this.loadingLabel.TabIndex = 6;
            this.loadingLabel.Text = "Loading, please wait...";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.descriptionLabel.Location = new System.Drawing.Point(30, 190);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(720, 80);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Experience the charm of our cozy bed and breakfast nestled in the heart of the countryside. " +
                "We offer comfortable rooms, delicious homemade breakfasts, and warm hospitality. " +
                "Whether you're here for a weekend getaway or an extended stay, we'll make you feel right at home.";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.BackColor = System.Drawing.Color.Lavender;
            this.infoGroupBox.Controls.Add(this.showRatesButton);
            this.infoGroupBox.Controls.Add(this.reservationButton);
            this.infoGroupBox.Controls.Add(this.amenitiesButton);
            this.infoGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoGroupBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.infoGroupBox.Location = new System.Drawing.Point(30, 290);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(720, 120);
            this.infoGroupBox.TabIndex = 8;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "What would you like to do today?";
            // 
            // roomGroupBox
            // 
            this.roomGroupBox.Controls.Add(this.belleAireRadioButton);
            this.roomGroupBox.Controls.Add(this.lincolnRadioButton);
            this.roomGroupBox.Location = new System.Drawing.Point(220, 105);
            this.roomGroupBox.Name = "roomGroupBox";
            this.roomGroupBox.Size = new System.Drawing.Size(230, 85);
            this.roomGroupBox.TabIndex = 18;
            this.roomGroupBox.TabStop = false;
            // 
            // roomSelectionLabel
            // 
            this.roomSelectionLabel.AutoSize = true;
            this.roomSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomSelectionLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.roomSelectionLabel.Location = new System.Drawing.Point(220, 107);
            this.roomSelectionLabel.Name = "roomSelectionLabel";
            this.roomSelectionLabel.Size = new System.Drawing.Size(150, 20);
            this.roomSelectionLabel.TabIndex = 9;
            this.roomSelectionLabel.Text = "SELECT YOUR ROOM:";
            // 
            // belleAireRadioButton
            // 
            this.belleAireRadioButton.AutoSize = true;
            this.belleAireRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.belleAireRadioButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.belleAireRadioButton.Location = new System.Drawing.Point(10, 25);
            this.belleAireRadioButton.Name = "belleAireRadioButton";
            this.belleAireRadioButton.Size = new System.Drawing.Size(210, 23);
            this.belleAireRadioButton.TabIndex = 10;
            this.belleAireRadioButton.TabStop = true;
            this.belleAireRadioButton.Text = "$$$ Belle Aire Suite - $199.99/night";
            this.belleAireRadioButton.UseVisualStyleBackColor = true;
            this.belleAireRadioButton.CheckedChanged += new System.EventHandler(this.BelleAireRadioButton_CheckedChanged);
            // 
            // lincolnRadioButton
            // 
            this.lincolnRadioButton.AutoSize = true;
            this.lincolnRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lincolnRadioButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lincolnRadioButton.Location = new System.Drawing.Point(10, 50);
            this.lincolnRadioButton.Name = "lincolnRadioButton";
            this.lincolnRadioButton.Size = new System.Drawing.Size(190, 23);
            this.lincolnRadioButton.TabIndex = 11;
            this.lincolnRadioButton.TabStop = true;
            this.lincolnRadioButton.Text = "$$ Lincoln Room - $110/night";
            this.lincolnRadioButton.UseVisualStyleBackColor = true;
            this.lincolnRadioButton.CheckedChanged += new System.EventHandler(this.LincolnRadioButton_CheckedChanged);
            // 
            // showRatesButton
            // 
            this.mealGroupBox.Controls.Add(this.continentalRadioButton);
            this.mealGroupBox.Controls.Add(this.fullRadioButton);
            this.mealGroupBox.Controls.Add(this.deluxeRadioButton);
            this.mealGroupBox.Location = new System.Drawing.Point(470, 105);
            this.mealGroupBox.Name = "mealGroupBox";
            this.mealGroupBox.Size = new System.Drawing.Size(200, 105);
            this.mealGroupBox.TabIndex = 19;
            this.mealGroupBox.TabStop = false;
            // 
            // mealSelectionLabel
            // 
            this.mealSelectionLabel.AutoSize = true;
            this.mealSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mealSelectionLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mealSelectionLabel.Location = new System.Drawing.Point(470, 107);
            this.mealSelectionLabel.Name = "mealSelectionLabel";
            this.mealSelectionLabel.Size = new System.Drawing.Size(190, 20);
            this.mealSelectionLabel.TabIndex = 13;
            this.mealSelectionLabel.Text = "SELECT YOUR BREAKFAST:";
            // 
            // continentalRadioButton
            // 
            this.continentalRadioButton.AutoSize = true;
            this.continentalRadioButton.Checked = true;
            this.continentalRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.continentalRadioButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.continentalRadioButton.Location = new System.Drawing.Point(10, 25);
            this.continentalRadioButton.Name = "continentalRadioButton";
            this.continentalRadioButton.Size = new System.Drawing.Size(150, 23);
            this.continentalRadioButton.TabIndex = 14;
            this.continentalRadioButton.TabStop = true;
            this.continentalRadioButton.Text = "$ Continental - $6.00";
            this.continentalRadioButton.UseVisualStyleBackColor = true;
            this.continentalRadioButton.CheckedChanged += new System.EventHandler(this.ContinentalRadioButton_CheckedChanged);
            // 
            // fullRadioButton
            // 
            this.fullRadioButton.AutoSize = true;
            this.fullRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullRadioButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.fullRadioButton.Location = new System.Drawing.Point(10, 50);
            this.fullRadioButton.Name = "fullRadioButton";
            this.fullRadioButton.Size = new System.Drawing.Size(105, 23);
            this.fullRadioButton.TabIndex = 15;
            this.fullRadioButton.TabStop = true;
            this.fullRadioButton.Text = "$$ Full - $9.95";
            this.fullRadioButton.UseVisualStyleBackColor = true;
            this.fullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deluxeRadioButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.deluxeRadioButton.Location = new System.Drawing.Point(10, 75);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(130, 23);
            this.deluxeRadioButton.TabIndex = 16;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "$$$ Deluxe - $16.50";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            this.deluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeRadioButton_CheckedChanged);
            // 
            // nightsLabel
            // 
            this.nightsLabel.AutoSize = true;
            this.nightsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nightsLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.nightsLabel.Location = new System.Drawing.Point(220, 215);
            this.nightsLabel.Name = "nightsLabel";
            this.nightsLabel.Size = new System.Drawing.Size(160, 20);
            this.nightsLabel.TabIndex = 12;
            this.nightsLabel.Text = "Number of Nights:";
            // 
            // nightsNumericUpDown
            // 
            this.nightsNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nightsNumericUpDown.Location = new System.Drawing.Point(380, 213);
            this.nightsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nightsNumericUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            this.nightsNumericUpDown.Name = "nightsNumericUpDown";
            this.nightsNumericUpDown.Size = new System.Drawing.Size(80, 27);
            this.nightsNumericUpDown.TabIndex = 13;
            this.nightsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nightsNumericUpDown.ValueChanged += new System.EventHandler(this.NightsNumericUpDown_ValueChanged);
            // 
            // summaryLabel
            // 
            this.summaryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summaryLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.summaryLabel.Location = new System.Drawing.Point(30, 420);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(720, 40);
            this.summaryLabel.TabIndex = 14;
            this.summaryLabel.Text = "Make your selections above to see your total";
            this.summaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.Color.Gold;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.totalPriceLabel.Location = new System.Drawing.Point(30, 460);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(720, 60);
            this.totalPriceLabel.TabIndex = 15;
            this.totalPriceLabel.Text = "MAKE YOUR RESERVATION NOW!\n$$ LOCK IN YOUR PRICE - CLICK HERE! $$";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalPriceLabel.Visible = false;
            this.totalPriceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalPriceLabel.Click += new System.EventHandler(this.TotalPriceLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.nightsNumericUpDown);
            this.Controls.Add(this.nightsLabel);
            this.Controls.Add(this.mealSelectionLabel);
            this.Controls.Add(this.mealGroupBox);
            this.Controls.Add(this.roomSelectionLabel);
            this.Controls.Add(this.roomGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "BaileysForm";
            this.Text = "Bailey's Bed and Breakfast - Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightsNumericUpDown)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.roomGroupBox.ResumeLayout(false);
            this.roomGroupBox.PerformLayout();
            this.mealGroupBox.ResumeLayout(false);
            this.mealGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

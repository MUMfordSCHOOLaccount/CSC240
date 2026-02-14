namespace CSC240_06_03_CarDealer_LDM
{
    partial class TropicalResortForm
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
        private System.Windows.Forms.GroupBox departureCityGroup;
        private System.Windows.Forms.Label departureCityLabel;
        private System.Windows.Forms.ComboBox departureCityCombo;
        private System.Windows.Forms.GroupBox roomTypeGroup;
        private System.Windows.Forms.RadioButton standardRoomRadio;
        private System.Windows.Forms.RadioButton deluxeRoomRadio;
        private System.Windows.Forms.RadioButton suiteRoomRadio;
        private System.Windows.Forms.RadioButton villaRoomRadio;
        private System.Windows.Forms.GroupBox mealPlanGroup;
        private System.Windows.Forms.CheckBox breakfastCheck;
        private System.Windows.Forms.CheckBox lunchCheck;
        private System.Windows.Forms.CheckBox dinnerCheck;
        private System.Windows.Forms.CheckBox drinksCheck;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label totalLabel;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.departureCityGroup = new System.Windows.Forms.GroupBox();
            this.departureCityLabel = new System.Windows.Forms.Label();
            this.departureCityCombo = new System.Windows.Forms.ComboBox();
            this.roomTypeGroup = new System.Windows.Forms.GroupBox();
            this.standardRoomRadio = new System.Windows.Forms.RadioButton();
            this.deluxeRoomRadio = new System.Windows.Forms.RadioButton();
            this.suiteRoomRadio = new System.Windows.Forms.RadioButton();
            this.villaRoomRadio = new System.Windows.Forms.RadioButton();
            this.mealPlanGroup = new System.Windows.Forms.GroupBox();
            this.breakfastCheck = new System.Windows.Forms.CheckBox();
            this.lunchCheck = new System.Windows.Forms.CheckBox();
            this.dinnerCheck = new System.Windows.Forms.CheckBox();
            this.drinksCheck = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.departureCityGroup.SuspendLayout();
            this.roomTypeGroup.SuspendLayout();
            this.mealPlanGroup.SuspendLayout();
            this.SuspendLayout();

            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.titleLabel.Location = new System.Drawing.Point(150, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(500, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "🌴 Paradise Tropical Resort 🌴";

            // 
            // departureCityGroup
            // 
            this.departureCityGroup.Controls.Add(this.departureCityLabel);
            this.departureCityGroup.Controls.Add(this.departureCityCombo);
            this.departureCityGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departureCityGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.departureCityGroup.Location = new System.Drawing.Point(30, 80);
            this.departureCityGroup.Name = "departureCityGroup";
            this.departureCityGroup.Size = new System.Drawing.Size(300, 120);
            this.departureCityGroup.TabIndex = 1;
            this.departureCityGroup.TabStop = false;
            this.departureCityGroup.Text = "✈️ Departure City";

            // 
            // departureCityLabel
            // 
            this.departureCityLabel.AutoSize = true;
            this.departureCityLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureCityLabel.ForeColor = System.Drawing.Color.Black;
            this.departureCityLabel.Location = new System.Drawing.Point(20, 35);
            this.departureCityLabel.Name = "departureCityLabel";
            this.departureCityLabel.Size = new System.Drawing.Size(180, 19);
            this.departureCityLabel.TabIndex = 0;
            this.departureCityLabel.Text = "Select your departure city:";

            // 
            // departureCityCombo
            // 
            this.departureCityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departureCityCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departureCityCombo.FormattingEnabled = true;
            this.departureCityCombo.Items.AddRange(new object[] {
                "Miami - $500",
                "New York - $750",
                "Los Angeles - $850",
                "Chicago - $700"
            });
            this.departureCityCombo.Location = new System.Drawing.Point(20, 65);
            this.departureCityCombo.Name = "departureCityCombo";
            this.departureCityCombo.Size = new System.Drawing.Size(260, 25);
            this.departureCityCombo.TabIndex = 1;
            this.departureCityCombo.SelectedIndexChanged += new System.EventHandler(this.departureCity_SelectedIndexChanged);

            // 
            // roomTypeGroup
            // 
            this.roomTypeGroup.Controls.Add(this.standardRoomRadio);
            this.roomTypeGroup.Controls.Add(this.deluxeRoomRadio);
            this.roomTypeGroup.Controls.Add(this.suiteRoomRadio);
            this.roomTypeGroup.Controls.Add(this.villaRoomRadio);
            this.roomTypeGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomTypeGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.roomTypeGroup.Location = new System.Drawing.Point(360, 80);
            this.roomTypeGroup.Name = "roomTypeGroup";
            this.roomTypeGroup.Size = new System.Drawing.Size(300, 180);
            this.roomTypeGroup.TabIndex = 2;
            this.roomTypeGroup.TabStop = false;
            this.roomTypeGroup.Text = "🏨 Room Type";

            // 
            // standardRoomRadio
            // 
            this.standardRoomRadio.AutoSize = true;
            this.standardRoomRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.standardRoomRadio.ForeColor = System.Drawing.Color.Black;
            this.standardRoomRadio.Location = new System.Drawing.Point(20, 35);
            this.standardRoomRadio.Name = "standardRoomRadio";
            this.standardRoomRadio.Size = new System.Drawing.Size(190, 23);
            this.standardRoomRadio.TabIndex = 0;
            this.standardRoomRadio.TabStop = true;
            this.standardRoomRadio.Text = "Standard Room - $1,200";
            this.standardRoomRadio.UseVisualStyleBackColor = true;
            this.standardRoomRadio.CheckedChanged += new System.EventHandler(this.roomType_CheckedChanged);

            // 
            // deluxeRoomRadio
            // 
            this.deluxeRoomRadio.AutoSize = true;
            this.deluxeRoomRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deluxeRoomRadio.ForeColor = System.Drawing.Color.Black;
            this.deluxeRoomRadio.Location = new System.Drawing.Point(20, 70);
            this.deluxeRoomRadio.Name = "deluxeRoomRadio";
            this.deluxeRoomRadio.Size = new System.Drawing.Size(180, 23);
            this.deluxeRoomRadio.TabIndex = 1;
            this.deluxeRoomRadio.TabStop = true;
            this.deluxeRoomRadio.Text = "Deluxe Room - $1,800";
            this.deluxeRoomRadio.UseVisualStyleBackColor = true;
            this.deluxeRoomRadio.CheckedChanged += new System.EventHandler(this.roomType_CheckedChanged);

            // 
            // suiteRoomRadio
            // 
            this.suiteRoomRadio.AutoSize = true;
            this.suiteRoomRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suiteRoomRadio.ForeColor = System.Drawing.Color.Black;
            this.suiteRoomRadio.Location = new System.Drawing.Point(20, 105);
            this.suiteRoomRadio.Name = "suiteRoomRadio";
            this.suiteRoomRadio.Size = new System.Drawing.Size(130, 23);
            this.suiteRoomRadio.TabIndex = 2;
            this.suiteRoomRadio.TabStop = true;
            this.suiteRoomRadio.Text = "Suite - $2,500";
            this.suiteRoomRadio.UseVisualStyleBackColor = true;
            this.suiteRoomRadio.CheckedChanged += new System.EventHandler(this.roomType_CheckedChanged);

            // 
            // villaRoomRadio
            // 
            this.villaRoomRadio.AutoSize = true;
            this.villaRoomRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.villaRoomRadio.ForeColor = System.Drawing.Color.Black;
            this.villaRoomRadio.Location = new System.Drawing.Point(20, 140);
            this.villaRoomRadio.Name = "villaRoomRadio";
            this.villaRoomRadio.Size = new System.Drawing.Size(170, 23);
            this.villaRoomRadio.TabIndex = 3;
            this.villaRoomRadio.TabStop = true;
            this.villaRoomRadio.Text = "Private Villa - $3,500";
            this.villaRoomRadio.UseVisualStyleBackColor = true;
            this.villaRoomRadio.CheckedChanged += new System.EventHandler(this.roomType_CheckedChanged);

            // 
            // mealPlanGroup
            // 
            this.mealPlanGroup.Controls.Add(this.breakfastCheck);
            this.mealPlanGroup.Controls.Add(this.lunchCheck);
            this.mealPlanGroup.Controls.Add(this.dinnerCheck);
            this.mealPlanGroup.Controls.Add(this.drinksCheck);
            this.mealPlanGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mealPlanGroup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mealPlanGroup.Location = new System.Drawing.Point(30, 220);
            this.mealPlanGroup.Name = "mealPlanGroup";
            this.mealPlanGroup.Size = new System.Drawing.Size(300, 180);
            this.mealPlanGroup.TabIndex = 3;
            this.mealPlanGroup.TabStop = false;
            this.mealPlanGroup.Text = "🍽️ Meal Plan (Select All That Apply)";

            // 
            // breakfastCheck
            // 
            this.breakfastCheck.AutoSize = true;
            this.breakfastCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfastCheck.ForeColor = System.Drawing.Color.Black;
            this.breakfastCheck.Location = new System.Drawing.Point(20, 40);
            this.breakfastCheck.Name = "breakfastCheck";
            this.breakfastCheck.Size = new System.Drawing.Size(140, 23);
            this.breakfastCheck.TabIndex = 0;
            this.breakfastCheck.Text = "Breakfast - $300";
            this.breakfastCheck.UseVisualStyleBackColor = true;
            this.breakfastCheck.CheckedChanged += new System.EventHandler(this.mealPlan_CheckedChanged);

            // 
            // lunchCheck
            // 
            this.lunchCheck.AutoSize = true;
            this.lunchCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchCheck.ForeColor = System.Drawing.Color.Black;
            this.lunchCheck.Location = new System.Drawing.Point(20, 75);
            this.lunchCheck.Name = "lunchCheck";
            this.lunchCheck.Size = new System.Drawing.Size(120, 23);
            this.lunchCheck.TabIndex = 1;
            this.lunchCheck.Text = "Lunch - $400";
            this.lunchCheck.UseVisualStyleBackColor = true;
            this.lunchCheck.CheckedChanged += new System.EventHandler(this.mealPlan_CheckedChanged);

            // 
            // dinnerCheck
            // 
            this.dinnerCheck.AutoSize = true;
            this.dinnerCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerCheck.ForeColor = System.Drawing.Color.Black;
            this.dinnerCheck.Location = new System.Drawing.Point(20, 110);
            this.dinnerCheck.Name = "dinnerCheck";
            this.dinnerCheck.Size = new System.Drawing.Size(125, 23);
            this.dinnerCheck.TabIndex = 2;
            this.dinnerCheck.Text = "Dinner - $500";
            this.dinnerCheck.UseVisualStyleBackColor = true;
            this.dinnerCheck.CheckedChanged += new System.EventHandler(this.mealPlan_CheckedChanged);

            // 
            // drinksCheck
            // 
            this.drinksCheck.AutoSize = true;
            this.drinksCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinksCheck.ForeColor = System.Drawing.Color.Black;
            this.drinksCheck.Location = new System.Drawing.Point(20, 145);
            this.drinksCheck.Name = "drinksCheck";
            this.drinksCheck.Size = new System.Drawing.Size(200, 23);
            this.drinksCheck.TabIndex = 3;
            this.drinksCheck.Text = "All-Inclusive Drinks - $200";
            this.drinksCheck.UseVisualStyleBackColor = true;
            this.drinksCheck.CheckedChanged += new System.EventHandler(this.mealPlan_CheckedChanged);

            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DarkCyan;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(360, 280);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 50);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.IndianRed;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(520, 280);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(140, 50);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);

            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.totalLabel.Location = new System.Drawing.Point(360, 350);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(300, 30);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total Package Price: $0.00";
            this.totalLabel.Visible = false;

            // 
            // TropicalResortForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mealPlanGroup);
            this.Controls.Add(this.roomTypeGroup);
            this.Controls.Add(this.departureCityGroup);
            this.Controls.Add(this.titleLabel);
            this.Name = "TropicalResortForm";
            this.Text = "Paradise Tropical Resort - Vacation Packages";
            this.departureCityGroup.ResumeLayout(false);
            this.departureCityGroup.PerformLayout();
            this.roomTypeGroup.ResumeLayout(false);
            this.roomTypeGroup.PerformLayout();
            this.mealPlanGroup.ResumeLayout(false);
            this.mealPlanGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

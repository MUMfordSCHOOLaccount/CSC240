namespace CSC240_06_03_CarDealer_LDM
{
    /// <summary>
    /// Main form for Tropical Resort vacation package selector.
    /// Allows users to choose departure city, room type, and meal plan.
    /// </summary>
    public partial class TropicalResortForm : Form
    {
        private decimal departureCityPrice = 0;
        private decimal roomTypePrice = 0;
        private decimal mealPlanPrice = 0;

        public TropicalResortForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for departure city selection changes.
        /// </summary>
        private void departureCity_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (departureCityCombo.SelectedIndex >= 0)
            {
                switch (departureCityCombo.SelectedIndex)
                {
                    case 0: // Miami
                        departureCityPrice = 500m;
                        break;
                    case 1: // New York
                        departureCityPrice = 750m;
                        break;
                    case 2: // Los Angeles
                        departureCityPrice = 850m;
                        break;
                    case 3: // Chicago
                        departureCityPrice = 700m;
                        break;
                }
            }
        }

        /// <summary>
        /// Event handler for room type radio button selection.
        /// </summary>
        private void roomType_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Name)
                {
                    case "standardRoomRadio":
                        roomTypePrice = 1200m;
                        break;
                    case "deluxeRoomRadio":
                        roomTypePrice = 1800m;
                        break;
                    case "suiteRoomRadio":
                        roomTypePrice = 2500m;
                        break;
                    case "villaRoomRadio":
                        roomTypePrice = 3500m;
                        break;
                }
            }
        }

        /// <summary>
        /// Event handler for meal plan checkbox changes.
        /// </summary>
        private void mealPlan_CheckedChanged(object? sender, EventArgs e)
        {
            mealPlanPrice = 0;

            if (breakfastCheck.Checked)
                mealPlanPrice += 300m;
            
            if (lunchCheck.Checked)
                mealPlanPrice += 400m;
            
            if (dinnerCheck.Checked)
                mealPlanPrice += 500m;
            
            if (drinksCheck.Checked)
                mealPlanPrice += 200m;
        }

        /// <summary>
        /// Event handler for Calculate Total button click.
        /// Displays the total vacation package price.
        /// </summary>
        private void calculateButton_Click(object? sender, EventArgs e)
        {
            decimal total = departureCityPrice + roomTypePrice + mealPlanPrice;
            
            totalLabel.Text = $"Total Package Price: ${total:N2}";
            totalLabel.Visible = true;

            // Show breakdown
            string breakdown = $"Breakdown:\n" +
                             $"Flight from {departureCityCombo.Text}: ${departureCityPrice:N2}\n" +
                             $"Room Type: ${roomTypePrice:N2}\n" +
                             $"Meal Plan: ${mealPlanPrice:N2}\n" +
                             $"????????????????????\n" +
                             $"TOTAL: ${total:N2}";

            MessageBox.Show(breakdown, "Vacation Package Summary", 
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Event handler for Reset button click.
        /// Clears all selections and resets the form.
        /// </summary>
        private void resetButton_Click(object? sender, EventArgs e)
        {
            // Reset combo box
            departureCityCombo.SelectedIndex = -1;

            // Reset radio buttons
            standardRoomRadio.Checked = false;
            deluxeRoomRadio.Checked = false;
            suiteRoomRadio.Checked = false;
            villaRoomRadio.Checked = false;

            // Reset checkboxes
            breakfastCheck.Checked = false;
            lunchCheck.Checked = false;
            dinnerCheck.Checked = false;
            drinksCheck.Checked = false;

            // Reset prices
            departureCityPrice = 0;
            roomTypePrice = 0;
            mealPlanPrice = 0;

            // Hide total
            totalLabel.Visible = false;
        }
    }
}

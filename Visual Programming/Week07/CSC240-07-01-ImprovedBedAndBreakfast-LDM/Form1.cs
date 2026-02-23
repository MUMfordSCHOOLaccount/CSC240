namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
{
    public partial class Form1 : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths;
        private bool isRunning = true;

        // Pricing state variables
        private string selectedSuite = "";
        private decimal suitePrice = 0;
        private string selectedBreakfast = "";
        private decimal breakfastPrice = 0;
        private int numberOfNights = 1;

        public Form1()
        {
            InitializeComponent();
            loadingLabel.Visible = false;

            imagePaths = new string[]
            {
                "Bed-and-breakfast.png",
                "breakfast.png",
                "Bed.png"
            };

            Thread imageRotationThread = new Thread(RotateImages);
            imageRotationThread.IsBackground = true;
            imageRotationThread.Start();
        }

        private void showRatesButton_Click(object sender, EventArgs e)
        {
            showRatesButton.Enabled = false;
            loadingLabel.Visible = true;
            loadingLabel.Text = "Loading rates...";

            Thread ratesThread = new Thread(LoadRates);
            ratesThread.Start();
        }

        private void LoadRates()
        {
            Thread.Sleep(1500);

            this.Invoke(new Action(() =>
            {
                string message = "Standard Room: $75 per night\nDeluxe Room: $120 per night\nSuite: $200 per night";
                MessageBox.Show(message, "Room Rates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadingLabel.Visible = false;
                showRatesButton.Enabled = true;
            }));
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            reservationButton.Enabled = false;
            loadingLabel.Visible = true;
            loadingLabel.Text = "Checking availability...";

            Thread reservationThread = new Thread(CheckAvailability);
            reservationThread.Start();
        }

        private void CheckAvailability()
        {
            Thread.Sleep(2000);

            this.Invoke(new Action(() =>
            {
                decimal totalPerNight = suitePrice + breakfastPrice;
                decimal grandTotal = totalPerNight * numberOfNights;
                
                // Dynamic message based on selections
                string message = grandTotal > 0 
                    ? $"Reserve your trip for {grandTotal:C}!\n\nPlease call us at:\n(555) 123-4567\n\nOr email:\nbaileys@bedandbreakfast.com"
                    : "We have rooms available!\n\nPlease call us at:\n(555) 123-4567\n\nOr email:\nbaileys@bedandbreakfast.com";
                
                MessageBox.Show(message, "Reservations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadingLabel.Visible = false;
                reservationButton.Enabled = true;
            }));
        }

        private void amenitiesButton_Click(object sender, EventArgs e)
        {
            amenitiesButton.Enabled = false;
            loadingLabel.Visible = true;
            loadingLabel.Text = "Loading amenities...";

            Thread amenitiesThread = new Thread(ShowAmenities);
            amenitiesThread.Start();
        }

        private void ShowAmenities()
        {
            Thread.Sleep(1500);

            this.Invoke(new Action(() =>
            {
                string amenities = "Our Amenities Include:\n\n" +
                    "* Free WiFi\n" +
                    "* Complimentary Breakfast\n" +
                    "* Private Bathrooms\n" +
                    "* Garden Access\n" +
                    "* Free Parking\n" +
                    "* Cozy Fireplace";
                MessageBox.Show(amenities, "Amenities", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadingLabel.Visible = false;
                amenitiesButton.Enabled = true;
            }));
        }

        private void RotateImages()
        {
            while (isRunning)
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        if (File.Exists(imagePaths[currentImageIndex]))
                        {
                            logoPictureBox.Image = Image.FromFile(imagePaths[currentImageIndex]);
                            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }));

                    currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;

                    Thread.Sleep(3000);
                }
                catch (Exception)
                {
                    Thread.Sleep(3000);
                }
            }
        }

        private void BelleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireCheckBox.Checked)
            {
                // Uncheck the other room option
                lincolnCheckBox.Checked = false;
                
                // Update room selection
                selectedSuite = "Belle Aire Suite";
                suitePrice = 199.99m;
                
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                
                // Update the pricing display
                UpdatePricingDisplay();
            }
            else if (!lincolnCheckBox.Checked)
            {
                // If unchecking and no other room is selected, clear room selection
                selectedSuite = "";
                suitePrice = 0;
                UpdatePricingDisplay();
            }
        }

        private void LincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnCheckBox.Checked)
            {
                // Uncheck the other room option
                belleAireCheckBox.Checked = false;
                
                // Update room selection
                selectedSuite = "Lincoln Room";
                suitePrice = 110.00m;
                
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                
                // Update the pricing display
                UpdatePricingDisplay();
            }
            else if (!belleAireCheckBox.Checked)
            {
                // If unchecking and no other room is selected, clear room selection
                selectedSuite = "";
                suitePrice = 0;
                UpdatePricingDisplay();
            }
        }

        private void MealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastForm = new BreakfastOptionForm();
            
            if (breakfastForm.ShowDialog() == DialogResult.OK || true) // Always update even if just closed
            {
                selectedBreakfast = breakfastForm.SelectedBreakfastName;
                breakfastPrice = breakfastForm.SelectedBreakfastPrice;
                UpdatePricingDisplay();
            }
        }

        private void NightsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            numberOfNights = (int)nightsNumericUpDown.Value;
            UpdatePricingDisplay();
        }

        private void UpdatePricingDisplay()
        {
            // Build the summary text
            string summary = "Your Selections: ";
            List<string> selections = new List<string>();
            
            if (!string.IsNullOrEmpty(selectedSuite))
            {
                selections.Add($"{selectedSuite} ({suitePrice:C}/night)");
            }
            
            if (!string.IsNullOrEmpty(selectedBreakfast))
            {
                selections.Add($"{selectedBreakfast} ({breakfastPrice:C}/night)");
            }
            
            if (selections.Count > 0)
            {
                summary += string.Join(" + ", selections);
                summary += $" × {numberOfNights} night{(numberOfNights > 1 ? "s" : "")}";
                summaryLabel.Text = summary;
                
                // Calculate and display total
                decimal totalPerNight = suitePrice + breakfastPrice;
                decimal grandTotal = totalPerNight * numberOfNights;
                
                totalPriceLabel.Text = $"$$ TOTAL: {grandTotal:C} - LOCK IN THIS PRICE NOW! $$";
                totalPriceLabel.Visible = true;
            }
            else
            {
                summaryLabel.Text = "Make your selections above to see your total";
                totalPriceLabel.Visible = false;
            }
        }
    }
}


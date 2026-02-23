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

            // Set default breakfast selection
            selectedBreakfast = "Continental Breakfast";
            breakfastPrice = 6.00m;

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

        private void BelleAireRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireRadioButton.Checked)
            {
                selectedSuite = "Belle Aire Suite";
                suitePrice = 199.99m;
                UpdatePricingDisplay();
            }
        }

        private void LincolnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnRadioButton.Checked)
            {
                selectedSuite = "Lincoln Room";
                suitePrice = 110.00m;
                UpdatePricingDisplay();
            }
        }

        private void ContinentalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (continentalRadioButton.Checked)
            {
                selectedBreakfast = "Continental Breakfast";
                breakfastPrice = 6.00m;
                UpdatePricingDisplay();
            }
        }

        private void FullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fullRadioButton.Checked)
            {
                selectedBreakfast = "Full Breakfast";
                breakfastPrice = 9.95m;
                UpdatePricingDisplay();
            }
        }

        private void DeluxeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (deluxeRadioButton.Checked)
            {
                selectedBreakfast = "Deluxe Breakfast";
                breakfastPrice = 16.50m;
                UpdatePricingDisplay();
            }
        }

        private void RoomInfoButton_Click(object sender, EventArgs e)
        {
            string roomInfo = "ROOM DETAILS:\n\n" +
                "?? BELLE AIRE SUITE ($199.99/night)\n" +
                "   • Two bedrooms\n" +
                "   • Two full bathrooms\n" +
                "   • Private balcony with garden view\n" +
                "   • King bed in master, queen in second bedroom\n" +
                "   • Perfect for families or couples traveling together\n\n" +
                "??? LINCOLN ROOM ($110/night)\n" +
                "   • Return to the 1850s!\n" +
                "   • One bedroom with queen bed\n" +
                "   • Private bathroom\n" +
                "   • Historic charm and period decor\n" +
                "   • Cozy and romantic";

            MessageBox.Show(roomInfo, "Room Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MealInfoButton_Click(object sender, EventArgs e)
        {
            string mealInfo = "BREAKFAST OPTIONS:\n\n" +
                "? CONTINENTAL ($6.00)\n" +
                "   • Fresh brewed coffee or tea\n" +
                "   • Orange juice\n" +
                "   • Assorted pastries and muffins\n" +
                "   • Fresh seasonal fruit\n\n" +
                "?? FULL BREAKFAST ($9.95)\n" +
                "   • Everything in Continental, plus:\n" +
                "   • Two eggs (your style)\n" +
                "   • Bacon or sausage\n" +
                "   • Toast with butter and jam\n\n" +
                "?? DELUXE BREAKFAST ($16.50)\n" +
                "   • Eggs Benedict or Belgian waffles\n" +
                "   • Fresh fruit parfait\n" +
                "   • Gourmet coffee or specialty tea\n" +
                "   • Fresh squeezed orange juice\n" +
                "   • Choice of bacon, sausage, or smoked salmon";

            MessageBox.Show(mealInfo, "Breakfast Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


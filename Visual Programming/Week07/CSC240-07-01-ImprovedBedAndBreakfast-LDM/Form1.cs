namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
{
    public partial class Form1 : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths;
        private bool isRunning = true;
        private System.Windows.Forms.Timer flashTimer;
        private bool isFlashVisible = true;

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

            // Initialize flash timer for total banner
            flashTimer = new System.Windows.Forms.Timer();
            flashTimer.Interval = 500; // Flash every 500ms
            flashTimer.Tick += FlashTimer_Tick;

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

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            if (totalPriceLabel.Visible)
            {
                isFlashVisible = !isFlashVisible;
                totalPriceLabel.BackColor = isFlashVisible ? System.Drawing.Color.Gold : System.Drawing.Color.Orange;
            }
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
                "$$$ BELLE AIRE SUITE ($199.99/night)\n" +
                "   • Two bedrooms\n" +
                "   • Two full bathrooms\n" +
                "   • Private balcony with garden view\n" +
                "   • King bed in master, queen in second bedroom\n" +
                "   • Perfect for families or couples traveling together\n\n" +
                "$$ LINCOLN ROOM ($110/night)\n" +
                "   • Return to the 1850s!\n" +
                "   • One bedroom with queen bed\n" +
                "   • Private bathroom\n" +
                "   • Historic charm and period decor\n" +
                "   • Cozy and romantic\n\n" +
                "ALL ROOMS INCLUDE:\n" +
                "   • Free WiFi\n" +
                "   • Complimentary Breakfast\n" +
                "   • Garden Access\n" +
                "   • Free Parking\n" +
                "   • Cozy Fireplace";

            MessageBox.Show(roomInfo, "Room Information & Amenities", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MealInfoButton_Click(object sender, EventArgs e)
        {
            string mealInfo = "BREAKFAST OPTIONS:\n\n" +
                "$ CONTINENTAL ($6.00)\n" +
                "   • Fresh brewed coffee or tea\n" +
                "   • Orange juice\n" +
                "   • Assorted pastries and muffins\n" +
                "   • Fresh seasonal fruit\n\n" +
                "$$ FULL BREAKFAST ($9.95)\n" +
                "   • Everything in Continental, plus:\n" +
                "   • Two eggs (your style)\n" +
                "   • Bacon or sausage\n" +
                "   • Toast with butter and jam\n\n" +
                "$$$ DELUXE BREAKFAST ($16.50)\n" +
                "   • Eggs Benedict or Belgian waffles\n" +
                "   • Fresh fruit parfait\n" +
                "   • Gourmet coffee or specialty tea\n" +
                "   • Fresh squeezed orange juice\n" +
                "   • Choice of bacon, sausage, or smoked salmon";

            MessageBox.Show(mealInfo, "Breakfast Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TotalPriceLabel_Click(object sender, EventArgs e)
        {
            decimal totalPerNight = suitePrice + breakfastPrice;
            decimal grandTotal = totalPerNight * numberOfNights;

            string message = $"Reserve your trip for {grandTotal:C}!\n\n" +
                "?? PHONE: (555) 123-4567\n" +
                "?? EMAIL: baileys@bedandbreakfast.com\n" +
                "?? ADDRESS:\n" +
                "   Bailey's Bed & Breakfast\n" +
                "   123 Country Lane\n" +
                "   Peaceful Valley, ST 12345\n\n" +
                "Call or email us today to secure your reservation!";

            MessageBox.Show(message, "Make Your Reservation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                
                totalPriceLabel.Text = $"MAKE YOUR RESERVATION NOW!\n$$ TOTAL: {grandTotal:C} - CLICK HERE TO RESERVE! $$";
                totalPriceLabel.Visible = true;
                
                // Start flashing!
                flashTimer.Start();
            }
            else
            {
                summaryLabel.Text = "Make your selections above to see your total";
                totalPriceLabel.Visible = false;
                
                // Stop flashing when no selection
                flashTimer.Stop();
            }
        }
    }
}


namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
{
    public partial class Form1 : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths;
        private bool isRunning = true;

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
                MessageBox.Show("We have rooms available!\n\nPlease call us at:\n(555) 123-4567\n\nOr email:\nbaileys@bedandbreakfast.com", 
                    "Reservations", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

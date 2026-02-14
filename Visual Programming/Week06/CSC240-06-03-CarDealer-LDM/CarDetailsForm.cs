using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_LDM
{
    /// <summary>
    /// Details form that displays information about the selected car model.
    /// </summary>
    public partial class CarDetailsForm : Form
    {
        private string carModel;

        public CarDetailsForm(string selectedCar)
        {
            InitializeComponent();
            carModel = selectedCar;
            DisplayCarDetails();
        }

        /// <summary>
        /// Displays detailed information about the selected car model.
        /// </summary>
        private void DisplayCarDetails()
        {
            switch (carModel)
            {
                case "Sedan":
                    modelNameLabel.Text = "2024 Executive Sedan";
                    priceLabel.Text = "Price: $45,999";
                    engineLabel.Text = "Engine: 2.0L Turbocharged I4";
                    mpgLabel.Text = "MPG: 28 City / 38 Highway";
                    featuresTextBox.Text = "Features:\n" +
                        "• Leather interior\n" +
                        "• Premium sound system\n" +
                        "• Heated & ventilated seats\n" +
                        "• Adaptive cruise control\n" +
                        "• Lane keeping assist\n" +
                        "• Sunroof\n" +
                        "• Navigation system";
                    this.BackColor = System.Drawing.Color.LightBlue;
                    break;

                case "SUV":
                    modelNameLabel.Text = "2024 Adventure SUV";
                    priceLabel.Text = "Price: $52,999";
                    engineLabel.Text = "Engine: 3.5L V6";
                    mpgLabel.Text = "MPG: 22 City / 29 Highway";
                    featuresTextBox.Text = "Features:\n" +
                        "• 7-passenger seating\n" +
                        "• All-wheel drive\n" +
                        "• Roof rack\n" +
                        "• Third-row seating\n" +
                        "• 360-degree camera\n" +
                        "• Towing package (5,000 lbs)\n" +
                        "• Cargo management system";
                    this.BackColor = System.Drawing.Color.LightGreen;
                    break;

                case "Truck":
                    modelNameLabel.Text = "2024 Heavy Duty Pickup";
                    priceLabel.Text = "Price: $48,999";
                    engineLabel.Text = "Engine: 5.7L V8";
                    mpgLabel.Text = "MPG: 18 City / 24 Highway";
                    featuresTextBox.Text = "Features:\n" +
                        "• Crew cab (4 doors)\n" +
                        "• 6.5-foot bed\n" +
                        "• Towing capacity: 10,000 lbs\n" +
                        "• Bed liner included\n" +
                        "• 4WD system\n" +
                        "• Backup camera\n" +
                        "• Trailer brake controller";
                    this.BackColor = System.Drawing.Color.LightYellow;
                    break;

                case "Sports":
                    modelNameLabel.Text = "2024 Performance Sports Car";
                    priceLabel.Text = "Price: $68,999";
                    engineLabel.Text = "Engine: 4.0L Twin-Turbo V8";
                    mpgLabel.Text = "MPG: 16 City / 24 Highway";
                    featuresTextBox.Text = "Features:\n" +
                        "• 450 HP engine\n" +
                        "• 0-60 mph in 4.2 seconds\n" +
                        "• Sport-tuned suspension\n" +
                        "• Performance brakes\n" +
                        "• Carbon fiber accents\n" +
                        "• Launch control\n" +
                        "• Track mode";
                    this.BackColor = System.Drawing.Color.LightCoral;
                    break;
            }
        }

        /// <summary>
        /// Event handler for close button - closes the details form.
        /// </summary>
        private void closeButton_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}

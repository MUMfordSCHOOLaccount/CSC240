namespace CSC240_06_03_CarDealer_LDM
{
    /// <summary>
    /// Main form for car dealership - allows users to select a car model.
    /// </summary>
    public partial class CarSelectionForm : Form
    {
        public CarSelectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for car selection buttons.
        /// Opens the car details form for the selected model.
        /// </summary>
        private void carButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                string carModel = btn.Tag?.ToString() ?? "";
                CarDetailsForm detailsForm = new CarDetailsForm(carModel);
                detailsForm.ShowDialog();
            }
        }
    }
}

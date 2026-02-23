namespace CSC240_06_01_BedAndBreakfast_LDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showRatesButton_Click(object sender, EventArgs e)
        {
            string message = "Standard Room: $75 per night\nDeluxe Room: $120 per night\nSuite: $200 per night";
            MessageBox.Show(message, "Room Rates", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // New method to update selection display
        private void UpdateSelectionLabel()
        {
            selectionLabel.Text = $"Current: {SelectedBreakfastName} - {SelectedBreakfastPrice:C}";
        }

        // Confirm button closes form properly
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Dynamic message based on selections
        private string GetReservationMessage(decimal grandTotal)
        {
            return grandTotal > 0
                ? $"Reserve your trip for {grandTotal:C}!\n\n..."
                : "We have rooms available!\n\n...";
        }
    }
}

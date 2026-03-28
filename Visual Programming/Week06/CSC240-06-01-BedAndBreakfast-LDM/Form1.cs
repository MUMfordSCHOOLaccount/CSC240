namespace CSC240_06_01_BedAndBreakfast_LDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BelleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleAireCheckBox.Checked = false;
            }
        }

        private void LincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnCheckBox.Checked)
            {
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                lincolnCheckBox.Checked = false;
            }
        }

        private void MealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastForm = new BreakfastOptionForm();
            breakfastForm.ShowDialog();
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

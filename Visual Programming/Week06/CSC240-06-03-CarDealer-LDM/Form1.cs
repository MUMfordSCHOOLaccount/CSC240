using System;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_LDM
{
    public partial class CarSelectionForm : Form
    {
        public CarSelectionForm()
        {
            InitializeComponent();
        }

        private void carButton_Click(object sender, EventArgs e)
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

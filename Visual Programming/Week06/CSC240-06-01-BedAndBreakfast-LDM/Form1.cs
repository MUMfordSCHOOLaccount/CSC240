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
    }
}

namespace CSC240_07_01_ImprovedBedAndBreakfast_LDM
{
    public partial class BreakfastOptionForm : Form
    {
        private const double CONT_BREAKFAST_PRICE = 6.00;
        private const double FULL_BREAKFAST_PRICE = 9.95;
        private const double DELUXE_BREAKFAST_PRICE = 16.50;

        public decimal SelectedBreakfastPrice { get; private set; }
        public string SelectedBreakfastName { get; private set; }

        public BreakfastOptionForm()
        {
            InitializeComponent();
            SelectedBreakfastPrice = (decimal)CONT_BREAKFAST_PRICE;
            SelectedBreakfastName = "Continental Breakfast";
        }

        private void BreakfastOptionForm_Load(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void ContRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (contRadioButton.Checked)
            {
                priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
                SelectedBreakfastPrice = (decimal)CONT_BREAKFAST_PRICE;
                SelectedBreakfastName = "Continental Breakfast";
            }
        }

        private void FullBreakfastButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fullRadioButton.Checked)
            {
                priceLabel.Text = "Price: " + FULL_BREAKFAST_PRICE.ToString("C");
                SelectedBreakfastPrice = (decimal)FULL_BREAKFAST_PRICE;
                SelectedBreakfastName = "Full Breakfast";
            }
        }

        private void DeluxeBreakfastButton_CheckedChanged(object sender, EventArgs e)
        {
            if (deluxeRadioButton.Checked)
            {
                priceLabel.Text = "Price: " + DELUXE_BREAKFAST_PRICE.ToString("C");
                SelectedBreakfastPrice = (decimal)DELUXE_BREAKFAST_PRICE;
                SelectedBreakfastName = "Deluxe Breakfast";
            }
        }
    }
}

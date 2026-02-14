namespace CSC240_06_02_FiveColors2_LDM
{
    public partial class MainForm : Form
    {
        private Color defaultBackColor;

        public MainForm()
        {
            InitializeComponent();
            defaultBackColor = this.BackColor;
        }

        private void colorRadio_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                switch (rb.Name)
                {
                    case "redRadio":
                        this.BackColor = Color.Red;
                        break;
                    case "greenRadio":
                        this.BackColor = Color.Green;
                        break;
                    case "blueRadio":
                        this.BackColor = Color.Blue;
                        break;
                    case "yellowRadio":
                        this.BackColor = Color.Yellow;
                        break;
                    case "purpleRadio":
                        this.BackColor = Color.Purple;
                        break;
                }
            }
        }

        private void resetButton_Click(object? sender, EventArgs e)
        {
            this.BackColor = defaultBackColor;
            redRadio.Checked = false;
            greenRadio.Checked = false;
            blueRadio.Checked = false;
            yellowRadio.Checked = false;
            purpleRadio.Checked = false;
        }
    }
}
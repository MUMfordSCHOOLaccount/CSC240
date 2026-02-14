namespace FiveColors2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
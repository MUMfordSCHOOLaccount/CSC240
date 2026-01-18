namespace HelloVisualWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayOutputButtonClick(object sender, EventArgs e)
        {
            helloLabel.Visible = true;
            changeOutputButton.Enabled = true;
        }

        private void ChangeOutputButtonClick(object sender, EventArgs e)
        {
            helloLabel.Text = "Goodbye";
        }
    }
}

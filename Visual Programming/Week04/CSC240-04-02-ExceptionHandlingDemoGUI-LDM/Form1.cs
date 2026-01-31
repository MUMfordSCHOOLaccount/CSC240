namespace CSC240_04_02_ExceptionHandlingDemoGUI_LDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(txtInput.Text);
                lblResult.Text = "That is an integer";
            }
            catch (Exception)
            {
                lblResult.Text = "That is NOT an integer";
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace CSC240_01_02_TestsInteractiveGUI_LDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double test1 = Convert.ToDouble(txtTest1.Text);
                double test2 = Convert.ToDouble(txtTest2.Text);
                double test3 = Convert.ToDouble(txtTest3.Text);
                double test4 = Convert.ToDouble(txtTest4.Text);
                double test5 = Convert.ToDouble(txtTest5.Text);

                double average = (test1 + test2 + test3 + test4 + test5) / 5.0;

                lblResult.Text = average.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for all test scores.", 
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
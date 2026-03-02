using System;
using System.IO;
using System.Windows.Forms;

namespace CSC240_09_01_EnterInvoices_LDM
{
    public partial class Form1 : Form
    {
        private const string fileName = @"D:\SCHOOL\SCHOOL\GitHubFolder\CSC-240 Visual Programming\Git\CSC240\Visual Programming\Week09\Invoices\Invoices.txt";
        private FileStream outFile;
        private StreamWriter writer;

        public Form1()
        {
            InitializeComponent();

            string targetFile = fileName;
            try
            {
                string dir = Path.GetDirectoryName(targetFile);
                if (string.IsNullOrEmpty(dir) || !Directory.Exists(dir))
                {
                    // fall back to per-user app data location
                    string appDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CSC240", "Invoices");
                    Directory.CreateDirectory(appDataDir);
                    targetFile = Path.Combine(appDataDir, "Invoices.txt");
                }

                // create directory if missing for chosen targetFile
                string chosenDir = Path.GetDirectoryName(targetFile);
                if (!string.IsNullOrEmpty(chosenDir))
                    Directory.CreateDirectory(chosenDir);

                outFile = new FileStream(targetFile, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile) { AutoFlush = true };
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException || ex is System.Security.SecurityException)
            {
                MessageBox.Show("Could not open invoices file: " + ex.Message, "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Prevent user actions that would attempt writes
                if (enterButton != null) enterButton.Enabled = false;
                writer = null;
                outFile = null;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (writer == null)
            {
                MessageBox.Show("Cannot write to file. File not opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input
            if (string.IsNullOrWhiteSpace(invoiceBox.Text) ||
                string.IsNullOrWhiteSpace(nameBox.Text) ||
                string.IsNullOrWhiteSpace(amountBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate amount is a valid decimal
            if (!decimal.TryParse(amountBox.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Write the invoice data to the file
            writer.WriteLine($"{invoiceBox.Text},{nameBox.Text},{amount:F2}");

            // Clear the text boxes for the next entry
            invoiceBox.Clear();
            nameBox.Clear();
            amountBox.Clear();
            invoiceBox.Focus();

            MessageBox.Show("Invoice record entered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

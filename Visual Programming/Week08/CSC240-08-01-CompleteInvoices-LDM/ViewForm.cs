using System;
using System.IO;
using System.Windows.Forms;

namespace CSC240_08_01_CompleteInvoices_LDM
{
    public partial class ViewForm : Form
    {
        const char DELIM = ',';
        const string FILENAME = Path.Combine(Application.StartupPath, "invoices.txt");
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);

        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                invoiceBox.Text = fields[0];
                nameBox.Text = fields[1];
                amountBox.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                label1.Text = "You have viewed\nall the records";
                viewButton.Enabled = false;
            }
        }
    }
}
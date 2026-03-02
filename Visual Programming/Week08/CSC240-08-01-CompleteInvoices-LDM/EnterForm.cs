using System;
using System.IO;
using System.Windows.Forms;

namespace CSC240_08_01_CompleteInvoices_LDM
{
    public partial class EnterForm : Form
    {
        const string DELIM = ",";
        const string FILENAME = Path.Combine(Application.StartupPath, "invoices.txt");
        int num;
        string name;
        double amount;
        static FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);

        public EnterForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(invoiceBox.Text);
            name = nameBox.Text;
            amount = Convert.ToDouble(amountBox.Text);
            writer.WriteLine(num + DELIM + name + DELIM + amount);
            invoiceBox.Clear();
            nameBox.Clear();
            amountBox.Clear();
        }

        private void EnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose handles closing
        }
    }
}
using System;
using System.IO;
using System.Windows.Forms;

namespace CSC240_08_01_CompleteInvoices_LDM
{
    public partial class EnterForm : Form
    {
        const string DELIM = ",";
        string FILENAME;
        int num;
        string name;
        double amount;
        static FileStream outFile;
        StreamWriter writer;

        public EnterForm()
        {
            InitializeComponent();
            FILENAME = GetInvoiceFilePath();
            outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(outFile);
        }

        private string GetInvoiceFilePath()
        {
            string path = Path.Combine(Application.StartupPath, "invoices.txt");
            try
            {
                string configPath = Path.Combine(Application.StartupPath, "App.config");
                if (File.Exists(configPath))
                {
                    var doc = new System.Xml.XmlDocument();
                    doc.Load(configPath);
                    var node = doc.SelectSingleNode("//appSettings/add[@key='InvoiceFilePath']");
                    if (node != null && node.Attributes["value"] != null)
                    {
                        string value = node.Attributes["value"].Value;
                        if (!string.IsNullOrEmpty(value))
                            path = value;
                    }
                }
            }
            catch
            {
                // ignore and use default
            }
            return path;
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
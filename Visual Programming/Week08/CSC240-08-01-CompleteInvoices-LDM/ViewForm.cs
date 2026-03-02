using System;
using System.IO;
using System.Windows.Forms;

namespace CSC240_08_01_CompleteInvoices_LDM
{
    public partial class ViewForm : Form
    {
        const char DELIM = ',';
        string FILENAME;
        string recordIn;
        string[] fields;
        static FileStream file;
        StreamReader reader;

        public ViewForm()
        {
            InitializeComponent();
            FILENAME = GetInvoiceFilePath();
            try
            {
                file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);
            }
            catch (Exception)
            {
                label1.Text = "Unable to open invoice file.";
                viewButton.Enabled = false;
            }
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
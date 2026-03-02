using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CSC240_08_02_ViewInvoices_LDM
{
    public partial class Form1 : Form
    {
        const char DELIM = ',';
        const string FILENAME = Path.Combine(Application.StartupPath, "invoices.txt");
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);

        private string invoiceFilePath;

        public Form1()
        {
            InitializeComponent();
            invoiceFilePath = GetInvoiceFilePath();
        }

        private string GetInvoiceFilePath()
        {
            string path = Path.Combine(Application.StartupPath, "invoices.txt");
            try
            {
                // Assume same config, but since separate project, perhaps hardcode or same logic
                string configPath = Path.Combine(Application.StartupPath, "App.config");
                if (File.Exists(configPath))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(configPath);
                    XmlNode node = doc.SelectSingleNode("//appSettings/add[@key='InvoiceFilePath']");
                    if (node != null && node.Attributes["value"] != null)
                    {
                        string value = node.Attributes["value"].Value;
                        if (!string.IsNullOrEmpty(value))
                        {
                            path = value;
                        }
                    }
                }
            }
            catch
            {
                // ignore
            }
            return path;
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            listBoxInvoices.Items.Clear();
            try
            {
                if (File.Exists(invoiceFilePath))
                {
                    string[] lines = File.ReadAllLines(invoiceFilePath);
                    foreach (string line in lines)
                    {
                        listBoxInvoices.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("Invoice file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoices: " + ex.Message);
            }
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
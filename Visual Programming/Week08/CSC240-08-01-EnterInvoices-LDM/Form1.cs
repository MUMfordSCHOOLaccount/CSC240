using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CSC240_08_01_EnterInvoices_LDM
{
    public partial class Form1 : Form
    {
        const string DELIM = ",";
        string FILENAME;
        int num;
        string name;
        double amount;
        static FileStream outFile;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
            FILENAME = GetInvoiceFilePath();
            // Create a new sequential invoice file so each run can create a new file (invoices.txt, invoices1.txt...)
            FILENAME = GetNextAvailableInvoiceFilePath(FILENAME);
            bool newFile = !File.Exists(FILENAME);
            outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(outFile);
            if (newFile)
            {
                try
                {
                    string indexPath = Path.Combine(Path.GetDirectoryName(FILENAME), "Index.txt");
                    File.AppendAllText(indexPath, Path.GetFileName(FILENAME) + System.Environment.NewLine);
                }
                catch
                {
                    // ignore index write errors
                }
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

        private string GetNextAvailableInvoiceFilePath(string configuredPath)
        {
            try
            {
                string dir = Path.GetDirectoryName(configuredPath);
                if (string.IsNullOrEmpty(dir)) dir = Application.StartupPath;
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                string baseName = Path.GetFileNameWithoutExtension(configuredPath);
                string ext = Path.GetExtension(configuredPath);
                string path = Path.Combine(dir, baseName + ext);
                int i = 1;
                while (File.Exists(path))
                {
                    path = Path.Combine(dir, baseName + i + ext);
                    i++;
                }
                return path;
            }
            catch
            {
                return configuredPath;
            }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            writer.Close();
            outFile.Close();
        }
    }
}
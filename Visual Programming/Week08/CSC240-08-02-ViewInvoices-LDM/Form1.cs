using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CSC240_08_02_ViewInvoices_LDM
{
    public partial class Form1 : Form
    {
        const char DELIM = ',';
        string FILENAME;
        string recordIn;
        string[] fields;
        static FileStream file;
        StreamReader reader;

        public Form1()
        {
            InitializeComponent();
            FILENAME = GetInvoiceFilePath();
            try
            {
                // If configured path points to a directory or is empty, try to use Index.txt to find latest file
                if (string.IsNullOrEmpty(FILENAME) || Directory.Exists(FILENAME))
                {
                    string dir = string.IsNullOrEmpty(FILENAME) ? Application.StartupPath : FILENAME;
                    string indexPath = Path.Combine(dir, "Index.txt");
                    if (File.Exists(indexPath))
                    {
                        var lines = File.ReadAllLines(indexPath);
                        // choose the last entry as the most recent
                        for (int i = lines.Length - 1; i >= 0; i--)
                        {
                            string candidate = Path.Combine(dir, lines[i]);
                            if (File.Exists(candidate))
                            {
                                FILENAME = candidate;
                                break;
                            }
                        }
                    }
                }

                file = new FileStream(FILENAME, FileMode.OpenOrCreate, FileAccess.Read);
                reader = new StreamReader(file);
                PopulateFileList();
            }
            catch (Exception)
            {
                label1.Text = "Unable to open invoice file.";
                viewButton.Enabled = false;
            }
        }

        private void PopulateFileList()
        {
            try
            {
                string dir = Path.GetDirectoryName(FILENAME);
                if (string.IsNullOrEmpty(dir)) dir = Application.StartupPath;
                string indexPath = Path.Combine(dir, "Index.txt");
                if (File.Exists(indexPath))
                {
                    var lines = File.ReadAllLines(indexPath);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string candidate = Path.Combine(dir, line.Trim());
                            if (File.Exists(candidate))
                            {
                                fileComboBox.Items.Add(line.Trim());
                            }
                        }
                    }
                    if (fileComboBox.Items.Count > 0)
                    {
                        fileComboBox.SelectedIndex = fileComboBox.Items.Count - 1; // select latest
                    }
                }
            }
            catch
            {
                // ignore populate errors
            }
        }

        private void FileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string dir = Path.GetDirectoryName(FILENAME);
                if (string.IsNullOrEmpty(dir)) dir = Application.StartupPath;
                string selected = fileComboBox.SelectedItem as string;
                if (string.IsNullOrEmpty(selected)) return;
                string path = Path.Combine(dir, selected);
                if (File.Exists(path))
                {
                    reader?.Close();
                    file?.Close();
                    file = new FileStream(path, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(file);
                }
            }
            catch
            {
                // ignore
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
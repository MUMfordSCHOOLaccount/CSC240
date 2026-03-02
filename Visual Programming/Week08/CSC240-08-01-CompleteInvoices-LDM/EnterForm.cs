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
            // Do not open the file until the user submits input so filename can be based on Last Name
            // Initialize next invoice number from index or existing files
            try
            {
                string idxPath = Path.Combine(Application.StartupPath, "index.txt");
                if (File.Exists(idxPath))
                {
                    // read last line to get last invoice number
                    string lastLine = null;
                    using (var sr = new StreamReader(new FileStream(idxPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                    {
                        while (!sr.EndOfStream)
                        {
                            lastLine = sr.ReadLine();
                        }
                    }

                    int lastNum;
                    if (!string.IsNullOrEmpty(lastLine) && int.TryParse(lastLine.Split(',')[0], out lastNum))
                    {
                        num = lastNum + 1;
                    }
                    else
                    {
                        num = 1;
                    }
                }
                else
                {
                    num = 1;
                }
                invoiceBox.Text = num.ToString();
            }
            catch { num = 1; invoiceBox.Text = "1"; }
        }

        private string BuildInvoiceFilePath(string lastName)
        {
            string folder = Application.StartupPath;

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
                        {
                            // If config points to a file, use its directory; if directory, use it directly
                            if (Directory.Exists(value))
                                folder = value;
                            else
                                folder = Path.GetDirectoryName(value) ?? folder;
                        }
                    }
                }
            }
            catch { }

            // sanitize lastName for filename
            var invalid = Path.GetInvalidFileNameChars();
            foreach (var c in invalid)
                lastName = lastName.Replace(c.ToString(), "");

            if (string.IsNullOrWhiteSpace(lastName))
                lastName = "invoices";

            string baseName = lastName;
            string candidate = Path.Combine(folder, baseName + ".txt");
            int i = 1;
            while (File.Exists(candidate))
            {
                candidate = Path.Combine(folder, baseName + i.ToString() + ".txt");
                i++;
            }

            return candidate;
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
            // Use the auto-generated invoice number
            if (!int.TryParse(invoiceBox.Text, out num))
            {
                MessageBox.Show("Invalid invoice number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            name = nameBox.Text ?? string.Empty;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a last name to name the invoice file.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate amount
            if (!double.TryParse(amountBox.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build a filename based on last name; if file exists, add a numeric suffix
            FILENAME = BuildInvoiceFilePath(name);

            try
            {
                using (var fs = new FileStream(FILENAME, FileMode.Append, FileAccess.Write))
                using (var w = new StreamWriter(fs))
                {
                    w.WriteLine(num + DELIM + name + DELIM + amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write invoice file: " + ex.Message, "IO error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // increment invoice number for next record and update UI and index
            num++;
            invoiceBox.Text = num.ToString();
            nameBox.Clear();
            amountBox.Clear();

            // Append to index: format "invoiceNumber,fileName,customerName"
            try
            {
                string idxPath = Path.Combine(Application.StartupPath, "index.txt");
                using (var idx = new FileStream(idxPath, FileMode.Append, FileAccess.Write))
                using (var iw = new StreamWriter(idx))
                {
                    iw.WriteLine((num - 1) + "," + Path.GetFileName(FILENAME) + "," + name);
                }
            }
            catch { }
        }

        private void EnterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close and dispose streams safely
            try
            {
                if (writer != null)
                {
                    writer.Close();
                    writer = null;
                }
            }
            catch { }

            try
            {
                if (outFile != null)
                {
                    outFile.Close();
                    outFile = null;
                }
            }
            catch { }
        }
    }
}
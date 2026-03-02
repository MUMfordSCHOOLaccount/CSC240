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
            // Create a new timestamped invoice file with zero-padded sequence if needed
            FILENAME = GetTimestampedInvoiceFilePath(FILENAME);
            bool newFile = !File.Exists(FILENAME);
            outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(outFile);
            if (newFile)
            {
                try
                {
                    string indexPath = Path.Combine(Path.GetDirectoryName(FILENAME), "Index.csv");
                    string line = string.Format("{0},{1}", Path.GetFileName(FILENAME), System.DateTime.UtcNow.ToString("o"));
                    File.AppendAllText(indexPath, line + System.Environment.NewLine);
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
                // Use zero-padded numeric sequence filenames: base_001.txt, base_002.txt, ...
                string baseName = Path.GetFileNameWithoutExtension(configuredPath);
                string ext = Path.GetExtension(configuredPath);
                // Find existing files matching base_###
                var files = Directory.GetFiles(dir, baseName + "_*" + ext);
                int maxSeq = 0;
                foreach (var f in files)
                {
                    var name = Path.GetFileNameWithoutExtension(f);
                    var parts = name.Split('_');
                    if (parts.Length > 1)
                    {
                        if (int.TryParse(parts[parts.Length - 1], out int s))
                        {
                            if (s > maxSeq) maxSeq = s;
                        }
                    }
                }
                int next = maxSeq + 1;
                string path = Path.Combine(dir, string.Format("{0}_{1:D3}{2}", baseName, next, ext));
                return path;
            }
            catch
            {
                return configuredPath;
            }
        }

        private string GetTimestampedInvoiceFilePath(string configuredPath)
        {
            // wrapper kept for clarity; uses updated GetNextAvailableInvoiceFilePath
            return GetNextAvailableInvoiceFilePath(configuredPath);
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
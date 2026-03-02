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
                // If configured path points to a directory, use invoices.txt inside it
                if (Directory.Exists(FILENAME))
                {
                    FILENAME = Path.Combine(FILENAME, "invoices.txt");
                }

                // If configured path is empty or doesn't point to a file, try to find latest via Index.txt
                if (string.IsNullOrEmpty(FILENAME) || !File.Exists(FILENAME))
                {
                    string dir = string.IsNullOrEmpty(FILENAME) ? Application.StartupPath : Path.GetDirectoryName(FILENAME);
                    string indexPath = Path.Combine(dir, "Index.txt");
                    if (File.Exists(indexPath))
                    {
                        var lines = File.ReadAllLines(indexPath);
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

                // Ensure parent directory exists
                var dirPath = Path.GetDirectoryName(FILENAME);
                if (string.IsNullOrEmpty(dirPath)) dirPath = Application.StartupPath;
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                // Ensure file exists
                bool created = false;
                if (!File.Exists(FILENAME))
                {
                    File.WriteAllText(FILENAME, string.Empty);
                    created = true;
                }

                // Register in Index.txt if new
                try
                {
                    if (created)
                    {
                        var indexPath = Path.Combine(dirPath, "Index.txt");
                        File.AppendAllText(indexPath, Path.GetFileName(FILENAME) + Environment.NewLine);
                    }
                }
                catch
                {
                    // ignore
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
                string indexPath = Path.Combine(dir, "Index.csv");

                // Ensure index exists; if not, create by scanning directory
                if (!File.Exists(indexPath))
                {
                    ScanAndBuildIndex(dir, indexPath);
                }

                if (File.Exists(indexPath))
                {
                    var lines = File.ReadAllLines(indexPath);
                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var parts = line.Split(','); // filename,timestamp
                        string fileName = parts[0].Trim();
                        string display = fileName;
                        if (parts.Length > 1) display += " (" + parts[1].Trim() + ")";
                        string candidate = Path.Combine(dir, fileName);
                        if (File.Exists(candidate))
                        {
                            fileComboBox.Items.Add(new ComboItem { FileName = fileName, Display = display });
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

        private void ScanAndBuildIndex(string dir, string indexPath)
        {
            try
            {
                var files = Directory.GetFiles(dir, "*.txt");
                using (var sw = new StreamWriter(indexPath, false))
                {
                    foreach (var f in files)
                    {
                        string name = Path.GetFileName(f);
                        string ts = File.GetCreationTimeUtc(f).ToString("o");
                        sw.WriteLine(string.Format("{0},{1}", name, ts));
                    }
                }
            }
            catch
            {
                // ignore
            }
        }

        private class ComboItem
        {
            public string FileName { get; set; }
            public string Display { get; set; }
            public override string ToString() { return Display; }
        }

        private void FileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string dir = Path.GetDirectoryName(FILENAME);
                if (string.IsNullOrEmpty(dir)) dir = Application.StartupPath;
                var item = fileComboBox.SelectedItem as ComboItem;
                if (item == null) return;
                string path = Path.Combine(dir, item.FileName);
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

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = fileComboBox.SelectedItem as ComboItem;
                if (item == null) return;
                string dir = Path.GetDirectoryName(FILENAME);
                if (string.IsNullOrEmpty(dir)) dir = Application.StartupPath;
                string path = Path.Combine(dir, item.FileName);
                if (!File.Exists(path)) return;

                string archiveDir = Path.Combine(dir, "Archive");
                if (!Directory.Exists(archiveDir)) Directory.CreateDirectory(archiveDir);
                string dest = Path.Combine(archiveDir, item.FileName);
                File.Move(path, dest);

                // Remove from Index.csv
                string indexPath = Path.Combine(dir, "Index.csv");
                if (File.Exists(indexPath))
                {
                    var lines = File.ReadAllLines(indexPath);
                    using (var sw = new StreamWriter(indexPath, false))
                    {
                        foreach (var line in lines)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;
                            var parts = line.Split(',');
                            if (parts.Length == 0) continue;
                            if (parts[0].Trim().Equals(item.FileName, System.StringComparison.OrdinalIgnoreCase)) continue;
                            sw.WriteLine(line);
                        }
                    }
                }

                // update UI
                fileComboBox.Items.Remove(item);
                if (fileComboBox.Items.Count > 0) fileComboBox.SelectedIndex = fileComboBox.Items.Count - 1;
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
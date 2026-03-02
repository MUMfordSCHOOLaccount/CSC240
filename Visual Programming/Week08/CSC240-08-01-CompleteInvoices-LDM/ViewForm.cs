using System;
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

        // list of invoice files from index
        string indexPath;

        public ViewForm()
        {
            InitializeComponent();
            indexPath = Path.Combine(Application.StartupPath, "index.txt");
            LoadIndex();
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null)
            {
                MessageBox.Show("Select a file first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = listBoxFiles.SelectedItem.ToString();
            var parts = sel.Split(',');
            if (parts.Length < 2) return;
            var fileName = parts[1];
            var fullPath = Path.Combine(Application.StartupPath, fileName);

            try
            {
                if (!File.Exists(fullPath))
                {
                    MessageBox.Show("File not found: " + fullPath, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var archiveDir = Path.Combine(Application.StartupPath, "archive");
                if (!Directory.Exists(archiveDir)) Directory.CreateDirectory(archiveDir);

                var dest = Path.Combine(archiveDir, fileName);
                int i = 1;
                var baseName = Path.GetFileNameWithoutExtension(fileName);
                var ext = Path.GetExtension(fileName);
                while (File.Exists(dest))
                {
                    dest = Path.Combine(archiveDir, baseName + i.ToString() + ext);
                    i++;
                }

                File.Move(fullPath, dest);

                // remove entry from index
                var lines = File.ReadAllLines(indexPath);
                using (var sw = new StreamWriter(indexPath, false))
                {
                    foreach (var l in lines)
                    {
                        if (!l.Contains("," + fileName + ","))
                        {
                            sw.WriteLine(l);
                        }
                    }
                }

                LoadIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error archiving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null)
            {
                MessageBox.Show("Select a file first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = listBoxFiles.SelectedItem.ToString();
            var parts = sel.Split(',');
            if (parts.Length < 2) return;
            var fileName = parts[1];
            var fullPath = Path.Combine(Application.StartupPath, fileName);

            var res = MessageBox.Show("Delete file " + fileName + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes) return;

            try
            {
                if (File.Exists(fullPath)) File.Delete(fullPath);
                // remove entry from index
                var lines = File.ReadAllLines(indexPath);
                using (var sw = new StreamWriter(indexPath, false))
                {
                    foreach (var l in lines)
                    {
                        if (!l.Contains("," + fileName + ","))
                        {
                            sw.WriteLine(l);
                        }
                    }
                }
                LoadIndex(); // Refresh the index after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting file: " + ex.Message, "IO error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadIndex()
        {
            try
            {
                if (!File.Exists(indexPath))
                {
                    label1.Text = "No index found.";
                    viewButton.Enabled = false;
                    return;
                }

                listBoxFiles.Items.Clear();
                using (var sr = new StreamReader(new FileStream(indexPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // index format: invoiceNumber,fileName,customerName
                        listBoxFiles.Items.Add(line);
                    }
                }
            }
            catch
            {
                label1.Text = "Unable to load index.";
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
            // When the user clicks View, open the selected file and show its first record
            if (listBoxFiles.SelectedItem == null)
            {
                MessageBox.Show("Select a file from the list first.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sel = listBoxFiles.SelectedItem.ToString();
            var parts = sel.Split(',');
            if (parts.Length < 2)
            {
                MessageBox.Show("Invalid index entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fileName = parts[1];
            var fullPath = Path.Combine(Application.StartupPath, fileName);
            if (!File.Exists(fullPath))
            {
                MessageBox.Show("Invoice file not found: " + fullPath, "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var fr = new StreamReader(fullPath))
                {
                    var line = fr.ReadLine();
                    if (line == null)
                    {
                        MessageBox.Show("File is empty.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var f = line.Split(DELIM);
                    if (f.Length >= 3)
                    {
                        invoiceBox.Text = f[0];
                        nameBox.Text = f[1];
                        amountBox.Text = f[2];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "IO error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
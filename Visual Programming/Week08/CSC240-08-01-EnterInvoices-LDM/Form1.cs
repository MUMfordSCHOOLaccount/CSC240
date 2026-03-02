using System;
using System;
using System.Configuration;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_08_01_EnterInvoices_LDM
{
    public partial class Form1 : Form
    {
        // delimiter used to separate fields in the file
        private const string delim = ",";

        // file path for stored invoices (configurable via App.config key "InvoiceFilePath")
        private string fileName;

        // variables for the current invoice being entered
        private int num;
        private string custName;
        private double amount;

        // file stream and writer for output
        private FileStream outFile;
        private StreamWriter writer;

        public Form1()
        {
            InitializeComponent();

            // determine file path: use App.config AppSettings["InvoiceFilePath"] if set, otherwise default to application folder
            try
            {
                string configuredPath = null;
                try
                {
                    var configPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
                    if (File.Exists(configPath))
                    {
                        var doc = new XmlDocument();
                        doc.Load(configPath);
                        var node = doc.SelectSingleNode("//appSettings/add[@key='InvoiceFilePath']");
                        if (node != null && node.Attributes != null)
                        {
                            configuredPath = node.Attributes["value"]?.Value;
                        }
                    }
                }
                catch
                {
                    configuredPath = null;
                }

                if (string.IsNullOrWhiteSpace(configuredPath))
                {
                    fileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "invoices.txt");
                }
                else
                {
                    fileName = configuredPath;
                }

                // ensure directory exists then open the output file
                var dir = System.IO.Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(dir))
                    System.IO.Directory.CreateDirectory(dir);

                // open file in append mode so existing records are preserved
                outFile = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile) { AutoFlush = true };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open invoice file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Controls (moved from designer)
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox invoiceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button enterButton;

        // Initialize the form controls (original designer code moved here)
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.invoiceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(132, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter invoice data";
            // invoiceLabel
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Location = new System.Drawing.Point(12, 40);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(82, 13);
            this.invoiceLabel.TabIndex = 1;
            this.invoiceLabel.Text = "Invoice number";
            // invoiceBox
            this.invoiceBox.Location = new System.Drawing.Point(120, 37);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(120, 20);
            this.invoiceBox.TabIndex = 2;
            // nameLabel
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Last name";
            // nameBox
            this.nameBox.Location = new System.Drawing.Point(120, 67);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(160, 20);
            this.nameBox.TabIndex = 4;
            // amountLabel
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 100);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount";
            // amountBox
            this.amountBox.Location = new System.Drawing.Point(120, 97);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(120, 20);
            this.amountBox.TabIndex = 6;
            // enterButton
            this.enterButton.Location = new System.Drawing.Point(120, 130);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 30);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "Enter record";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Invoice Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            // read values from text boxes, write to file, and clear boxes
            num = Convert.ToInt32(invoiceBox.Text);
            custName = nameBox.Text;
            amount = Convert.ToDouble(amountBox.Text);

            if (writer != null)
                writer.WriteLine(num + delim + custName + delim + amount);

            invoiceBox.Clear();
            nameBox.Clear();
            amountBox.Clear();
            invoiceBox.Focus();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close writer and outFile when form is closing
            try
            {
                writer?.Flush();
                writer?.Close();
                outFile?.Close();
            }
            catch
            {
                // ignore
            }
        }
    }
}

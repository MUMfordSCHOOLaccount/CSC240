using System;
using System.IO;
using System.Windows.Forms;

namespace CSC240_08_02_ViewInvoices_LDM
{
    public partial class Form1 : Form
    {
        private const char delim = ',';
        private const string fileName = @"D:\SCHOOL\SCHOOL\GitHubFolder\CSC-240 Visual Programming\Git\CSC240\Visual Programming\Week08\CsharpInvoices\invoices.txt";

        private string recordIn;
        private string[] fields;

        private static FileStream file;
        private static StreamReader reader;

        private System.ComponentModel.IContainer components = null;

        private Label titleLabel;
        private Label invoiceLabel;
        private Label nameLabel;
        private Label amountLabel;
        private TextBox invoiceBox;
        private TextBox nameBox;
        private TextBox amountBox;
        private Button viewButton;

        public Form1()
        {
            InitializeComponent();

            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open invoice file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (viewButton != null)
                    viewButton.Enabled = false;
            }
        }

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.invoiceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Click the button to view records";

            // invoiceLabel
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Location = new System.Drawing.Point(12, 50);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(43, 13);
            this.invoiceLabel.TabIndex = 1;
            this.invoiceLabel.Text = "Invoice";

            // invoiceBox
            this.invoiceBox.Location = new System.Drawing.Point(80, 47);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(120, 20);
            this.invoiceBox.TabIndex = 2;

            // nameLabel
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";

            // nameBox
            this.nameBox.Location = new System.Drawing.Point(80, 77);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 20);
            this.nameBox.TabIndex = 4;

            // amountLabel
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 110);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount";

            // amountBox
            this.amountBox.Location = new System.Drawing.Point(80, 107);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(120, 20);
            this.amountBox.TabIndex = 6;

            // viewButton
            this.viewButton.Location = new System.Drawing.Point(320, 47);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(100, 30);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "View records";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 160);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Invoice Data";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                fields = recordIn.Split(delim);

                invoiceBox.Text = fields[0];
                nameBox.Text = fields[1];
                amountBox.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                titleLabel.Text = "You have viewed\nall the records";
                viewButton.Enabled = false;
            }
        }

        protected override void Dispose(bool disposing)
        {
            // close reader and file
            try
            {
                reader?.Close();
                file?.Close();
            }
            catch { }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
using System;
using System.Windows.Forms;

namespace CSC240_08_01_CompleteInvoices_LDM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm();
            enterForm.ShowDialog();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
        }
    }
}
using System;
using System.Windows.Forms;

namespace CSC240_08_01_CompleteInvoices_LDM
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
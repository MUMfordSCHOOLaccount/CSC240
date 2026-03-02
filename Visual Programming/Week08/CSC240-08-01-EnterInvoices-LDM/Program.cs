using System;
using System.Windows.Forms;

namespace CSC240_08_01_EnterInvoices_LDM
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
using System;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_LDM
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarSelectionForm());
        }
    }
}
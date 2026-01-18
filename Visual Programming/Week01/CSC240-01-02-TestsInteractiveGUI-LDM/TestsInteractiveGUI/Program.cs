using System;
using System.Windows.Forms;

namespace CSC240_01_02_TestsInteractiveGUI_LDM
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

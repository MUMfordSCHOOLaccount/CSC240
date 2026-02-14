using System;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_LDM;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarSelectionForm());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error starting application:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}", 
                "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }    
}
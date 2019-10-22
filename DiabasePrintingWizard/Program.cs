using System;
using System.Windows.Forms;

namespace DiabasePrintingWizard
{
   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string filename = null;
            bool debug = false;

            // If we have an argument expect it to be the filename
            if (args.Length == 1)
            {
                if (args[0] == "/debug")
                {
                    debug = true;
                }
                else
                {
                    filename = args[0].Replace('/', '\\');
                    if (!PostProcess.IPCHelper.FileExists(filename))
                    {
                        filename = null;
                        Console.WriteLine("Error: File not found");
                    }
                    else if (PostProcess.IPCHelper.SendToPipe(filename))
                    {
                        return;
                    }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(filename, debug));
        }
    }
}

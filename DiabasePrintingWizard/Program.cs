using System;
using System.IO;
using System.IO.Pipes;
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

            // If we have an argument expect it to be the filename
            if (args.Length == 1)
            {
                filename = args[0].Replace('/', '\\');
                if (!File.Exists(filename))
                {
                    filename = null;
                    Console.WriteLine("Error: File not found");
                }
                else
                {
                    Console.Write("Trying to pass on file ");
                    Console.WriteLine(filename);

                    NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "Diabase.PostProcessor", PipeDirection.Out);
                    try
                    {
                        pipeClient.Connect(100);
                        StreamString ss = new StreamString(pipeClient);
                        ss.WriteString(filename);
                        pipeClient.Close();

                        Console.WriteLine("Done!");
                        return;
                    }
                    catch (Exception e)
                    {
                        Console.Write("Error: ");
                        Console.WriteLine(e);
                    }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain(filename));
        }
    }
}

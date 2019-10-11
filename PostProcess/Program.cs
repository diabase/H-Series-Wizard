using System;
using System.IO;

namespace PostProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Error: Bad number of arguments");
                Console.WriteLine("Required invocation: PostProcess.exe <GCodeFile>");
            }
            else
            {
                string filename = args[0].Replace('/', '\\');
                if (!IPCHelper.FileExists(filename))
                {
                    Console.WriteLine("Error: File not found");
                    return;
                }
                else if (IPCHelper.SendToPipe(filename))
                {
                    return;
                }

                // Try to start the Wizard in this case
                System.Diagnostics.Process wizard = new System.Diagnostics.Process();
                wizard.StartInfo.FileName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "DiabasePrintingWizard.exe");
                wizard.StartInfo.Arguments = filename;
                wizard.StartInfo.UseShellExecute = false;
                wizard.StartInfo.RedirectStandardOutput = true;
                wizard.Start();
            }
        }
    }
}
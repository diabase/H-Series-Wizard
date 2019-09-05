using System;
using System.IO;
using System.IO.Pipes;

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
                if (!File.Exists(filename))
                {
                    Console.WriteLine("Error: File not found");
                    return;
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

                // Try to start the Wizard in this case
                System.Diagnostics.Process wizard = new System.Diagnostics.Process();
                wizard.StartInfo.FileName = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "DiabasePrintingWizard.exe");
                wizard.StartInfo.Arguments = filename;
                wizard.StartInfo.UseShellExecute = false;
                wizard.StartInfo.RedirectStandardOutput = true;
                wizard.Start();
                string output = wizard.StandardOutput.ReadToEnd(); //The output result
                wizard.WaitForExit();
            }
        }
    }
}
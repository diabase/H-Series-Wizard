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
                    }
                    catch (Exception e)
                    {
                        Console.Write("Error: ");
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}
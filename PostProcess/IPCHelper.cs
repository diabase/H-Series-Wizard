using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

namespace PostProcess
{   public static class IPCHelper
    {
        public static bool FileExists(string filename)
        {
            // Check if it's there (will be the case most of the times)
            if (File.Exists(filename))
            {
                return true;
            }

            // Wait 500ms if it does not exist (yet?)
            Thread.Sleep(500);

            // Check again
            if (File.Exists(filename))
            {
                return true;
            }
            // Wait another 500ms if it does not exist (yet?)
            Thread.Sleep(500);

            // With the 3rd try it will be what it is then
            return File.Exists(filename);
        }

        public static bool SendToPipe(string filename)
        {
            Console.WriteLine($"Trying to pass on file {filename}");

            NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "Diabase.PostProcessor", PipeDirection.Out);
            try
            {
                pipeClient.Connect(100);
                StreamString ss = new StreamString(pipeClient);
                ss.WriteString(filename);
                pipeClient.Close();

                Console.WriteLine("Done!");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return false;
        }
    }

}

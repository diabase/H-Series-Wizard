using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DiabasePrintingWizard
{
    static class PostProcessor
    {
        public static readonly int StepsPerAdditiveFile = 3;
        public static readonly int StepsPerSubstractiveFile = 1;   // substractive files are not processed (yet)

        private static int totalProgressValue;

        public static async Task CreateTask(FileStream topAdditiveFile, FileStream topSubstractiveFile,
            FileStream bottomAdditiveFile, FileStream bottomSubstractiveFile,
            FileStream outFile, SettingsContainer settings, IList<OverrideRule> rules, Duet.MachineInfo machine,
            IProgress<string> textProgress, IProgress<int> progress, IProgress<int> maxProgress, IProgress<int>totalProgress, bool debug)
        {
            Exception ex = null;
            try
            {
                totalProgressValue = 0;

                // Additive Top
                GCodeProcessor topAdditiveGCode = new GCodeProcessor(topAdditiveFile, settings, rules, machine, progress, maxProgress);
                textProgress.Report("Preprocessing file for additive manufacturing on the top side...");
                await topAdditiveGCode.PreProcess();
                IncreaseTotalProgress(totalProgress);

                textProgress.Report("Postprocessing file for additive manufacturing on the top side...");
                topAdditiveGCode.PostProcess();
                IncreaseTotalProgress(totalProgress);

                // Hybrid Top is not processed

                // Additive Bottom
                GCodeProcessor bottomAdditiveGCode = null;
                if (bottomAdditiveFile != null)
                {
                    bottomAdditiveGCode = new GCodeProcessor(bottomAdditiveFile, settings, rules, machine, progress, maxProgress);
                    textProgress.Report("Preprocessing file for additive manufacturing on the bottom side...");
                    await bottomAdditiveGCode.PreProcess();
                    IncreaseTotalProgress(totalProgress);

                    textProgress.Report("Postprocessing file for additive manufacturing on the bottom side...");
                    bottomAdditiveGCode.PostProcess();
                    IncreaseTotalProgress(totalProgress);
                }

                // Hybrid Bottom is not processed

                // Join files together
                textProgress.Report("Combining results...");
                WriteFileInfo(outFile, "Additive manufacturing on the top side", topAdditiveFile);
                await topAdditiveGCode.WriteToFile(outFile, debug);
                IncreaseTotalProgress(totalProgress);
                if (topSubstractiveFile != null)
                {
                    WriteFileInfo(outFile, "Substractive manufacturing on the top side", topSubstractiveFile);
                    await topSubstractiveFile.CopyToAsync(outFile);
                    IncreaseTotalProgress(totalProgress);
                }
                if (bottomAdditiveFile != null)
                {
                    // TODO: Add code to turn around A-axis for two-sided prints?
                    WriteFileInfo(outFile, "Additive manufacturing on the bottom side", bottomAdditiveFile);
                    await bottomAdditiveGCode.WriteToFile(outFile, debug);
                    IncreaseTotalProgress(totalProgress);
                }
                if (bottomSubstractiveFile != null)
                {
                    WriteFileInfo(outFile, "Substractive manufacturing on the bottom side", bottomSubstractiveFile);
                    await bottomSubstractiveFile.CopyToAsync(outFile);
                    IncreaseTotalProgress(totalProgress);
                }
                textProgress.Report("Done!");
            }
            catch (Exception e)
            {
                ex = e;
            }

            topAdditiveFile.Close();
            topSubstractiveFile?.Close();
            bottomAdditiveFile?.Close();
            bottomSubstractiveFile?.Close();
            outFile.Close();

            if (ex != null)
            {
                throw new AggregateException(ex);
            }
        }

        private static void IncreaseTotalProgress(IProgress<int> progress)
        {
            progress.Report(++totalProgressValue);
        }

        private static void WriteFileInfo(FileStream outFile, string info, FileStream stream)
        {
            StreamWriter sw = new StreamWriter(outFile);
            sw.WriteLine(";");
            sw.WriteLine("; -- " + info + " --");
            sw.WriteLine("; Source File: " + stream.Name);

            sw.Flush();
        }
    }
}

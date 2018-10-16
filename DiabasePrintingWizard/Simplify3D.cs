using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DiabasePrintingWizard
{
    static class Simplify3D
    {
        // Returns the executable path of Simplify3D or null if it was not found
        public static string ExecutablePath
        {
            get
            {
                try
                {
                    // Try to get the executable path on 32-bit systems
                    RegistryKey hklm32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                    RegistryKey key32 = hklm32.OpenSubKey(@"SOFTWARE\Simplify3D\Simplify3D Software");
                    if (key32 != null)
                    {
                        string dir32 = key32.GetValue("Location").ToString();
                        string exe32 = Path.Combine(dir32, "Simplify3D.exe");
                        key32.Close();

                        return File.Exists(exe32) ? exe32 : null;
                    }

                    // If that did not work, try to get it on 64-bit systems
                    RegistryKey hklm64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                    RegistryKey key64 = hklm64.OpenSubKey(@"SOFTWARE\Simplify3D\Simplify3D Software");
                    string dir64 = key64.GetValue("Location").ToString();
                    string exe64 = Path.Combine(dir64, "Simplify3D.exe");
                    key64.Close();

                    return File.Exists(exe64) ? exe64 : null;
                }
                catch
                {
                    // Something went wrong
                    return null;
                }
            }
        }

        // Returns the path to the current Simplify3D factory file
        public static string SavedStateFile
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Simplify3D\S3D-Software\SavedState.factory");
            }
        }

        // Returns the saved Simplify3D factory file or null if not found
        public static string SavedStateFileBackup
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Simplify3D\S3D-Software\SavedState.factory.bak");
            }
        }

        public static void BackupSavedState()
        {
            string stateFile = SavedStateFile;
            string bakFile = SavedStateFileBackup;

            // Delete existing backup
            if (File.Exists(stateFile))
            {
                if (File.Exists(bakFile))
                {
                    File.Delete(bakFile);
                }
            }

            // Move current file to backup
            File.Move(stateFile, bakFile);
        }

        public static void RestoreSavedState()
        {
            // Make sure all the Simplify3D processes are closed
            while (Process.GetProcessesByName("Simplify3D").Length > 0)
            {
                DialogResult result = MessageBox.Show("You should close all Simplify3D instances before you can continue continue. What would you like to do?", Application.ProductName, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                if (result == DialogResult.Abort)
                    return;
                if (result == DialogResult.Ignore)
                    break;
            }

            // Delete current file and move backup back into place
            File.Delete(SavedStateFile);
            File.Move(SavedStateFileBackup, SavedStateFile);
        }
    }
}

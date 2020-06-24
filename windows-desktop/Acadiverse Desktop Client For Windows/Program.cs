using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("Crc32C.NET.dll") &&
                !File.Exists("DnsClient.dll") &&
                !File.Exists("libzstd.dll") &&
                !File.Exists("MagiZile.Acadiverse.dll") &&
                !File.Exists("MagiZile.AddOns.dll") &&
                !File.Exists("MagiZile.CustomUI.dll") &&
                !File.Exists("MagiZile.UserInteractions.Data.dll") &&
                !File.Exists("MagiZile.UserInteractions.ParentalControls.dll") &&
                !File.Exists("MagiZile.UtilityComponents,dll") &&
                !File.Exists("Microsoft.WindowsAPICodePack.dll") &&
                !File.Exists("Microsoft.WindowsAPICodePack.Shell.dll") &&
                !File.Exists("Microsoft.WindowsAPICodePack.ShellExtensions.dll") &&
                !File.Exists("mongocrypt.dll") &&
                !File.Exists("MongoDB.Bson.dll") &&
                !File.Exists("MongoDB.Driver.Core.dll") &&
                !File.Exists("MongoDB.Driver.dll") &&
                !File.Exists("MongoDB.Libmongocrypt.dll") &&
                !File.Exists("SharpCompress.dll") &&
                !File.Exists("Snappy.NET.sll") &&
                !File.Exists("snappy32.dll") &&
                !File.Exists("snappy64.dll") &&
                !File.Exists("System.Buffers.dll"))
            {
                MessageBox.Show("The application could not be run because one or more required files are missing. Please reinstall the program to fix the problem.", "Acadiverse Desktop Client for Windows", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmAcadiverseDesktopClient());
            }
        }
    }
}

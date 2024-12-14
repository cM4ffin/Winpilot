﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatynosyNue
{
    internal static class Program
    {

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        /// <summary>
        /// Retrieves the version of Bloatynosy
        /// </summary>
        /// <returns>The application version in the format "major.minor.build"</returns>
        public static string GetAppVersion()
        {
            // Get the version of the current executing assembly
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            // Return the version in the format "major.minor.build"
            return $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
        }

    }
}
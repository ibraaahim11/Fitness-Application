using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Licensing;

namespace FitnessApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmVCf0x0QHxbf1x1ZFNMYlpbQHBPMyBoS35RckRhW3lednFXQmZYUExx");
            Application.Run(new AdminUI("admin2", "password122"));
        }
    }
}

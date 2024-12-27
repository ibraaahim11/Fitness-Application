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
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmVCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH1cdnRRQmheV0B1Wkc=");
            // Application.Run(new Academies("FlexFitAcademy", 5));
            //Application.Run(new Coach());
            //Application.Run(new AcademiesViewSessions("ZenYogaAcademy", 1,"academy"));
            Application.Run(new Login());
        }
    }
}

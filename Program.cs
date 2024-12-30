using Syncfusion.Licensing;
using System;
using System.Windows.Forms;

namespace FitnessApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmVCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH1cdnRRQmheV0B1Wkc=");
            //Application.Run(new Academies("FlexFitAcademy", 5));
            //Application.Run(new Academies("KickFitAcademy", 1));
            // Application.Run(new AcademiesViewSessions("ZenYogaAcademy", 1,"academy"));
            //Application.Run(new MemberViewMealPlans("alice_johnson", 1));
            // Application.Run(new AcademiesViewSessions("alice_johnson", 1, "member"));
            Application.Run(new Login());
        }
    }
}
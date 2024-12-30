using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class Academies : SfForm
    {
        // Controller obj
        private Controller controller;

        // Forms to open
        private AcademiesProfile ProfileForm;

        private AcademiesPostSession PostSessionForm;
        private AcademiesViewSessions ViewSessionsForm;
        private AcademiesOverallStats OverallStatsForm;

        private int ID;

        private string Username;
        private string Name;
        Login BaseLoginForm;

        public Academies(string Username, int ID, Login b)
        {
            InitializeComponent();
            // Initializing controller
            controller = new Controller();
            this.Username = Username;
            this.ID = ID;
            LoadAcademyInfo();
            ConfigureMessageBoxAdv();
            BaseLoginForm = b;
        }

        public void UpdateData(string NewUsername)
        {
            Username = NewUsername;
            LoadAcademyInfo();
        }

        private void LoadAcademyInfo()
        {
            // For now username is set since there is no login.
            ID = controller.GetAcademyID(Username);
            Name = controller.GetAcademyName(ID);
            labelWelcomeAcademy.Text = $"Welcome, {Name}";
        }

        private void Academies_Load(object sender, EventArgs e)
        {
            // Sets the back color and fore color of the title bar.
            this.Style.TitleBar.BackColor = Color.LightCoral;
            this.Style.TitleBar.ForeColor = Color.White;

            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;

            this.Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

            this.Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;
        }

        private void buttonViewProfile_Click(object sender, EventArgs e)
        {
            // We will give the profile form access to this form.. in order to update data if needed.
            ProfileForm = new AcademiesProfile(ID, Username, this);

            ProfileForm.Show();
        }

        private void buttonPostSession_Click(object sender, EventArgs e)
        {
            PostSessionForm = new AcademiesPostSession(Username, ID);
            PostSessionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSessionsForm = new AcademiesViewSessions(Username, ID, "academy");
            ViewSessionsForm.Show();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonOverallStats_Click(object sender, EventArgs e)
        {
            int numSessions = controller.GetNumberOfSessions(ID);
            int numTotalMembers = controller.GetTotalMembersAttendedAcademy(ID);

            if (numSessions <= 0)
            {
                MessageBoxAdv.Show("You have no sessions posted.", "No Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numTotalMembers <= 0)
            {
                MessageBoxAdv.Show("No members have attended your sessions.", "No Members.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OverallStatsForm = new AcademiesOverallStats(Username, ID);
                OverallStatsForm.Show();
            }
        }

        public static void ConfigureMessageBoxAdv()
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            var metroColorTable = MessageBoxAdv.MetroColorTable;
            metroColorTable.BackColor = Color.White;
            metroColorTable.ForeColor = Color.Black;
            metroColorTable.BorderColor = Color.IndianRed;
            metroColorTable.CaptionBarColor = Color.LightCoral;
            metroColorTable.CaptionForeColor = Color.White;
            metroColorTable.OKButtonBackColor = Color.LightCoral;
            metroColorTable.YesButtonBackColor = Color.LightCoral;
            metroColorTable.NoButtonBackColor = Color.LightCoral;

            MessageBoxAdv.MetroColorTable = metroColorTable;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            BaseLoginForm.refreshlogin();
            Close();
        }
    }
}
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class AdminUI : SfForm
    {
        private string Username;
        private string Password;
        Login BasicLoginForm;

        public AdminUI(string username, string password, Login b)
        {
            this.Username = username;
            this.Password = password;
            InitializeComponent();
            this.Text = "Admin Dashboard";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;
            BasicLoginForm = b;

            AdminUsername.Text = username;
        }

        private void ToCoachesAndMembers_Click(object sender, EventArgs e)
        {
            Form F = new CoachMemManaging();
            F.Show();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            ToCoachesAndMembers.BackColor = Color.DarkGreen;
            EditProfile.BackColor = Color.DarkGreen;
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            Form F = new AdminProfile(Username, Password);
            F.Show();
        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            Form F = new AddAdmin();
            F.Show();
        }

        private void ManageBadges_Click(object sender, EventArgs e)
        {
            Form F = new ManageBadges();
            F.Show();
        }

        private void DailyHabits_Click(object sender, EventArgs e)
        {
            Form F = new viewDailyHabit();
            F.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            BasicLoginForm.refreshlogin();
            Close();
        }

        private void ManageAcademy_Click(object sender, EventArgs e)
        {
            Form F = new ManageAcademy();
            F.Show();
        }
    }
}
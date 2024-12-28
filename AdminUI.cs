using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Syncfusion.WinForms.Controls;

namespace FitnessApplication
{
    public partial class AdminUI : SfForm
    {
        private string Username;
        private string Password;
        public AdminUI(string username, string password)
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
    }
}

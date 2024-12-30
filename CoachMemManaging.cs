using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class CoachMemManaging : SfForm
    {
        public CoachMemManaging()
        {
            InitializeComponent();
            this.Text = "Managing Coaches And Members";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;
        }

        private void ManageCoachRequests_Click(object sender, EventArgs e)
        {
            Form F = new ManageCoachReq();
            F.Show();
        }

        private void ManageCoaches_Click(object sender, EventArgs e)
        {
            Form F = new ManageCoach();
            F.Show();
        }

        private void CoachMemberOverview_Click(object sender, EventArgs e)
        {
            Form F = new CoachMemberOverview();
            F.Show();
        }

        private void ViewFeedback_Click(object sender, EventArgs e)
        {
            Form F = new ViewFeedbacks();
            F.Show();
        }
    }
}
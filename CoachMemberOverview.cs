using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class CoachMemberOverview : SfForm
    {
        private Controller controllerobj = new Controller();

        public CoachMemberOverview()
        {
            InitializeComponent();
            this.Text = "Coach And Member Overview";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            CoachesRankings.DataSource = controllerobj.getCoachesRankings();

            CoachIDCBox.DisplayMember = "CoachID";
            CoachIDCBox.ValueMember = "CoachID";
            CoachIDCBox.DataSource = controllerobj.getCoachesRankings();
            CoachIDCBox.SelectedIndex = 0;

            CoachMembers.DataSource = controllerobj.getAllmembersOfCoach(Convert.ToInt16(CoachIDCBox.SelectedValue));
        }

        private void CoachIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedCoach = Convert.ToInt16(CoachIDCBox.SelectedValue);
            System.Data.DataRow dr = controllerobj.getCoachdetails(SelectedCoach);
            if (dr == null)
            {
                Fname.Text = "";
                Lname.Text = "";
            }
            else
            {
                Fname.Text = dr["Fname"].ToString();
                Lname.Text = dr["Lname"].ToString();
            }
            CoachMembers.DataSource = controllerobj.getAllmembersOfCoach(SelectedCoach);
        }
    }
}
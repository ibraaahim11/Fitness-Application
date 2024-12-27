using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.ListView.Enums;
using Syncfusion.WinForms.ListView;

namespace FitnessApplication
{
    public partial class ManageCoachReq : SfForm
    {
        Controller controllerobj = new Controller();
        public ManageCoachReq()
        {
            InitializeComponent();

            this.Text = "New Coach Requests";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            NonAcceptedCoaches.DataSource = controllerobj.GetNonAcceptedCoachesData();

            CoachIDCBox.DisplayMember = "CoachID";
            CoachIDCBox.ValueMember = "CoachID";
            CoachIDCBox.DataSource = controllerobj.GetNonAcceptedCoachesData();
            CoachIDCBox.SelectedIndex = 0;

        }

        private void AcceptSelCoach_Click(object sender, EventArgs e)
        {
            if (CoachIDCBox.SelectedValue == null)
            {
                MessageBox.Show("No Coaches to Accept");
            }
            else
            {
                int Coachid = Convert.ToInt16(CoachIDCBox.SelectedValue);
                if (controllerobj.AcceptCoach(Coachid) == 0)
                    MessageBox.Show("Couldn't Accept Coach");
                else
                    MessageBox.Show("Coach Accepted successfully");
                NonAcceptedCoaches.DataSource = controllerobj.GetNonAcceptedCoachesData();
                NonAcceptedCoaches.Refresh();
                CoachIDCBox.DataSource = controllerobj.GetNonAcceptedCoachesData();
                CoachIDCBox.Refresh();
                if (controllerobj.GetNonAcceptedCoachesData() != null)
                {
                    CoachIDCBox.SelectedItem = controllerobj.GetNonAcceptedCoachesData().Rows[0];
                }
                else
                {
                    CoachIDCBox.SelectedValue = null;
                    Firstname.Text = "";
                    Lastname.Text = "";
                    Certificate.Text = "";
                }
            }
        }

        private void RejectSelCoach_Click(object sender, EventArgs e)
        {
            if (CoachIDCBox.SelectedValue == null)
            {
                MessageBox.Show("No Coaches to reject");
            }
            else
            {
                int Coachid = Convert.ToInt16(CoachIDCBox.SelectedValue);
                if (controllerobj.RejectCoach(Coachid) == 0)
                    MessageBox.Show("Couldn't Reject Coach");
                else
                    MessageBox.Show("Coach Rejected successfully");
                NonAcceptedCoaches.DataSource = controllerobj.GetNonAcceptedCoachesData();
                NonAcceptedCoaches.Refresh();
                CoachIDCBox.DataSource = controllerobj.GetNonAcceptedCoachesData();
                CoachIDCBox.Refresh();
                if (controllerobj.GetNonAcceptedCoachesData() != null)
                {
                    CoachIDCBox.SelectedItem = controllerobj.GetNonAcceptedCoachesData().Rows[0];
                }
                else
                {
                    CoachIDCBox.SelectedValue = null;
                    Firstname.Text = "";
                    Lastname.Text = "";
                    Certificate.Text = "";
                }
            }
        }

        private void CoachIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedCoachID = Convert.ToInt32(CoachIDCBox.SelectedValue);
            DataRow coachdata = controllerobj.getCoachdetails(SelectedCoachID);
            if (coachdata == null)
            {
                Firstname.Text = "";
                Lastname.Text = "";
                Certificate.Text = "";
            }
            else
            {
                string fname = coachdata["Fname"].ToString();
                string lname = coachdata["Lname"].ToString();
                string certificate = coachdata["CertificateTitle"].ToString();

                Firstname.Text = fname;
                Lastname.Text = lname;
                Certificate.Text = certificate;

            }
        }
    }
}

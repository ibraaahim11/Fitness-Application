using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using Syncfusion.WinForms.Controls;
namespace FitnessApplication
{
    public partial class ManageAcademy : SfForm
    {
        Controller controllerobj = new Controller();    
        public ManageAcademy()
        {
            InitializeComponent();


            this.Text = "New Academy Requests";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;


            NonAcceptedAcademy.DataSource = controllerobj.GetNonAcceptedAcademies();

            AcademyIDCBox.DisplayMember = "AcademyID";
            AcademyIDCBox.ValueMember = "AcademyID";
            AcademyIDCBox.DataSource = controllerobj.GetNonAcceptedAcademies();
            AcademyIDCBox.SelectedIndex = 0;
        }

        private void AcceptSelAcademy_Click(object sender, EventArgs e)
        {
            if (AcademyIDCBox.SelectedValue == null)
            {
                MessageBox.Show("No Academy to Accept");
            }
            else
            {
                int Academyid = Convert.ToInt16(AcademyIDCBox.SelectedValue);
                if (controllerobj.AcceptAcademy(Academyid) == 0)
                    MessageBox.Show("Couldn't Accept Academy");
                else
                    MessageBox.Show("Academy Accepted successfully");

                NonAcceptedAcademy.DataSource = controllerobj.GetNonAcceptedAcademies();
                NonAcceptedAcademy.Refresh();
                AcademyIDCBox.DataSource = controllerobj.GetNonAcceptedAcademies();
                AcademyIDCBox.Refresh();
                if (controllerobj.GetNonAcceptedAcademies() != null)
                {
                    AcademyIDCBox.SelectedItem = controllerobj.GetNonAcceptedAcademies().Rows[0];
                }
                else
                {
                    AcademyIDCBox.SelectedValue = null;
                    Firstname.Text = "";
                    Certificate.Text = "";
                }
            }
        }

        private void RejectSelAcademy_Click(object sender, EventArgs e)
        {
            if (AcademyIDCBox.SelectedValue == null)
            {
                MessageBox.Show("No Academies to reject");
            }
            else
            {
                int Academyid = Convert.ToInt16(AcademyIDCBox.SelectedValue);
                if (controllerobj.RejectAcademy(Academyid) == 0)
                    MessageBox.Show("Couldn't Reject Academy");
                else
                    MessageBox.Show("Academy Rejected successfully");
                NonAcceptedAcademy.DataSource = controllerobj.GetNonAcceptedAcademies();
                NonAcceptedAcademy.Refresh();
                AcademyIDCBox.DataSource = controllerobj.GetNonAcceptedAcademies();
                AcademyIDCBox.Refresh();
                if (controllerobj.GetNonAcceptedAcademies() != null)
                {
                    AcademyIDCBox.SelectedItem = controllerobj.GetNonAcceptedAcademies().Rows[0];
                }
                else
                {
                    AcademyIDCBox.SelectedValue = null;
                    Firstname.Text = "";
                    Certificate.Text = "";
                }
            }
        }

        private void AcademyIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedAcademyID = Convert.ToInt32(AcademyIDCBox.SelectedValue);
            DataRow Academydata = controllerobj.getAcademyDetails(SelectedAcademyID);
            if (Academydata == null)
            {
                Firstname.Text = "";
                Certificate.Text = "";
            }
            else
            {
                string fname = Academydata["Name"].ToString();
                string certificate = Academydata["CertificateTitle"].ToString();

                Firstname.Text = fname;
                Certificate.Text = certificate;
            }
        }
    }
}

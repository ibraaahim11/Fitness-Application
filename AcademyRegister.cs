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
    public partial class AcademyRegister : SfForm
    {
        Controller controllerobj = new Controller();
        public AcademyRegister()
        {
            InitializeComponent();

            this.Text = "Academy Signup";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkBlue;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkBlue;
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            if (UsernameTBox.Text == "" || NameTB.Text == "" || PasswordTB.Text == "" || Description.Text == "" || AreaofExpertise.Text == "" || CertificateTitle.Text == "" || certificatedateofissueTB.Value.ToString() == "" || CertificateEDTB.Value.ToString() == "" || CertificateIssuingBody.Text == "")
                EmptyAlert.Visible = true;
            else
            {
                EmptyAlert.Visible = false;
                if (controllerobj.CheckifUsernameExist(UsernameTBox.Text) != 0)
                    MessageBox.Show("Username Already exist");
                else
                {
                    controllerobj.AddUser(UsernameTBox.Text, PasswordTB.Text, "academy");
                    if (controllerobj.AddAcademy(UsernameTBox.Text, NameTB.Text, Description.Text, AreaofExpertise.Text, CertificateTitle.Text, certificatedateofissueTB.Value.ToString(), CertificateEDTB.Value.ToString(), CertificateIssuingBody.Text) == 0)
                        MessageBox.Show("Couldn't insert academy");
                    else
                        MessageBox.Show("You have signedup wait for our team to review your profile before logging in! ");
                }
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked == true)
                PasswordTB.PasswordChar = '\0';
            else
                PasswordTB.PasswordChar = '*';
        }
    }
}

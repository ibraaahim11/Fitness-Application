using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class CoachSignup : SfForm
    {
        private Controller controllerobj = new Controller();

        public CoachSignup()
        {
            InitializeComponent();

            this.Text = "Coach Signup";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkBlue;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkBlue;
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked == true)
                PasswordTB.PasswordChar = '\0';
            else
                PasswordTB.PasswordChar = '*';
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string fname = FnameTB.Text; string lname = LNameTB.Text;
            string password = PasswordTB.Text; string username = UsernameTB.Text;
            string CertTitle = CertificatetitleTB.Text; string Certbody = CertificateIssBody.Text;
            int age;
            char gender;
            if (fname == "" || lname == "" || username == "" || password == "" || AgeTB.Text == "" || (MaleRB.Checked == false && FemaleRB.Checked == false))
                EmptyAlert.Visible = true;
            else
            {
                EmptyAlert.Visible = false;
                if (int.TryParse(AgeTB.Text, out age))
                {
                    if (MaleRB.Checked == true)
                        gender = 'M';
                    else
                        gender = 'F';

                    if (controllerobj.CheckifUsernameExist(username) != 0)
                        MessageBox.Show("usernme already exist");
                    else
                    {
                        controllerobj.AddUser(username, password, "coach");
                        if (controllerobj.AddCoach(username, fname, lname, age, gender, CertTitle, Dateofissue.Value.ToString(), ExpDate.Value.ToString(), Certbody) == 0)
                            MessageBox.Show("Couldn't Add Coach");
                        else
                            MessageBox.Show("Signup complete! Please wait untill we review your profile before logging in");
                    }
                }
                else
                    MessageBox.Show("Age must be an integer");
            }
        }
    }
}
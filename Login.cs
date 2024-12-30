using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class Login : SfForm
    {
        private Controller controllerobj = new Controller();

        public Login()
        {
            InitializeComponent();

            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkRed;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkRed;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTB.Text == "" || PasswordTB.Text == "")
                EmptyAlert.Visible = true;
            else
            {
                EmptyAlert.Visible = false;
                if (controllerobj.CheckIfUserExist(UsernameTB.Text, PasswordTB.Text) == 0)
                    IncorrectCred.Visible = true;
                else
                {
                    IncorrectCred.Visible = false;
                    DataRow dr = controllerobj.GetTypeOfUser(UsernameTB.Text);
                    string Type = dr["type_of_user"].ToString();

                    switch (Type)
                    {
                        case "admin":
                            Form F = new AdminUI(UsernameTB.Text, PasswordTB.Text,this);
                            F.Show();
                            break;

                        case "academy":
                            if (controllerobj.IsAcademyAccepted(UsernameTB.Text) == 0)
                                MessageBox.Show("Your Academy is still under review");
                            else
                            {
                                Form F2 = new Academies(UsernameTB.Text,controllerobj.GetAcademyID(UsernameTB.Text),this);
                                F2.Show();
                            }
                            break;

                        case "member":
                            Form F3 = new Members(UsernameTB.Text,this);
                            F3.Show();
                            break;

                        case "coach":
                            if (controllerobj.IsCoachAccepted(UsernameTB.Text) == 0)
                                MessageBox.Show("Coach isn't Accepted yet");
                            else
                            {
                                Form F4 = new Coach(UsernameTB.Text, this);
                                F4.Show();
                            }
                            break;
                    }
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

        private void Register_Click(object sender, EventArgs e)
        {
            if (Academy.Checked == true)
            {
                Form F = new AcademyRegister();
                F.Show();
            }
            if (Member.Checked == true)
            {
                Form F = new MemberSignup();
                F.Show();
            }
            if (Coach.Checked == true)
            {
                Form F = new CoachSignup();
                F.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void refreshlogin()
        {
            UsernameTB.Text = string.Empty;
            PasswordTB.Text = string.Empty ;
        }

    }
}
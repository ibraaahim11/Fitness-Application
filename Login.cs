using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;

namespace FitnessApplication
{
    public partial class Login : SfForm
    {
        Controller controllerobj = new Controller();

        public Login()
        {
            InitializeComponent();

            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.Red;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.Red;
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
                            Form F = new AdminUI(UsernameTB.Text, PasswordTB.Text);
                            F.Show();
                            break;
                        case "academy":
                            Form F2 = new Academies();
                            F2.Show();
                            break;
                        case "member":
                            Form F3 = new Members();
                            F3.Show();
                            break;
                        case "coach":
                            //form
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
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessApplication
{
    public partial class AdminProfile : SfForm
    {
        
        Controller controllerobj = new Controller();
        public AdminProfile(string username, string password)
        {
            InitializeComponent();
            this.Text = "Admin Profile";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            Username.Text = username;
            UsernameTBox.Text = username;
            PasswordTBox.Text = password;
            UsernameTBox.Enabled = false;
            PasswordTBox.Enabled = false;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                PasswordTBox.PasswordChar = '\0';
            else
            {
                PasswordTBox.PasswordChar = '*';
            }
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            if (controllerobj.CheckifUsernameExist(UsernameTBox.Text) != 0)
                MessageBox.Show("Username already exists choose another username");
            else
            {
                if ((PasswordTBox.Text == "") || UsernameTBox.Text == "")
                    EmptyAlert.Visible = true;
                else
                {
                    EmptyAlert.Visible = false;
                    if (controllerobj.CheckifUsernameExist(UsernameTBox.Text) != 0)
                        MessageBox.Show("Username already exists choose another username");
                    else
                    {
                        if (controllerobj.UpdateAdminUsername(Username.Text, UsernameTBox.Text) == 0 && controllerobj.UpdateAdminPasswords(Username.Text, PasswordTBox.Text) == 0)
                            MessageBox.Show("Couldn't update Profile");
                        else
                        {
                            Username.Text = UsernameTBox.Text;
                            MessageBox.Show("Profile updated successfully");
                            EditProfile.Enabled = false;
                            UsernameTBox.Enabled = false;
                            PasswordTBox.Enabled = false;
                        }
                    }
      
                }
            }
        }

        private void EditP_Click(object sender, EventArgs e)
        {
            PasswordTBox.Enabled = true;
            UsernameTBox.Enabled = true;
            EditProfile.Enabled = true;
        }
    }
}

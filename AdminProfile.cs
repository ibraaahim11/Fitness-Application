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

        private void EditUsername_CheckedChanged(object sender, EventArgs e)
        {
            if(EditUsername.Checked == true)
            {
                UsernameTBox.Enabled = true;
                EditProfile.Enabled = true;
            }
            else
                UsernameTBox.Enabled = false;

            if (EditPassword.Checked == false && EditUsername.Checked == false)
                EditProfile.Enabled = false;
        }

        private void EditPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (EditPassword.Checked == true)
            {
                PasswordTBox.Enabled = true;
                EditProfile.Enabled = true;
            }
            else
                PasswordTBox.Enabled = false;

            if (EditPassword.Checked == false && EditUsername.Checked == false)
                EditProfile.Enabled = false;
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            if (EditUsername.Checked == true && EditPassword.Checked == true && controllerobj.CheckifUsernameExist(UsernameTBox.Text) != 0)
                MessageBox.Show("Username already exists choose another username");
            else
            {
                if ((EditPassword.Checked == true && PasswordTBox.Text == "") || (EditUsername.Checked == true) && UsernameTBox.Text == "")
                    EmptyAlert.Visible = true;
                else
                {
                    EmptyAlert.Visible = false;
                    if (EditUsername.Checked == true)
                    {
                        if (controllerobj.CheckifUsernameExist(UsernameTBox.Text) != 0)
                            MessageBox.Show("Username already exists choose another username");
                        else
                        {
                            if (controllerobj.UpdateAdminUsername(Username.Text, UsernameTBox.Text) == 0)
                                MessageBox.Show("Couldn't update Username");
                            else
                            {
                                MessageBox.Show("Username updated successfully! ");
                                Username.Text = UsernameTBox.Text;
                            }
                        }
                    }
                    if (EditPassword.Checked == true)
                    {
                        if (controllerobj.UpdateAdminPasswords(Username.Text, PasswordTBox.Text) == 0)
                            MessageBox.Show("Couldn't update password");
                        else
                            MessageBox.Show("Password Updated Successfully");
                    }
                }
            }
        }
    }
}

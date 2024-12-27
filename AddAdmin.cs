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
    public partial class AddAdmin : SfForm
    {
        Controller controllerobj = new Controller();

        public AddAdmin()
        {
            InitializeComponent();

            this.Text = "Add A New Admin";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            AllAdmins.DataSource = controllerobj.GetAdminUsers();
            AllAdmins.Refresh();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                PasswodTBox.PasswordChar = '\0';
            else
                PasswodTBox.PasswordChar = '*';
        }

        private void AddNewAdmin_Click(object sender, EventArgs e)
        {
            if (PasswodTBox.Text == "" || UsernameTBox.Text == "")
                EmptyAlert.Visible = true;
            else
            {
                EmptyAlert.Visible = false; 
                if (controllerobj.CheckifUsernameExist(UsernameTBox.Text) != 0)
                    MessageBox.Show("Username already exist please choose another username");
                else
                {
                    if (controllerobj.AddNewAdmin(UsernameTBox.Text, PasswodTBox.Text) == 0)
                        MessageBox.Show("Admin is not added");
                    else
                    {
                        MessageBox.Show("New Admin Added successfully");
                        AllAdmins.DataSource = controllerobj.GetAdminUsers();
                        AllAdmins.Refresh();
                    }
                }
            }

        }

    }
}

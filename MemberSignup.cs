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
    public partial class MemberSignup : SfForm
    {

        Controller controllerobj = new Controller();
        public MemberSignup()
        {
            InitializeComponent();

            this.Text = "Member Signup";
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
            string fname = FnameTB.Text; string lname = LnameTB.Text;
            string username = UsernameTB.Text; string password = PasswordTB.Text;
            int age; double weight, height;
            char gender;
            if (fname == "" || lname == "" || username == "" || password == "" || AgeTB.Text == "" || WeightTB.Text == "" || HeightTB.Text == "" || (MaleRB.Checked == false && FemaleRB.Checked == false))
                EmptyError.Visible = true;
            else
            {
                EmptyError.Visible = false;
                if (int.TryParse(AgeTB.Text, out age) && double.TryParse(WeightTB.Text, out weight) && double.TryParse(HeightTB.Text, out height))
                {
                    if (MaleRB.Checked == true)
                        gender = 'M';
                    else
                        gender = 'F';

                    if (controllerobj.CheckifUsernameExist(username) != 0)
                        MessageBox.Show("Username Already exist");
                    else
                    {
                        controllerobj.AddUser(username, password, "member");

                        if (controllerobj.AddMember(username, fname, lname, age, weight, height, gender) == 0)
                            MessageBox.Show("Coudldn't add memeber");
                        else
                            MessageBox.Show("You have signedup successfully");
                    }
                }
                else
                    MessageBox.Show("Age, Weight, height must be numbers in there correct format");
            }
        }
    }
}

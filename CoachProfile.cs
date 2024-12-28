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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessApplication
{
    public partial class CoachProfile : SfForm
    {
        Controller controller;
        CoachProfile coachprofile;
        Coach BaseCoachForm;
        //all info about the coach 
        int ID;
        string username, Fname, Lname, gender, password;
        int age, memberlimit;

        string CertificateTitle, CertificateIssuingBody, CertificateDateOfIssue, CertificateExpirationDate;
        
        public CoachProfile(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            LoadProfile();
        }

        private void CoachProfile_Load(object sender, EventArgs e)
        {
            Style.TitleBar.BackColor = Color.DodgerBlue;
            Style.TitleBar.ForeColor = Color.White;

            Style.TitleBar.CloseButtonForeColor = Color.White;
            Style.TitleBar.MinimizeButtonForeColor = Color.White;
            Style.TitleBar.MaximizeButtonForeColor = Color.White;

            Style.TitleBar.CloseButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MinimizeButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MaximizeButtonHoverBackColor = Color.CornflowerBlue;

            Style.TitleBar.CloseButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MaximizeButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MinimizeButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.BackColor = Color.DodgerBlue;
            Style.TitleBar.ForeColor = Color.White;

            Style.TitleBar.CloseButtonForeColor = Color.White;
            Style.TitleBar.MinimizeButtonForeColor = Color.White;
            Style.TitleBar.MaximizeButtonForeColor = Color.White;

            Style.TitleBar.CloseButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MinimizeButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MaximizeButtonHoverBackColor = Color.CornflowerBlue;

            Style.TitleBar.CloseButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MaximizeButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MinimizeButtonPressedBackColor = Color.RoyalBlue;
        }


        private void passwordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordcheckbox.Checked == true)
            {
                passwordtextbox.PasswordChar = '\0';
            }
            else
            {
                passwordtextbox.PasswordChar = '*';
            }
        }

        private void updateprofilebutton_Click(object sender, EventArgs e)
        {
            fnametextbox.ReadOnly = false; lnametextbox.ReadOnly=false; coachidtextbox.ReadOnly = false; gendertextbox.ReadOnly = false;
            memberlimittextbox.ReadOnly = false; agetextbox.ReadOnly = false; passwordtextbox.ReadOnly = false; usernametextbox.ReadOnly = false;
            confirmprofilebutton.Visible = true;
        }

        private void confirmcertificatebutton_Click(object sender, EventArgs e)
        {
            // Read data
            CertificateTitle = titletextbox.Text; CertificateIssuingBody = issuingtextbox.Text;
            CertificateDateOfIssue = datetextbox.Text; CertificateExpirationDate = expirationtextbox.Text;

            // Check if fields empty
            if (CertificateTitle == "" || CertificateIssuingBody == "" || CertificateDateOfIssue == "" || CertificateExpirationDate == "")
            {
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
            // Update Certificate
            int result = controller.UpdateAcademyCertificate(ID, CertificateTitle, CertificateDateOfIssue, CertificateIssuingBody, CertificateExpirationDate);

            if (result == 1)
            {
                MessageBox.Show("Certificate Updated Successfully.");
                // Return to original state
                confirmcertificatebutton.Visible = false;

                titletextbox.ReadOnly = true; issuingtextbox.ReadOnly = true; datetextbox.ReadOnly = true;
                expirationtextbox.ReadOnly = true;
            }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            titletextbox.ReadOnly = false; datetextbox.ReadOnly=false; expirationtextbox.ReadOnly=false; 
            issuingtextbox.ReadOnly=false; 
            confirmcertificatebutton.Visible = true;
        }

        private void confirmprofilebutton_Click(object sender, EventArgs e)
        {
           
            Fname = fnametextbox.Text; Lname = lnametextbox.Text; ID = Convert.ToInt32(coachidtextbox.Text);
            gender = gendertextbox.Text; memberlimit = Convert.ToInt32(memberlimittextbox.Text); age=Convert.ToInt32(agetextbox.Text); password = passwordtextbox.Text;
            // Old username will be used to update new username
            string NewUsername = usernametextbox.Text;
            // Check if fields empty
            if (Fname == "" || Lname == "" || gender == "" || username == "" || password == "" || ID==0 || age==0 )
            {
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
            // Update profile
            int resultBasicInfo = controller.UpdateCoachProfile(Fname,Lname,ID,gender,age);
            int resultUsernamePassword = controller.UpdateUsernamePasswordCoach(username, NewUsername, password);

            if (resultBasicInfo == 1 && resultUsernamePassword == 1)
            {
                MessageBox.Show("Profile Updated Successfully.");
                // Return to original state
                confirmprofilebutton.Visible = false;

                fnametextbox.ReadOnly = true; lnametextbox.ReadOnly = true; coachidtextbox.ReadOnly = true; gendertextbox.ReadOnly = true;
                memberlimittextbox.ReadOnly = true; agetextbox.ReadOnly = true; passwordtextbox.ReadOnly = true; usernametextbox.ReadOnly = true;

               
                BaseCoachForm.UpdateData(NewUsername);
            }
            else if (resultBasicInfo != 1 && resultUsernamePassword != 1)
            {
                MessageBox.Show("Profile could not be updated.");
                return;
            }
            else if (resultUsernamePassword != 1)
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

        }

        private void agelabel_Click(object sender, EventArgs e)
        {

        }
       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void LoadProfile()
        {
            //getting all the info needed for the coach
            Fname=controller.GetCoachName(ID);
            Lname = controller.GetCoachLastName(ID);
            gender = controller.GetGender(ID);
            age=controller.GetCoachAge(ID);
            memberlimit=controller.GetMemberLimit(ID);
            password = controller.GetCoachPassword(username);
            //getting all the certificate info
            CertificateTitle = controller.GetCoachCertificateTitle(ID);
            CertificateIssuingBody = controller.GetCoachCertificateIssuingBody(ID);
            CertificateDateOfIssue= controller.GetCoachCertificateDateOfIssue(ID);
            CertificateExpirationDate=controller.GetCoachCertificateExpirationDate(ID);


            //loading the info in the textboxes 
            fnametextbox.Text = Fname;
            lnametextbox.Text = Lname;
            usernametextbox.Text= username;
            coachidtextbox.Text = Convert.ToString(ID);
            memberlimittextbox.Text = Convert.ToString(memberlimit);
            agetextbox.Text=Convert.ToString(age);
            passwordtextbox.Text= password;
            if (gender == "M")
            {
                gendertextbox.Text = "Male";
            }
            else
            {
                gendertextbox.Text = "Female";
            }
            titletextbox.Text = CertificateTitle;
            datetextbox.Text = CertificateDateOfIssue;
            issuingtextbox.Text = CertificateIssuingBody;
            expirationtextbox.Text = CertificateExpirationDate;


        }
    }
}

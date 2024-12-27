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

        private void sfButton1_Click(object sender, EventArgs e)
        {
            titletextbox.ReadOnly = false; datetextbox.ReadOnly=false; expirationtextbox.ReadOnly=false; 
            issuingtextbox.ReadOnly=false; 
            confirmcertificatebutton.Visible = true;
        }

        private void agelabel_Click(object sender, EventArgs e)
        {

        }

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

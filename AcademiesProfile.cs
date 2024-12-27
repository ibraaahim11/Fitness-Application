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
using Syncfusion.Windows.Forms;

namespace FitnessApplication
{
    public partial class AcademiesProfile : SfForm
    {
        // Controller obj
        Controller controller;
        // Forms to open
        AcademiesProfile ProfileForm;
        // Basic Academy info for welcome screen
        int ID;
        string Username, Name, Description, AreaOfExpertise, Password;

        string CertificateTitle, CertificateIssuingBody, CertificateDateOfIssue, CertificateExpirationDate;
        Academies BaseAcademyForm;
        
        // Base academy form taken in order to be update username when needed
        public AcademiesProfile(int ID, string Username, Academies BaseAcademyForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.Username = Username;
            this.BaseAcademyForm = BaseAcademyForm;
            LoadProfile();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void sfButtonDeleteAccount_Click(object sender, EventArgs e)
        {

            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;

            // 3ayzo same colors like academy
            MessageBoxAdv.MetroColorTable.BackColor = Color.White;        
            MessageBoxAdv.MetroColorTable.ForeColor = Color.Black;       
            MessageBoxAdv.MetroColorTable.BorderColor = Color.IndianRed;  
            MessageBoxAdv.MetroColorTable.CaptionBarColor = Color.LightCoral; 
            MessageBoxAdv.MetroColorTable.CaptionForeColor = Color.White;

            DialogResult result = MessageBoxAdv.Show(this,
                "Are you sure you want to delete your account?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                MessageBoxAdv.Show(this, "We are sad to see you go :(", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.DeleteAcademy(ID);
                controller.DeleteAcademyUser(Username);
                BaseAcademyForm.Close();
            }
            else if (result == DialogResult.No)
            {

                MessageBoxAdv.Show(this, "Account deletion canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonEditCertificate_Click(object sender, EventArgs e)
        {
            textBoxTitle.ReadOnly = false; textBoxIssuingBody.ReadOnly = false; textBoxDateOfIssue.ReadOnly = false;
            textBoxExpirationDate.ReadOnly = false;
            buttonConfirmCertificate.Visible = true;
        }

        private void buttonConfirmCertificate_Click(object sender, EventArgs e)
        {
            // Read data
           CertificateTitle = textBoxTitle.Text; CertificateIssuingBody = textBoxIssuingBody.Text;
           CertificateDateOfIssue = textBoxDateOfIssue.Text; CertificateExpirationDate = textBoxExpirationDate.Text;

            // Check if fields empty
            if (CertificateTitle == "" || CertificateIssuingBody == "" || CertificateDateOfIssue == ""|| CertificateExpirationDate == "")
            {
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
            // Update Certificate
            int result = controller.UpdateAcademyCertificate(ID,CertificateTitle,CertificateDateOfIssue,CertificateIssuingBody,CertificateExpirationDate);
            
            if (result == 1)
            {
                MessageBox.Show("Certificate Updated Successfully.");
                // Return to original state
                buttonConfirmCertificate.Visible = false;

                textBoxTitle.ReadOnly = true; textBoxIssuingBody.ReadOnly = true; textBoxDateOfIssue.ReadOnly = true;
                textBoxExpirationDate.ReadOnly = true;



                
            }
            else
            { 
                MessageBox.Show("Certificate could not be updated.");
                return;
            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false ; textBoxDescription.ReadOnly = false; textBoxAOE.ReadOnly = false ;
            textBoxPassword.ReadOnly = false ; textBoxUsername.ReadOnly = false ;
            buttonConfirmProfileChanges.Visible = true ;

        }

        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            // Read data
            Name = textBoxName.Text ; Description = textBoxDescription.Text ; AreaOfExpertise = textBoxAOE.Text ;
            Password = textBoxPassword.Text ;
            // Old username will be used to update new username
            string NewUsername = textBoxUsername.Text ;
            // Check if fields empty
            if (Name == "" || Description == ""|| AreaOfExpertise == "" || Username == "" || Password == "")
            {
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
            // Update profile
            int resultBasicInfo = controller.UpdateBasicAcademyProfile(ID, Name, Description, AreaOfExpertise);
            int resultUsernamePassword = controller.UpdateUsernamePasswordAcademy(Username, NewUsername, Password);

            if (resultBasicInfo == 1 && resultUsernamePassword == 1)
            {
                MessageBox.Show("Profile Updated Successfully.");
                // Return to original state
                buttonConfirmProfileChanges.Visible=false;

                textBoxName.ReadOnly = true ; textBoxDescription.ReadOnly = true ; textBoxAOE.ReadOnly=true;
                textBoxUsername.ReadOnly = true ; textBoxPassword.ReadOnly = true ;

                // The base academy form should have its data updated
                BaseAcademyForm.UpdateData(NewUsername);
            }
            else if(resultBasicInfo != 1 && resultUsernamePassword != 1)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AcademiesProfile_Load(object sender, EventArgs e)
        {
            // Sets the back color and fore color of the title bar.
            this.Style.TitleBar.BackColor = Color.LightCoral;
            this.Style.TitleBar.ForeColor = Color.White;


            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;


            this.Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

            this.Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;
        }


        public void LoadProfile()
        {
            // Getting the info
            Name = controller.GetAcademyName(ID);
            Description = controller.GetAcademyDescription(ID);
            AreaOfExpertise = controller.GetAcademyAOE(ID);
            Password = controller.GetAcademyPassword(Username);

            CertificateTitle = controller.GetAcademyCertificateTitle(ID);
            CertificateIssuingBody = controller.GetAcademyCertificateIssuingBody(ID);
            CertificateDateOfIssue = controller.GetAcademyCertificateDateOfIssue(ID);
            CertificateExpirationDate = controller.GetAcademyCertificateExpirationDate(ID);

            // Loading it into suitable text boxes
            textBoxUsername.Text = Username;
            textBoxName.Text = Name;
            textBoxDescription.Text = Description;
            textBoxAOE.Text = AreaOfExpertise;
            textBoxPassword.Text = Password;


            textBoxTitle.Text = CertificateTitle;
            textBoxIssuingBody.Text = CertificateIssuingBody;
            textBoxDateOfIssue.Text = CertificateDateOfIssue;
            textBoxExpirationDate.Text = CertificateExpirationDate;


        }
    }
}

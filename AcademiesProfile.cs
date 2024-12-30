using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class AcademiesProfile : SfForm
    {
        // Controller obj
        private Controller controller;

        // Forms to open
        private AcademiesProfile ProfileForm;

        // Basic Academy info for welcome screen
        private int ID;

        private string Username, Name, Description, AreaOfExpertise, Password;

        private string CertificateTitle, CertificateIssuingBody, CertificateDateOfIssue, CertificateExpirationDate;
        private Academies BaseAcademyForm;

        // Base academy form taken in order to be update username when needed
        public AcademiesProfile(int ID, string Username, Academies BaseAcademyForm)
        {
            InitializeComponent();
            this.tabPageAdv1.Text = "Profile";
            this.tabPageAdv2.Text = "Certificate";
            this.tabPageAdv3.Text = "Account Settings";
            controller = new Controller();
            this.ID = ID;
            this.Username = Username;
            this.BaseAcademyForm = BaseAcademyForm;
            ConfigureMessageBoxAdv();
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
            DialogResult result = MessageBoxAdv.Show(this,
                "Are you sure you want to delete your account?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBoxAdv.MetroColorTable.OKButtonBackColor = Color.LightCoral;
                MessageBoxAdv.Show(this, "We are sad to see you go :(", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controller.DeleteAcademy(ID);
                controller.DeleteAcademyUser(Username);
                BaseAcademyForm.Close();
                this.Close();

                
            }
            else if (result == DialogResult.No)
            {
                MessageBoxAdv.Show(this, "Account deletion canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void DatePickers_Click(object sender, EventArgs e)
        {
            sfDateTimeOfExpiration.MinDateTime = (System.DateTime)sfDateTimeOfIssue.Value;
        }

        private void sfDateTimeOfIssue_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            sfDateTimeOfExpiration.MinDateTime = (System.DateTime)sfDateTimeOfIssue.Value;
        }

        private void tabPageAdv1_Click(object sender, EventArgs e)
        {
        }

        private void buttonEditCertificate_Click(object sender, EventArgs e)
        {
            textBoxTitle.ReadOnly = false; textBoxIssuingBody.ReadOnly = false;

            buttonConfirmCertificate.Visible = true;

            sfDateTimeOfIssue.Enabled = true; sfDateTimeOfExpiration.Enabled = true;
        }

        private void buttonConfirmCertificate_Click(object sender, EventArgs e)
        {
            // Read data
            CertificateTitle = textBoxTitle.Text; CertificateIssuingBody = textBoxIssuingBody.Text;
            CertificateDateOfIssue = sfDateTimeOfIssue.DateTimeText; CertificateExpirationDate = sfDateTimeOfExpiration.DateTimeText;

            // Check if fields empty
            if (CertificateTitle == "" || CertificateIssuingBody == "" || CertificateDateOfIssue == "" || CertificateExpirationDate == "")
            {
                MessageBoxAdv.Show(this,
                    "Do not leave any fields empty.",
                    "No changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Update Certificate
            int result = controller.UpdateAcademyCertificate(ID, CertificateTitle, CertificateDateOfIssue, CertificateIssuingBody, CertificateExpirationDate);

            if (result == 1)
            {
                MessageBoxAdv.Show(this,
                    "Certificate updated successfully",
                    "Certificate Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Return to original state
                buttonConfirmCertificate.Visible = false;

                textBoxTitle.ReadOnly = true; textBoxIssuingBody.ReadOnly = true;
                sfDateTimeOfExpiration.Enabled = false;
                sfDateTimeOfIssue.Enabled = false;
            }
            else
            {
                MessageBoxAdv.Show(this,
                    "Certificate could not be updated.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            textBoxName.ReadOnly = false; textBoxDescription.ReadOnly = false; textBoxAOE.ReadOnly = false;
            textBoxPassword.ReadOnly = false; textBoxUsername.ReadOnly = false;
            buttonConfirmProfileChanges.Visible = true;
        }

        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            // Read data
            Name = textBoxName.Text; Description = textBoxDescription.Text; AreaOfExpertise = textBoxAOE.Text;
            Password = textBoxPassword.Text;
            // Old username will be used to update new username
            string NewUsername = textBoxUsername.Text;
            // Check if fields empty
            if (Name == "" || Description == "" || AreaOfExpertise == "" || NewUsername == "" || Password == "")
            {
                DialogResult result = MessageBoxAdv.Show(this,
                    "Do not leave any fields empty.",
                    "No changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // Update profile
            int resultBasicInfo = controller.UpdateBasicAcademyProfile(ID, Name, Description, AreaOfExpertise);
            int resultUsernamePassword = controller.UpdateUsernamePasswordAcademy(Username, NewUsername, Password);

            if (resultBasicInfo == 1 && resultUsernamePassword == 1)
            {
                DialogResult result = MessageBoxAdv.Show(this,
                    "Profile updated successfully",
                    "Profile Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Return to original state
                buttonConfirmProfileChanges.Visible = false;

                textBoxName.ReadOnly = true; textBoxDescription.ReadOnly = true; textBoxAOE.ReadOnly = true;
                textBoxUsername.ReadOnly = true; textBoxPassword.ReadOnly = true;

                // The base academy form should have its data updated
                BaseAcademyForm.UpdateData(NewUsername);
                Username = NewUsername;
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
            sfDateTimeOfIssue.Text = CertificateDateOfIssue;
            sfDateTimeOfExpiration.Text = CertificateExpirationDate;
        }

        // same colors as academies
        public static void ConfigureMessageBoxAdv()
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            var metroColorTable = MessageBoxAdv.MetroColorTable;
            metroColorTable.BackColor = Color.White;
            metroColorTable.ForeColor = Color.Black;
            metroColorTable.BorderColor = Color.IndianRed;
            metroColorTable.CaptionBarColor = Color.LightCoral;
            metroColorTable.CaptionForeColor = Color.White;
            metroColorTable.OKButtonBackColor = Color.LightCoral;
            metroColorTable.YesButtonBackColor = Color.LightCoral;
            metroColorTable.NoButtonBackColor = Color.LightCoral;

            MessageBoxAdv.MetroColorTable = metroColorTable;
        }
    }
}
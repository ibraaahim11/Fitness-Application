namespace FitnessApplication
{
    partial class AcademiesProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelAreaExpertise = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxAOE = new System.Windows.Forms.TextBox();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttonConfirmProfileChanges = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelCertificate = new System.Windows.Forms.Label();
            this.labelDateIssue = new System.Windows.Forms.Label();
            this.labelIssuingBody = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxIssuingBody = new System.Windows.Forms.TextBox();
            this.textBoxDateOfIssue = new System.Windows.Forms.TextBox();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.buttonEditCertificate = new System.Windows.Forms.Button();
            this.buttonConfirmCertificate = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(33, 94);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 22);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelAreaExpertise
            // 
            this.labelAreaExpertise.AutoSize = true;
            this.labelAreaExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAreaExpertise.Location = new System.Drawing.Point(33, 135);
            this.labelAreaExpertise.Name = "labelAreaExpertise";
            this.labelAreaExpertise.Size = new System.Drawing.Size(153, 22);
            this.labelAreaExpertise.TabIndex = 2;
            this.labelAreaExpertise.Text = "Area of Expertise:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(33, 183);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 22);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(208, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(222, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(208, 183);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(222, 83);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxAOE
            // 
            this.textBoxAOE.Location = new System.Drawing.Point(208, 137);
            this.textBoxAOE.Name = "textBoxAOE";
            this.textBoxAOE.ReadOnly = true;
            this.textBoxAOE.Size = new System.Drawing.Size(222, 22);
            this.textBoxAOE.TabIndex = 6;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(629, 52);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(128, 41);
            this.buttonEditProfile.TabIndex = 7;
            this.buttonEditProfile.Text = "Edit Profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttonConfirmProfileChanges
            // 
            this.buttonConfirmProfileChanges.Location = new System.Drawing.Point(629, 267);
            this.buttonConfirmProfileChanges.Name = "buttonConfirmProfileChanges";
            this.buttonConfirmProfileChanges.Size = new System.Drawing.Size(128, 41);
            this.buttonConfirmProfileChanges.TabIndex = 8;
            this.buttonConfirmProfileChanges.Text = "Confirm Changes";
            this.buttonConfirmProfileChanges.UseVisualStyleBackColor = true;
            this.buttonConfirmProfileChanges.Visible = false;
            this.buttonConfirmProfileChanges.Click += new System.EventHandler(this.buttonConfirmChanges_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.IndianRed;
            this.labelProfile.Location = new System.Drawing.Point(28, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(73, 25);
            this.labelProfile.TabIndex = 9;
            this.labelProfile.Text = "Profile";
            // 
            // labelCertificate
            // 
            this.labelCertificate.AutoSize = true;
            this.labelCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCertificate.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCertificate.Location = new System.Drawing.Point(32, 355);
            this.labelCertificate.Name = "labelCertificate";
            this.labelCertificate.Size = new System.Drawing.Size(110, 25);
            this.labelCertificate.TabIndex = 10;
            this.labelCertificate.Text = "Certificate";
            // 
            // labelDateIssue
            // 
            this.labelDateIssue.AutoSize = true;
            this.labelDateIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateIssue.Location = new System.Drawing.Point(37, 485);
            this.labelDateIssue.Name = "labelDateIssue";
            this.labelDateIssue.Size = new System.Drawing.Size(120, 22);
            this.labelDateIssue.TabIndex = 13;
            this.labelDateIssue.Text = "Date of Issue:";
            // 
            // labelIssuingBody
            // 
            this.labelIssuingBody.AutoSize = true;
            this.labelIssuingBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuingBody.Location = new System.Drawing.Point(37, 437);
            this.labelIssuingBody.Name = "labelIssuingBody";
            this.labelIssuingBody.Size = new System.Drawing.Size(117, 22);
            this.labelIssuingBody.TabIndex = 12;
            this.labelIssuingBody.Text = "Issuing Body:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(37, 396);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 22);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title:";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.Location = new System.Drawing.Point(37, 537);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(138, 22);
            this.labelExpirationDate.TabIndex = 14;
            this.labelExpirationDate.Text = "Expiration Date:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(181, 396);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(222, 22);
            this.textBoxTitle.TabIndex = 15;
            // 
            // textBoxIssuingBody
            // 
            this.textBoxIssuingBody.Location = new System.Drawing.Point(181, 439);
            this.textBoxIssuingBody.Name = "textBoxIssuingBody";
            this.textBoxIssuingBody.ReadOnly = true;
            this.textBoxIssuingBody.Size = new System.Drawing.Size(222, 22);
            this.textBoxIssuingBody.TabIndex = 16;
            // 
            // textBoxDateOfIssue
            // 
            this.textBoxDateOfIssue.Location = new System.Drawing.Point(181, 485);
            this.textBoxDateOfIssue.Name = "textBoxDateOfIssue";
            this.textBoxDateOfIssue.ReadOnly = true;
            this.textBoxDateOfIssue.Size = new System.Drawing.Size(222, 22);
            this.textBoxDateOfIssue.TabIndex = 17;
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.Location = new System.Drawing.Point(181, 537);
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.ReadOnly = true;
            this.textBoxExpirationDate.Size = new System.Drawing.Size(222, 22);
            this.textBoxExpirationDate.TabIndex = 18;
            // 
            // buttonEditCertificate
            // 
            this.buttonEditCertificate.Location = new System.Drawing.Point(629, 396);
            this.buttonEditCertificate.Name = "buttonEditCertificate";
            this.buttonEditCertificate.Size = new System.Drawing.Size(128, 41);
            this.buttonEditCertificate.TabIndex = 19;
            this.buttonEditCertificate.Text = "Edit Certificate";
            this.buttonEditCertificate.UseVisualStyleBackColor = true;
            this.buttonEditCertificate.Click += new System.EventHandler(this.buttonEditCertificate_Click);
            // 
            // buttonConfirmCertificate
            // 
            this.buttonConfirmCertificate.Location = new System.Drawing.Point(629, 528);
            this.buttonConfirmCertificate.Name = "buttonConfirmCertificate";
            this.buttonConfirmCertificate.Size = new System.Drawing.Size(128, 41);
            this.buttonConfirmCertificate.TabIndex = 20;
            this.buttonConfirmCertificate.Text = "Confirm Changes";
            this.buttonConfirmCertificate.UseVisualStyleBackColor = true;
            this.buttonConfirmCertificate.Visible = false;
            this.buttonConfirmCertificate.Click += new System.EventHandler(this.buttonConfirmCertificate_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(208, 52);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(222, 22);
            this.textBoxUsername.TabIndex = 22;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(33, 52);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 22);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(208, 286);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(222, 22);
            this.textBoxPassword.TabIndex = 24;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(33, 286);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 22);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Password:";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(208, 314);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(62, 20);
            this.checkBoxShowPassword.TabIndex = 25;
            this.checkBoxShowPassword.Text = "Show";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // AcademiesProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 680);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonConfirmCertificate);
            this.Controls.Add(this.buttonEditCertificate);
            this.Controls.Add(this.textBoxExpirationDate);
            this.Controls.Add(this.textBoxDateOfIssue);
            this.Controls.Add(this.textBoxIssuingBody);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.labelDateIssue);
            this.Controls.Add(this.labelIssuingBody);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCertificate);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.buttonConfirmProfileChanges);
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.textBoxAOE);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAreaExpertise);
            this.Controls.Add(this.labelName);
            this.Name = "AcademiesProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.AcademiesProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAreaExpertise;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxAOE;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttonConfirmProfileChanges;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelCertificate;
        private System.Windows.Forms.Label labelDateIssue;
        private System.Windows.Forms.Label labelIssuingBody;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxIssuingBody;
        private System.Windows.Forms.TextBox textBoxDateOfIssue;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.Button buttonEditCertificate;
        private System.Windows.Forms.Button buttonConfirmCertificate;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}
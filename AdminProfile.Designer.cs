namespace FitnessApplication
{
    partial class AdminProfile
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
            this.Username = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.UsernameTBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PasswordTBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.EditUsername = new System.Windows.Forms.CheckBox();
            this.EditPassword = new System.Windows.Forms.CheckBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.EditProfile = new Syncfusion.WinForms.Controls.SfButton();
            this.EmptyAlert = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Green;
            this.Username.Location = new System.Drawing.Point(54, 39);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(136, 27);
            this.Username.TabIndex = 0;
            this.Username.Text = "autoLabel1";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(54, 207);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(102, 24);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Password  :";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Green;
            this.autoLabel3.Location = new System.Drawing.Point(54, 148);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(103, 24);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "Username  :";
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.BeforeTouchSize = new System.Drawing.Size(238, 22);
            this.UsernameTBox.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.UsernameTBox.BorderColor = System.Drawing.Color.Green;
            this.UsernameTBox.Enabled = false;
            this.UsernameTBox.Location = new System.Drawing.Point(172, 148);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(238, 22);
            this.UsernameTBox.TabIndex = 3;
            this.UsernameTBox.Text = "textBoxExt1";
            // 
            // PasswordTBox
            // 
            this.PasswordTBox.BeforeTouchSize = new System.Drawing.Size(238, 22);
            this.PasswordTBox.Enabled = false;
            this.PasswordTBox.Location = new System.Drawing.Point(172, 209);
            this.PasswordTBox.Name = "PasswordTBox";
            this.PasswordTBox.PasswordChar = '*';
            this.PasswordTBox.Size = new System.Drawing.Size(238, 22);
            this.PasswordTBox.TabIndex = 4;
            this.PasswordTBox.Text = "textBoxExt2";
            // 
            // EditUsername
            // 
            this.EditUsername.AutoSize = true;
            this.EditUsername.Location = new System.Drawing.Point(436, 152);
            this.EditUsername.Name = "EditUsername";
            this.EditUsername.Size = new System.Drawing.Size(170, 20);
            this.EditUsername.TabIndex = 5;
            this.EditUsername.Text = "Click To Edit Username";
            this.EditUsername.UseVisualStyleBackColor = true;
            this.EditUsername.CheckedChanged += new System.EventHandler(this.EditUsername_CheckedChanged);
            // 
            // EditPassword
            // 
            this.EditPassword.AutoSize = true;
            this.EditPassword.Location = new System.Drawing.Point(436, 207);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.Size = new System.Drawing.Size(170, 20);
            this.EditPassword.TabIndex = 6;
            this.EditPassword.Text = "Click To Edit Password ";
            this.EditPassword.UseVisualStyleBackColor = true;
            this.EditPassword.CheckedChanged += new System.EventHandler(this.EditPassword_CheckedChanged);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(172, 237);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(62, 20);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "Show";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // EditProfile
            // 
            this.EditProfile.BackColor = System.Drawing.Color.DarkGreen;
            this.EditProfile.Enabled = false;
            this.EditProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProfile.ForeColor = System.Drawing.Color.White;
            this.EditProfile.Location = new System.Drawing.Point(54, 310);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(186, 43);
            this.EditProfile.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.EditProfile.Style.ForeColor = System.Drawing.Color.White;
            this.EditProfile.TabIndex = 8;
            this.EditProfile.Text = "Update Profile";
            this.EditProfile.UseVisualStyleBackColor = false;
            this.EditProfile.Click += new System.EventHandler(this.EditProfile_Click);
            // 
            // EmptyAlert
            // 
            this.EmptyAlert.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyAlert.ForeColor = System.Drawing.Color.Red;
            this.EmptyAlert.Location = new System.Drawing.Point(21, 356);
            this.EmptyAlert.Name = "EmptyAlert";
            this.EmptyAlert.Size = new System.Drawing.Size(250, 20);
            this.EmptyAlert.TabIndex = 9;
            this.EmptyAlert.Text = "Username or password should not be empty";
            this.EmptyAlert.Visible = false;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.autoLabel1.Location = new System.Drawing.Point(277, 331);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(220, 22);
            this.autoLabel1.TabIndex = 10;
            this.autoLabel1.Text = "Updates only the checked Box";
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.EmptyAlert);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.EditPassword);
            this.Controls.Add(this.EditUsername);
            this.Controls.Add(this.PasswordTBox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.Username);
            this.Name = "AdminProfile";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "AdminProfile";
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel Username;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UsernameTBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTBox;
        private System.Windows.Forms.CheckBox EditUsername;
        private System.Windows.Forms.CheckBox EditPassword;
        private System.Windows.Forms.CheckBox ShowPassword;
        private Syncfusion.WinForms.Controls.SfButton EditProfile;
        private Syncfusion.Windows.Forms.Tools.AutoLabel EmptyAlert;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
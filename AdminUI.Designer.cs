namespace FitnessApplication
{
    partial class AdminUI
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
            this.Username = new System.Windows.Forms.TextBox();
            this.EditProfile = new System.Windows.Forms.Button();
            this.CoachesAndMembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Username.Enabled = false;
            this.Username.Location = new System.Drawing.Point(12, 20);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(188, 22);
            this.Username.TabIndex = 0;
            this.Username.Text = "<Admin username>";
            // 
            // EditProfile
            // 
            this.EditProfile.Location = new System.Drawing.Point(231, 12);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(232, 30);
            this.EditProfile.TabIndex = 1;
            this.EditProfile.Text = "Edit username or password";
            this.EditProfile.UseVisualStyleBackColor = true;
            // 
            // CoachesAndMembers
            // 
            this.CoachesAndMembers.Location = new System.Drawing.Point(552, 377);
            this.CoachesAndMembers.Name = "CoachesAndMembers";
            this.CoachesAndMembers.Size = new System.Drawing.Size(207, 50);
            this.CoachesAndMembers.TabIndex = 2;
            this.CoachesAndMembers.Text = "Coaches And Members --->";
            this.CoachesAndMembers.UseVisualStyleBackColor = true;
            this.CoachesAndMembers.Click += new System.EventHandler(this.CoachesAndMembers_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoachesAndMembers);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.Username);
            this.Name = "AdminUI";
            this.Text = "AdminUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.Button CoachesAndMembers;
    }
}
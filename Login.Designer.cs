namespace FitnessApplication
{
    partial class Login
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
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.LoginButton = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.UsernameTB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PasswordTB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.EmptyAlert = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.IncorrectCred = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.Members = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Coach = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.Academy = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Members)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Academy)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Red;
            this.autoLabel1.Location = new System.Drawing.Point(337, 60);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(95, 35);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Login";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Red;
            this.autoLabel2.Location = new System.Drawing.Point(72, 145);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(88, 24);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Username";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Red;
            this.autoLabel3.Location = new System.Drawing.Point(72, 214);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(87, 24);
            this.autoLabel3.TabIndex = 2;
            this.autoLabel3.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Red;
            this.LoginButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(387, 236);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(138, 28);
            this.LoginButton.Style.BackColor = System.Drawing.Color.Red;
            this.LoginButton.Style.ForeColor = System.Drawing.Color.White;
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.BackColor = System.Drawing.Color.Red;
            this.sfButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfButton2.ForeColor = System.Drawing.Color.White;
            this.sfButton2.Location = new System.Drawing.Point(72, 372);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(138, 28);
            this.sfButton2.Style.BackColor = System.Drawing.Color.Red;
            this.sfButton2.Style.ForeColor = System.Drawing.Color.White;
            this.sfButton2.TabIndex = 4;
            this.sfButton2.Text = "Register";
            this.sfButton2.UseVisualStyleBackColor = false;
            // 
            // UsernameTB
            // 
            this.UsernameTB.BeforeTouchSize = new System.Drawing.Size(270, 22);
            this.UsernameTB.Location = new System.Drawing.Point(72, 174);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(270, 22);
            this.UsernameTB.TabIndex = 5;
            // 
            // PasswordTB
            // 
            this.PasswordTB.BeforeTouchSize = new System.Drawing.Size(270, 22);
            this.PasswordTB.Location = new System.Drawing.Point(72, 242);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(270, 22);
            this.PasswordTB.TabIndex = 6;
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Red;
            this.autoLabel4.Location = new System.Drawing.Point(72, 335);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(217, 22);
            this.autoLabel4.TabIndex = 7;
            this.autoLabel4.Text = "Not registered?    Register as:";
            // 
            // EmptyAlert
            // 
            this.EmptyAlert.ForeColor = System.Drawing.Color.Blue;
            this.EmptyAlert.Location = new System.Drawing.Point(554, 247);
            this.EmptyAlert.Name = "EmptyAlert";
            this.EmptyAlert.Size = new System.Drawing.Size(183, 16);
            this.EmptyAlert.TabIndex = 11;
            this.EmptyAlert.Text = "Cannot Leave any field empty";
            this.EmptyAlert.Visible = false;
            // 
            // IncorrectCred
            // 
            this.IncorrectCred.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectCred.ForeColor = System.Drawing.Color.Blue;
            this.IncorrectCred.Location = new System.Drawing.Point(72, 308);
            this.IncorrectCred.Name = "IncorrectCred";
            this.IncorrectCred.Size = new System.Drawing.Size(208, 16);
            this.IncorrectCred.TabIndex = 12;
            this.IncorrectCred.Text = "Username or password is incorrect";
            this.IncorrectCred.Visible = false;
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Location = new System.Drawing.Point(72, 271);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(62, 20);
            this.ShowPass.TabIndex = 13;
            this.ShowPass.Text = "Show";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // Members
            // 
            this.Members.AccessibilityEnabled = true;
            this.Members.BeforeTouchSize = new System.Drawing.Size(104, 31);
            this.Members.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.Color.Red;
            this.Members.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.Members.Location = new System.Drawing.Point(314, 335);
            this.Members.MetroColor = System.Drawing.Color.Red;
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(104, 31);
            this.Members.TabIndex = 14;
            this.Members.Text = "Member";
            // 
            // Coach
            // 
            this.Coach.AccessibilityEnabled = true;
            this.Coach.BeforeTouchSize = new System.Drawing.Size(101, 31);
            this.Coach.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coach.ForeColor = System.Drawing.Color.Red;
            this.Coach.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.Coach.Location = new System.Drawing.Point(439, 335);
            this.Coach.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.Coach.Name = "Coach";
            this.Coach.Size = new System.Drawing.Size(101, 31);
            this.Coach.TabIndex = 15;
            this.Coach.Text = "Coach";
            // 
            // Academy
            // 
            this.Academy.AccessibilityEnabled = true;
            this.Academy.BeforeTouchSize = new System.Drawing.Size(150, 30);
            this.Academy.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academy.ForeColor = System.Drawing.Color.Red;
            this.Academy.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.Academy.Location = new System.Drawing.Point(546, 335);
            this.Academy.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.Academy.Name = "Academy";
            this.Academy.Size = new System.Drawing.Size(150, 30);
            this.Academy.TabIndex = 16;
            this.Academy.Text = "Academy";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Academy);
            this.Controls.Add(this.Coach);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.IncorrectCred);
            this.Controls.Add(this.EmptyAlert);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.sfButton2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Name = "Login";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Members)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Academy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.Controls.SfButton LoginButton;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UsernameTB;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTB;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel EmptyAlert;
        private Syncfusion.Windows.Forms.Tools.AutoLabel IncorrectCred;
        private System.Windows.Forms.CheckBox ShowPass;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Members;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Coach;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv Academy;
    }
}
namespace FitnessApplication
{
    partial class AddAdmin
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
            this.AllAdmins = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AddNewAdmin = new Syncfusion.WinForms.Controls.SfButton();
            this.UsernameTBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PasswodTBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.EmptyAlert = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AllAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswodTBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllAdmins
            // 
            this.AllAdmins.AccessibleName = "Table";
            this.AllAdmins.Location = new System.Drawing.Point(316, 97);
            this.AllAdmins.Name = "AllAdmins";
            this.AllAdmins.PreviewRowHeight = 35;
            this.AllAdmins.Size = new System.Drawing.Size(155, 166);
            this.AllAdmins.TabIndex = 0;
            this.AllAdmins.Text = "sfDataGrid1";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(326, 55);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(133, 27);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "All Admins";
            this.autoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(61, 300);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(93, 24);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Username:";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Green;
            this.autoLabel3.Location = new System.Drawing.Point(61, 348);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(92, 24);
            this.autoLabel3.TabIndex = 3;
            this.autoLabel3.Text = "Password:";
            // 
            // AddNewAdmin
            // 
            this.AddNewAdmin.BackColor = System.Drawing.Color.DarkGreen;
            this.AddNewAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewAdmin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAdmin.ForeColor = System.Drawing.Color.White;
            this.AddNewAdmin.Location = new System.Drawing.Point(552, 339);
            this.AddNewAdmin.Name = "AddNewAdmin";
            this.AddNewAdmin.Size = new System.Drawing.Size(147, 33);
            this.AddNewAdmin.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.AddNewAdmin.Style.ForeColor = System.Drawing.Color.White;
            this.AddNewAdmin.TabIndex = 4;
            this.AddNewAdmin.Text = "Add Admin";
            this.AddNewAdmin.UseVisualStyleBackColor = false;
            this.AddNewAdmin.Click += new System.EventHandler(this.AddNewAdmin_Click);
            // 
            // UsernameTBox
            // 
            this.UsernameTBox.BeforeTouchSize = new System.Drawing.Size(264, 22);
            this.UsernameTBox.Location = new System.Drawing.Point(169, 302);
            this.UsernameTBox.Name = "UsernameTBox";
            this.UsernameTBox.Size = new System.Drawing.Size(264, 22);
            this.UsernameTBox.TabIndex = 5;
            // 
            // PasswodTBox
            // 
            this.PasswodTBox.BeforeTouchSize = new System.Drawing.Size(264, 22);
            this.PasswodTBox.Location = new System.Drawing.Point(169, 350);
            this.PasswodTBox.Name = "PasswodTBox";
            this.PasswodTBox.PasswordChar = '*';
            this.PasswodTBox.Size = new System.Drawing.Size(264, 22);
            this.PasswodTBox.TabIndex = 6;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(169, 378);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(62, 20);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "Show";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // EmptyAlert
            // 
            this.EmptyAlert.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyAlert.ForeColor = System.Drawing.Color.Red;
            this.EmptyAlert.Location = new System.Drawing.Point(495, 375);
            this.EmptyAlert.Name = "EmptyAlert";
            this.EmptyAlert.Size = new System.Drawing.Size(250, 20);
            this.EmptyAlert.TabIndex = 8;
            this.EmptyAlert.Text = "Username or password should not be empty";
            this.EmptyAlert.Visible = false;
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmptyAlert);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.PasswodTBox);
            this.Controls.Add(this.UsernameTBox);
            this.Controls.Add(this.AddNewAdmin);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.AllAdmins);
            this.Name = "AddAdmin";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "AddAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.AllAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswodTBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid AllAdmins;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.Controls.SfButton AddNewAdmin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UsernameTBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswodTBox;
        private System.Windows.Forms.CheckBox ShowPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel EmptyAlert;
    }
}
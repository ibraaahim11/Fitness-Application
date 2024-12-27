namespace FitnessApplication
{
    partial class ManageCoachReq
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
            this.NonAcceptedCoaches = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.CoachIDLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CoachIDCBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.AcceptSelCoach = new Syncfusion.WinForms.Controls.SfButton();
            this.RejectSelCoach = new Syncfusion.WinForms.Controls.SfButton();
            this.Firstname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Lastname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Certificate = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NonAcceptedCoaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachIDCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Certificate)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(338, 64);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(389, 27);
            this.autoLabel1.TabIndex = 11;
            this.autoLabel1.Text = "Non Accepted Coaches\' Requests";
            // 
            // NonAcceptedCoaches
            // 
            this.NonAcceptedCoaches.AccessibleName = "Table";
            this.NonAcceptedCoaches.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.NonAcceptedCoaches.Location = new System.Drawing.Point(320, 94);
            this.NonAcceptedCoaches.Name = "NonAcceptedCoaches";
            this.NonAcceptedCoaches.PreviewRowHeight = 35;
            this.NonAcceptedCoaches.Size = new System.Drawing.Size(425, 232);
            this.NonAcceptedCoaches.TabIndex = 12;
            this.NonAcceptedCoaches.Text = "sfDataGrid1";
            // 
            // CoachIDLabel
            // 
            this.CoachIDLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachIDLabel.ForeColor = System.Drawing.Color.Green;
            this.CoachIDLabel.Location = new System.Drawing.Point(28, 94);
            this.CoachIDLabel.Name = "CoachIDLabel";
            this.CoachIDLabel.Size = new System.Drawing.Size(76, 24);
            this.CoachIDLabel.TabIndex = 13;
            this.CoachIDLabel.Text = "CoachID";
            // 
            // CoachIDCBox
            // 
            this.CoachIDCBox.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.CoachIDCBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.CoachIDCBox.Location = new System.Drawing.Point(110, 94);
            this.CoachIDCBox.Name = "CoachIDCBox";
            this.CoachIDCBox.Size = new System.Drawing.Size(121, 31);
            this.CoachIDCBox.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CoachIDCBox.TabIndex = 16;
            this.CoachIDCBox.SelectedIndexChanged += new System.EventHandler(this.CoachIDCBox_SelectedIndexChanged);
            // 
            // AcceptSelCoach
            // 
            this.AcceptSelCoach.BackColor = System.Drawing.Color.DarkGreen;
            this.AcceptSelCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptSelCoach.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptSelCoach.ForeColor = System.Drawing.Color.White;
            this.AcceptSelCoach.Location = new System.Drawing.Point(28, 365);
            this.AcceptSelCoach.Name = "AcceptSelCoach";
            this.AcceptSelCoach.Size = new System.Drawing.Size(142, 32);
            this.AcceptSelCoach.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.AcceptSelCoach.Style.ForeColor = System.Drawing.Color.White;
            this.AcceptSelCoach.TabIndex = 17;
            this.AcceptSelCoach.Text = "Accept Coach";
            this.AcceptSelCoach.UseVisualStyleBackColor = false;
            this.AcceptSelCoach.Click += new System.EventHandler(this.AcceptSelCoach_Click);
            // 
            // RejectSelCoach
            // 
            this.RejectSelCoach.BackColor = System.Drawing.Color.DarkGreen;
            this.RejectSelCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectSelCoach.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectSelCoach.ForeColor = System.Drawing.Color.White;
            this.RejectSelCoach.Location = new System.Drawing.Point(200, 365);
            this.RejectSelCoach.Name = "RejectSelCoach";
            this.RejectSelCoach.Size = new System.Drawing.Size(142, 32);
            this.RejectSelCoach.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.RejectSelCoach.Style.ForeColor = System.Drawing.Color.White;
            this.RejectSelCoach.TabIndex = 18;
            this.RejectSelCoach.Text = "Reject Coach";
            this.RejectSelCoach.UseVisualStyleBackColor = false;
            this.RejectSelCoach.Click += new System.EventHandler(this.RejectSelCoach_Click);
            // 
            // Firstname
            // 
            this.Firstname.BeforeTouchSize = new System.Drawing.Size(175, 22);
            this.Firstname.Enabled = false;
            this.Firstname.Location = new System.Drawing.Point(117, 176);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(177, 22);
            this.Firstname.TabIndex = 19;
            // 
            // Lastname
            // 
            this.Lastname.BeforeTouchSize = new System.Drawing.Size(175, 22);
            this.Lastname.Enabled = false;
            this.Lastname.Location = new System.Drawing.Point(119, 245);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(175, 22);
            this.Lastname.TabIndex = 20;
            // 
            // Certificate
            // 
            this.Certificate.BeforeTouchSize = new System.Drawing.Size(175, 22);
            this.Certificate.Enabled = false;
            this.Certificate.Location = new System.Drawing.Point(119, 304);
            this.Certificate.Name = "Certificate";
            this.Certificate.Size = new System.Drawing.Size(175, 22);
            this.Certificate.TabIndex = 21;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(28, 176);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(83, 22);
            this.autoLabel2.TabIndex = 22;
            this.autoLabel2.Text = "First name";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Green;
            this.autoLabel3.Location = new System.Drawing.Point(28, 245);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(82, 22);
            this.autoLabel3.TabIndex = 23;
            this.autoLabel3.Text = "Last Name";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Green;
            this.autoLabel4.Location = new System.Drawing.Point(28, 304);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(76, 22);
            this.autoLabel4.TabIndex = 24;
            this.autoLabel4.Text = "Cerificate";
            // 
            // ManageCoachReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 507);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.Certificate);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.RejectSelCoach);
            this.Controls.Add(this.AcceptSelCoach);
            this.Controls.Add(this.CoachIDCBox);
            this.Controls.Add(this.CoachIDLabel);
            this.Controls.Add(this.NonAcceptedCoaches);
            this.Controls.Add(this.autoLabel1);
            this.Name = "ManageCoachReq";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ManageCoach";
            ((System.ComponentModel.ISupportInitialize)(this.NonAcceptedCoaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachIDCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Certificate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid NonAcceptedCoaches;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CoachIDLabel;
        private Syncfusion.WinForms.ListView.SfComboBox CoachIDCBox;
        private Syncfusion.WinForms.Controls.SfButton AcceptSelCoach;
        private Syncfusion.WinForms.Controls.SfButton RejectSelCoach;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Firstname;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Lastname;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Certificate;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
    }
}
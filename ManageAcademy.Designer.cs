namespace FitnessApplication
{
    partial class ManageAcademy
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
            this.NonAcceptedAcademy = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Certificate = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Firstname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.RejectSelAcademy = new Syncfusion.WinForms.Controls.SfButton();
            this.AcceptSelAcademy = new Syncfusion.WinForms.Controls.SfButton();
            this.AcademyIDCBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.CoachIDLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.NonAcceptedAcademy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Certificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademyIDCBox)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(325, 67);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(412, 27);
            this.autoLabel1.TabIndex = 12;
            this.autoLabel1.Text = "Non Accepted Academies\' Requests";
            // 
            // NonAcceptedAcademy
            // 
            this.NonAcceptedAcademy.AccessibleName = "Table";
            this.NonAcceptedAcademy.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.NonAcceptedAcademy.Location = new System.Drawing.Point(346, 97);
            this.NonAcceptedAcademy.Name = "NonAcceptedAcademy";
            this.NonAcceptedAcademy.PreviewRowHeight = 35;
            this.NonAcceptedAcademy.Size = new System.Drawing.Size(425, 232);
            this.NonAcceptedAcademy.TabIndex = 13;
            this.NonAcceptedAcademy.Text = "sfDataGrid1";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Green;
            this.autoLabel4.Location = new System.Drawing.Point(28, 307);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(76, 22);
            this.autoLabel4.TabIndex = 34;
            this.autoLabel4.Text = "Cerificate";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(26, 248);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(83, 22);
            this.autoLabel2.TabIndex = 32;
            this.autoLabel2.Text = "First name";
            // 
            // Certificate
            // 
            this.Certificate.BeforeTouchSize = new System.Drawing.Size(177, 22);
            this.Certificate.Enabled = false;
            this.Certificate.Location = new System.Drawing.Point(131, 307);
            this.Certificate.Name = "Certificate";
            this.Certificate.Size = new System.Drawing.Size(175, 22);
            this.Certificate.TabIndex = 31;
            // 
            // Firstname
            // 
            this.Firstname.BeforeTouchSize = new System.Drawing.Size(177, 22);
            this.Firstname.Enabled = false;
            this.Firstname.Location = new System.Drawing.Point(129, 248);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(177, 22);
            this.Firstname.TabIndex = 29;
            // 
            // RejectSelAcademy
            // 
            this.RejectSelAcademy.BackColor = System.Drawing.Color.DarkGreen;
            this.RejectSelAcademy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectSelAcademy.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectSelAcademy.ForeColor = System.Drawing.Color.White;
            this.RejectSelAcademy.Location = new System.Drawing.Point(248, 368);
            this.RejectSelAcademy.Name = "RejectSelAcademy";
            this.RejectSelAcademy.Size = new System.Drawing.Size(181, 32);
            this.RejectSelAcademy.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.RejectSelAcademy.Style.ForeColor = System.Drawing.Color.White;
            this.RejectSelAcademy.TabIndex = 28;
            this.RejectSelAcademy.Text = "Reject Academy";
            this.RejectSelAcademy.UseVisualStyleBackColor = false;
            this.RejectSelAcademy.Click += new System.EventHandler(this.RejectSelAcademy_Click);
            // 
            // AcceptSelAcademy
            // 
            this.AcceptSelAcademy.BackColor = System.Drawing.Color.DarkGreen;
            this.AcceptSelAcademy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptSelAcademy.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptSelAcademy.ForeColor = System.Drawing.Color.White;
            this.AcceptSelAcademy.Location = new System.Drawing.Point(28, 368);
            this.AcceptSelAcademy.Name = "AcceptSelAcademy";
            this.AcceptSelAcademy.Size = new System.Drawing.Size(179, 32);
            this.AcceptSelAcademy.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.AcceptSelAcademy.Style.ForeColor = System.Drawing.Color.White;
            this.AcceptSelAcademy.TabIndex = 27;
            this.AcceptSelAcademy.Text = "Accept Academy";
            this.AcceptSelAcademy.UseVisualStyleBackColor = false;
            this.AcceptSelAcademy.Click += new System.EventHandler(this.AcceptSelAcademy_Click);
            // 
            // AcademyIDCBox
            // 
            this.AcademyIDCBox.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.AcademyIDCBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.AcademyIDCBox.Location = new System.Drawing.Point(129, 180);
            this.AcademyIDCBox.Name = "AcademyIDCBox";
            this.AcademyIDCBox.Size = new System.Drawing.Size(121, 31);
            this.AcademyIDCBox.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AcademyIDCBox.TabIndex = 26;
            this.AcademyIDCBox.SelectedIndexChanged += new System.EventHandler(this.AcademyIDCBox_SelectedIndexChanged);
            // 
            // CoachIDLabel
            // 
            this.CoachIDLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachIDLabel.ForeColor = System.Drawing.Color.Green;
            this.CoachIDLabel.Location = new System.Drawing.Point(26, 180);
            this.CoachIDLabel.Name = "CoachIDLabel";
            this.CoachIDLabel.Size = new System.Drawing.Size(97, 24);
            this.CoachIDLabel.TabIndex = 25;
            this.CoachIDLabel.Text = "AcademyID";
            // 
            // ManageAcademy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.Certificate);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.RejectSelAcademy);
            this.Controls.Add(this.AcceptSelAcademy);
            this.Controls.Add(this.AcademyIDCBox);
            this.Controls.Add(this.CoachIDLabel);
            this.Controls.Add(this.NonAcceptedAcademy);
            this.Controls.Add(this.autoLabel1);
            this.Name = "ManageAcademy";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ManageAcademy";
            ((System.ComponentModel.ISupportInitialize)(this.NonAcceptedAcademy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Certificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Firstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcademyIDCBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid NonAcceptedAcademy;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Certificate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Firstname;
        private Syncfusion.WinForms.Controls.SfButton RejectSelAcademy;
        private Syncfusion.WinForms.Controls.SfButton AcceptSelAcademy;
        private Syncfusion.WinForms.ListView.SfComboBox AcademyIDCBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CoachIDLabel;
    }
}
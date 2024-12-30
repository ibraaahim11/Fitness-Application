namespace FitnessApplication
{
    partial class CoachMemberOverview
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
            this.CoachesRankings = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.CoachMembers = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CoachMems = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CoachIDCBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Fname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Lname = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.CoachesRankings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachIDCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lname)).BeginInit();
            this.SuspendLayout();
            // 
            // CoachesRankings
            // 
            this.CoachesRankings.AccessibleName = "Table";
            this.CoachesRankings.Location = new System.Drawing.Point(71, 32);
            this.CoachesRankings.Name = "CoachesRankings";
            this.CoachesRankings.PreviewRowHeight = 35;
            this.CoachesRankings.Size = new System.Drawing.Size(665, 176);
            this.CoachesRankings.TabIndex = 0;
            // 
            // CoachMembers
            // 
            this.CoachMembers.AccessibleName = "Table";
            this.CoachMembers.Location = new System.Drawing.Point(340, 255);
            this.CoachMembers.Name = "CoachMembers";
            this.CoachMembers.PreviewRowHeight = 35;
            this.CoachMembers.Size = new System.Drawing.Size(413, 157);
            this.CoachMembers.TabIndex = 1;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(296, 2);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(223, 27);
            this.autoLabel1.TabIndex = 2;
            this.autoLabel1.Text = "Coaches Rankings";
            // 
            // CoachMems
            // 
            this.CoachMems.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachMems.ForeColor = System.Drawing.Color.Green;
            this.CoachMems.Location = new System.Drawing.Point(441, 225);
            this.CoachMems.Name = "CoachMems";
            this.CoachMems.Size = new System.Drawing.Size(208, 27);
            this.CoachMems.TabIndex = 3;
            this.CoachMems.Text = "Coach\'s Members";
            // 
            // CoachIDCBox
            // 
            this.CoachIDCBox.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.CoachIDCBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.CoachIDCBox.Location = new System.Drawing.Point(138, 276);
            this.CoachIDCBox.Name = "CoachIDCBox";
            this.CoachIDCBox.Size = new System.Drawing.Size(161, 31);
            this.CoachIDCBox.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CoachIDCBox.TabIndex = 4;
            this.CoachIDCBox.SelectedIndexChanged += new System.EventHandler(this.CoachIDCBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(32, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coach ID: ";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(36, 338);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(98, 24);
            this.autoLabel2.TabIndex = 6;
            this.autoLabel2.Text = "First Name:";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Green;
            this.autoLabel3.Location = new System.Drawing.Point(35, 388);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(97, 24);
            this.autoLabel3.TabIndex = 7;
            this.autoLabel3.Text = "Last Name:";
            // 
            // Fname
            // 
            this.Fname.BeforeTouchSize = new System.Drawing.Size(161, 22);
            this.Fname.Enabled = false;
            this.Fname.Location = new System.Drawing.Point(138, 340);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(161, 22);
            this.Fname.TabIndex = 8;
            // 
            // Lname
            // 
            this.Lname.BeforeTouchSize = new System.Drawing.Size(161, 22);
            this.Lname.Enabled = false;
            this.Lname.Location = new System.Drawing.Point(138, 390);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(161, 22);
            this.Lname.TabIndex = 9;
            // 
            // CoachMemberOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoachIDCBox);
            this.Controls.Add(this.CoachMems);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.CoachMembers);
            this.Controls.Add(this.CoachesRankings);
            this.Name = "CoachMemberOverview";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "CoachMemberOverview";
            ((System.ComponentModel.ISupportInitialize)(this.CoachesRankings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachIDCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid CoachesRankings;
        private Syncfusion.WinForms.DataGrid.SfDataGrid CoachMembers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CoachMems;
        private Syncfusion.WinForms.ListView.SfComboBox CoachIDCBox;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Fname;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Lname;
    }
}
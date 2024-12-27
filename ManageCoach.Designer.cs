namespace FitnessApplication
{
    partial class ManageCoach
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
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveCoach = new MetroFramework.Controls.MetroButton();
            this.AllcoachesL = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AllAvaCoachesData = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.MemberlimitTBox = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.CoachIDCBox = new Syncfusion.WinForms.ListView.SfComboBox();
            this.CoachMemCount = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.CoachRating = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.EditMemberLimitB = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.AllAvaCoachesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberlimitTBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachIDCBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachMemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(61, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Removing Coach By the above CoachID";
            // 
            // RemoveCoach
            // 
            this.RemoveCoach.Location = new System.Drawing.Point(28, 388);
            this.RemoveCoach.Name = "RemoveCoach";
            this.RemoveCoach.Size = new System.Drawing.Size(314, 27);
            this.RemoveCoach.TabIndex = 16;
            this.RemoveCoach.Text = "Remove Coach";
            this.RemoveCoach.Click += new System.EventHandler(this.RemoveCoach_Click);
            // 
            // AllcoachesL
            // 
            this.AllcoachesL.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllcoachesL.ForeColor = System.Drawing.Color.Green;
            this.AllcoachesL.Location = new System.Drawing.Point(346, 24);
            this.AllcoachesL.Name = "AllcoachesL";
            this.AllcoachesL.Size = new System.Drawing.Size(147, 27);
            this.AllcoachesL.TabIndex = 17;
            this.AllcoachesL.Text = "All Coaches";
            // 
            // AllAvaCoachesData
            // 
            this.AllAvaCoachesData.AccessibleName = "Table";
            this.AllAvaCoachesData.Location = new System.Drawing.Point(139, 54);
            this.AllAvaCoachesData.Name = "AllAvaCoachesData";
            this.AllAvaCoachesData.PreviewRowHeight = 35;
            this.AllAvaCoachesData.Size = new System.Drawing.Size(530, 188);
            this.AllAvaCoachesData.TabIndex = 18;
            this.AllAvaCoachesData.Text = "sfDataGrid1";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(8, 263);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(76, 24);
            this.autoLabel1.TabIndex = 19;
            this.autoLabel1.Text = "CoachID";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(247, 265);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(171, 22);
            this.autoLabel2.TabIndex = 20;
            this.autoLabel2.Text = "Coach\'s Member Count";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Green;
            this.autoLabel3.Location = new System.Drawing.Point(555, 265);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(114, 22);
            this.autoLabel3.TabIndex = 21;
            this.autoLabel3.Text = "Coach\'s Rating";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Green;
            this.autoLabel4.Location = new System.Drawing.Point(8, 317);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(194, 22);
            this.autoLabel4.TabIndex = 22;
            this.autoLabel4.Text = "Edit Coach\'s Member Limit";
            // 
            // MemberlimitTBox
            // 
            this.MemberlimitTBox.AccessibilityEnabled = true;
            this.MemberlimitTBox.BeforeTouchSize = new System.Drawing.Size(100, 22);
            this.MemberlimitTBox.IntegerValue = ((long)(0));
            this.MemberlimitTBox.Location = new System.Drawing.Point(231, 317);
            this.MemberlimitTBox.Name = "MemberlimitTBox";
            this.MemberlimitTBox.Size = new System.Drawing.Size(100, 22);
            this.MemberlimitTBox.TabIndex = 24;
            this.MemberlimitTBox.Text = "0";
            // 
            // CoachIDCBox
            // 
            this.CoachIDCBox.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.CoachIDCBox.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.CoachIDCBox.Location = new System.Drawing.Point(101, 263);
            this.CoachIDCBox.Name = "CoachIDCBox";
            this.CoachIDCBox.Size = new System.Drawing.Size(121, 31);
            this.CoachIDCBox.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CoachIDCBox.TabIndex = 25;
            this.CoachIDCBox.SelectedIndexChanged += new System.EventHandler(this.CoachIDCBox_SelectedIndexChanged);
            // 
            // CoachMemCount
            // 
            this.CoachMemCount.AccessibilityEnabled = true;
            this.CoachMemCount.BeforeTouchSize = new System.Drawing.Size(100, 22);
            this.CoachMemCount.Enabled = false;
            this.CoachMemCount.IntegerValue = ((long)(0));
            this.CoachMemCount.Location = new System.Drawing.Point(435, 265);
            this.CoachMemCount.Name = "CoachMemCount";
            this.CoachMemCount.Size = new System.Drawing.Size(100, 22);
            this.CoachMemCount.TabIndex = 28;
            this.CoachMemCount.Text = "0";
            // 
            // CoachRating
            // 
            this.CoachRating.AccessibilityEnabled = true;
            this.CoachRating.BeforeTouchSize = new System.Drawing.Size(100, 22);
            this.CoachRating.Enabled = false;
            this.CoachRating.IntegerValue = ((long)(0));
            this.CoachRating.Location = new System.Drawing.Point(675, 265);
            this.CoachRating.Name = "CoachRating";
            this.CoachRating.Size = new System.Drawing.Size(100, 22);
            this.CoachRating.TabIndex = 29;
            this.CoachRating.Text = "0";
            // 
            // EditMemberLimitB
            // 
            this.EditMemberLimitB.BackColor = System.Drawing.Color.DarkGreen;
            this.EditMemberLimitB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMemberLimitB.ForeColor = System.Drawing.Color.White;
            this.EditMemberLimitB.Location = new System.Drawing.Point(379, 317);
            this.EditMemberLimitB.Name = "EditMemberLimitB";
            this.EditMemberLimitB.Size = new System.Drawing.Size(128, 22);
            this.EditMemberLimitB.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.EditMemberLimitB.Style.ForeColor = System.Drawing.Color.White;
            this.EditMemberLimitB.TabIndex = 30;
            this.EditMemberLimitB.Text = "Edit";
            this.EditMemberLimitB.UseVisualStyleBackColor = false;
            this.EditMemberLimitB.Click += new System.EventHandler(this.EditMemberLimitB_Click);
            // 
            // ManageCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditMemberLimitB);
            this.Controls.Add(this.CoachRating);
            this.Controls.Add(this.CoachMemCount);
            this.Controls.Add(this.CoachIDCBox);
            this.Controls.Add(this.MemberlimitTBox);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.AllAvaCoachesData);
            this.Controls.Add(this.AllcoachesL);
            this.Controls.Add(this.RemoveCoach);
            this.Controls.Add(this.label2);
            this.Name = "ManageCoach";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ManageCoach";
            ((System.ComponentModel.ISupportInitialize)(this.AllAvaCoachesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberlimitTBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachIDCBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachMemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoachRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton RemoveCoach;
        private Syncfusion.Windows.Forms.Tools.AutoLabel AllcoachesL;
        private Syncfusion.WinForms.DataGrid.SfDataGrid AllAvaCoachesData;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox MemberlimitTBox;
        private Syncfusion.WinForms.ListView.SfComboBox CoachIDCBox;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox CoachMemCount;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox CoachRating;
        private Syncfusion.WinForms.Controls.SfButton EditMemberLimitB;
    }
}
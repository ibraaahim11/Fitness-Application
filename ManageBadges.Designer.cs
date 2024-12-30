namespace FitnessApplication
{
    partial class ManageBadges
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
            this.AllBadges = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.BadgeNameTB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DescriptionTB = new System.Windows.Forms.RichTextBox();
            this.AddBadge = new Syncfusion.WinForms.Controls.SfButton();
            this.RemoveBadge = new Syncfusion.WinForms.Controls.SfButton();
            this.Emptyalert = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.BadgeIDCB = new Syncfusion.WinForms.ListView.SfComboBox();
            this.PointsTB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.AllBadges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeNameTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeIDCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTB)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBadges
            // 
            this.AllBadges.AccessibleName = "Table";
            this.AllBadges.Location = new System.Drawing.Point(399, 73);
            this.AllBadges.Name = "AllBadges";
            this.AllBadges.PreviewRowHeight = 35;
            this.AllBadges.Size = new System.Drawing.Size(371, 189);
            this.AllBadges.TabIndex = 0;
            this.AllBadges.Text = "sfDataGrid1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(523, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Badges";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(12, 86);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(114, 24);
            this.autoLabel1.TabIndex = 2;
            this.autoLabel1.Text = "Badge Name:";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(12, 140);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(103, 24);
            this.autoLabel2.TabIndex = 3;
            this.autoLabel2.Text = "Description:";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.Color.Green;
            this.autoLabel3.Location = new System.Drawing.Point(12, 262);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(128, 24);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "Points Needed:";
            // 
            // BadgeNameTB
            // 
            this.BadgeNameTB.BeforeTouchSize = new System.Drawing.Size(212, 22);
            this.BadgeNameTB.Location = new System.Drawing.Point(152, 88);
            this.BadgeNameTB.Name = "BadgeNameTB";
            this.BadgeNameTB.Size = new System.Drawing.Size(212, 22);
            this.BadgeNameTB.TabIndex = 6;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(152, 140);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(212, 96);
            this.DescriptionTB.TabIndex = 9;
            this.DescriptionTB.Text = "";
            // 
            // AddBadge
            // 
            this.AddBadge.BackColor = System.Drawing.Color.DarkGreen;
            this.AddBadge.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBadge.ForeColor = System.Drawing.Color.White;
            this.AddBadge.Location = new System.Drawing.Point(12, 310);
            this.AddBadge.Name = "AddBadge";
            this.AddBadge.Size = new System.Drawing.Size(153, 34);
            this.AddBadge.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.AddBadge.Style.ForeColor = System.Drawing.Color.White;
            this.AddBadge.TabIndex = 13;
            this.AddBadge.Text = "Add Badge";
            this.AddBadge.UseVisualStyleBackColor = false;
            this.AddBadge.Click += new System.EventHandler(this.AddBadge_Click);
            // 
            // RemoveBadge
            // 
            this.RemoveBadge.BackColor = System.Drawing.Color.DarkGreen;
            this.RemoveBadge.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBadge.ForeColor = System.Drawing.Color.White;
            this.RemoveBadge.Location = new System.Drawing.Point(186, 373);
            this.RemoveBadge.Name = "RemoveBadge";
            this.RemoveBadge.Size = new System.Drawing.Size(151, 31);
            this.RemoveBadge.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.RemoveBadge.Style.ForeColor = System.Drawing.Color.White;
            this.RemoveBadge.TabIndex = 14;
            this.RemoveBadge.Text = "Remove Badge";
            this.RemoveBadge.UseVisualStyleBackColor = false;
            this.RemoveBadge.Click += new System.EventHandler(this.RemoveBadge_Click);
            // 
            // Emptyalert
            // 
            this.Emptyalert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emptyalert.ForeColor = System.Drawing.Color.Red;
            this.Emptyalert.Location = new System.Drawing.Point(186, 327);
            this.Emptyalert.Name = "Emptyalert";
            this.Emptyalert.Size = new System.Drawing.Size(300, 17);
            this.Emptyalert.TabIndex = 15;
            this.Emptyalert.Text = "Badge Name or Description cannot be empty";
            this.Emptyalert.Visible = false;
            // 
            // BadgeIDCB
            // 
            this.BadgeIDCB.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.BadgeIDCB.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.BadgeIDCB.Location = new System.Drawing.Point(12, 373);
            this.BadgeIDCB.Name = "BadgeIDCB";
            this.BadgeIDCB.Size = new System.Drawing.Size(121, 31);
            this.BadgeIDCB.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BadgeIDCB.TabIndex = 16;
            // 
            // PointsTB
            // 
            this.PointsTB.BeforeTouchSize = new System.Drawing.Size(212, 22);
            this.PointsTB.Location = new System.Drawing.Point(152, 263);
            this.PointsTB.Name = "PointsTB";
            this.PointsTB.Size = new System.Drawing.Size(212, 22);
            this.PointsTB.TabIndex = 17;
            // 
            // ManageBadges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PointsTB);
            this.Controls.Add(this.BadgeIDCB);
            this.Controls.Add(this.Emptyalert);
            this.Controls.Add(this.RemoveBadge);
            this.Controls.Add(this.AddBadge);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.BadgeNameTB);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllBadges);
            this.Name = "ManageBadges";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ManageBadges";
            ((System.ComponentModel.ISupportInitialize)(this.AllBadges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeNameTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BadgeIDCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid AllBadges;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt BadgeNameTB;
        private System.Windows.Forms.RichTextBox DescriptionTB;
        private Syncfusion.WinForms.Controls.SfButton AddBadge;
        private Syncfusion.WinForms.Controls.SfButton RemoveBadge;
        private Syncfusion.Windows.Forms.Tools.AutoLabel Emptyalert;
        private Syncfusion.WinForms.ListView.SfComboBox BadgeIDCB;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PointsTB;
    }
}
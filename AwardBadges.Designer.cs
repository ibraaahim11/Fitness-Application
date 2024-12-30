namespace FitnessApplication
{
    partial class AwardBadges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.memberdatagrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.badgedatagrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.membercombo = new System.Windows.Forms.ComboBox();
            this.badgecombo = new System.Windows.Forms.ComboBox();
            this.giveawardbutton = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.memberdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(450, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Badges";
            // 
            // memberdatagrid
            // 
            this.memberdatagrid.AccessibleName = "Table";
            this.memberdatagrid.Location = new System.Drawing.Point(11, 99);
            this.memberdatagrid.Name = "memberdatagrid";
            this.memberdatagrid.PreviewRowHeight = 42;
            this.memberdatagrid.Size = new System.Drawing.Size(330, 150);
            this.memberdatagrid.TabIndex = 2;
            this.memberdatagrid.Text = "sfDataGrid1";
            // 
            // badgedatagrid
            // 
            this.badgedatagrid.AccessibleName = "Table";
            this.badgedatagrid.Location = new System.Drawing.Point(456, 99);
            this.badgedatagrid.Name = "badgedatagrid";
            this.badgedatagrid.PreviewRowHeight = 42;
            this.badgedatagrid.Size = new System.Drawing.Size(298, 150);
            this.badgedatagrid.TabIndex = 3;
            this.badgedatagrid.Text = "sfDataGrid2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(6, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Members";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(451, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Badges";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // membercombo
            // 
            this.membercombo.FormattingEnabled = true;
            this.membercombo.Location = new System.Drawing.Point(153, 284);
            this.membercombo.Name = "membercombo";
            this.membercombo.Size = new System.Drawing.Size(121, 28);
            this.membercombo.TabIndex = 6;
            // 
            // badgecombo
            // 
            this.badgecombo.FormattingEnabled = true;
            this.badgecombo.Location = new System.Drawing.Point(555, 281);
            this.badgecombo.Name = "badgecombo";
            this.badgecombo.Size = new System.Drawing.Size(121, 28);
            this.badgecombo.TabIndex = 7;
            // 
            // giveawardbutton
            // 
            this.giveawardbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.giveawardbutton.Location = new System.Drawing.Point(11, 359);
            this.giveawardbutton.Name = "giveawardbutton";
            this.giveawardbutton.Size = new System.Drawing.Size(188, 54);
            this.giveawardbutton.TabIndex = 8;
            this.giveawardbutton.Text = "Award Badge";
            this.giveawardbutton.Click += new System.EventHandler(this.giveawardbutton_Click);
            // 
            // AwardBadges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giveawardbutton);
            this.Controls.Add(this.badgecombo);
            this.Controls.Add(this.membercombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.badgedatagrid);
            this.Controls.Add(this.memberdatagrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AwardBadges";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "AwardBadges";
            this.Load += new System.EventHandler(this.AwardBadges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgedatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid memberdatagrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid badgedatagrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox membercombo;
        private System.Windows.Forms.ComboBox badgecombo;
        private Syncfusion.WinForms.Controls.SfButton giveawardbutton;
    }
}
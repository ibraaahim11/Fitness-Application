namespace FitnessApplication
{
    partial class Badges
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
            this.memberBadgesdatagrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.memberBadgesdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // memberBadgesdatagrid
            // 
            this.memberBadgesdatagrid.AccessibleName = "Table";
            this.memberBadgesdatagrid.AllowEditing = false;
            this.memberBadgesdatagrid.Location = new System.Drawing.Point(106, 131);
            this.memberBadgesdatagrid.Name = "memberBadgesdatagrid";
            this.memberBadgesdatagrid.PreviewRowHeight = 42;
            this.memberBadgesdatagrid.Size = new System.Drawing.Size(550, 278);
            this.memberBadgesdatagrid.TabIndex = 0;
            this.memberBadgesdatagrid.Text = "Badges";
            this.memberBadgesdatagrid.Click += new System.EventHandler(this.sfDataGrid1_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(327, 56);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(102, 20);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "Your Badges";
            // 
            // Badges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.memberBadgesdatagrid);
            this.Name = "Badges";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Badges";
            this.Load += new System.EventHandler(this.Badges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBadgesdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid memberBadgesdatagrid;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
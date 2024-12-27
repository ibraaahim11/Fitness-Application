namespace FitnessApplication
{
    partial class ViewMember
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
            this.Viewbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.usernamecombo = new System.Windows.Forms.ComboBox();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Member Name ";
            // 
            // Viewbutton
            // 
            this.Viewbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Viewbutton.Location = new System.Drawing.Point(9, 95);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(136, 46);
            this.Viewbutton.TabIndex = 3;
            this.Viewbutton.Text = "View Details";
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
            // 
            // usernamecombo
            // 
            this.usernamecombo.FormattingEnabled = true;
            this.usernamecombo.Location = new System.Drawing.Point(254, 33);
            this.usernamecombo.Name = "usernamecombo";
            this.usernamecombo.Size = new System.Drawing.Size(121, 28);
            this.usernamecombo.TabIndex = 5;
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Location = new System.Drawing.Point(9, 170);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 42;
            this.sfDataGrid1.Size = new System.Drawing.Size(721, 204);
            this.sfDataGrid1.TabIndex = 6;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // ViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 540);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.usernamecombo);
            this.Controls.Add(this.Viewbutton);
            this.Controls.Add(this.label1);
            this.Name = "ViewMember";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ViewMember";
            this.Load += new System.EventHandler(this.ViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton Viewbutton;
        private System.Windows.Forms.ComboBox usernamecombo;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
    }
}
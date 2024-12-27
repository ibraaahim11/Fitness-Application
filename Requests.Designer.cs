namespace FitnessApplication
{
    partial class Requests
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
            this.Acceptbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.Declinebutton = new Syncfusion.WinForms.Controls.SfButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.idtextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Acceptbutton
            // 
            this.Acceptbutton.Enabled = false;
            this.Acceptbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Acceptbutton.Location = new System.Drawing.Point(581, 286);
            this.Acceptbutton.Name = "Acceptbutton";
            this.Acceptbutton.Size = new System.Drawing.Size(165, 46);
            this.Acceptbutton.TabIndex = 0;
            this.Acceptbutton.Text = "Accept Request";
            this.Acceptbutton.Click += new System.EventHandler(this.Acceptbutton_Click);
            // 
            // Declinebutton
            // 
            this.Declinebutton.Enabled = false;
            this.Declinebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Declinebutton.Location = new System.Drawing.Point(581, 338);
            this.Declinebutton.Name = "Declinebutton";
            this.Declinebutton.Size = new System.Drawing.Size(165, 46);
            this.Declinebutton.TabIndex = 1;
            this.Declinebutton.Text = "Decline Request";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Requests";
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.Location = new System.Drawing.Point(11, 90);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 42;
            this.sfDataGrid1.Size = new System.Drawing.Size(312, 150);
            this.sfDataGrid1.TabIndex = 4;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(320, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Member Username";
            // 
            // idtextbox
            // 
            this.idtextbox.BeforeTouchSize = new System.Drawing.Size(100, 26);
            this.idtextbox.Location = new System.Drawing.Point(387, 306);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(100, 26);
            this.idtextbox.TabIndex = 6;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Declinebutton);
            this.Controls.Add(this.Acceptbutton);
            this.Name = "Requests";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton Acceptbutton;
        private Syncfusion.WinForms.Controls.SfButton Declinebutton;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt idtextbox;
    }
}
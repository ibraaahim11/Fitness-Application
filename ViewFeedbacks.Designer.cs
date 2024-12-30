namespace FitnessApplication
{
    partial class ViewFeedbacks
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
            this.AllFeedbacks = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AllFeedbacks)).BeginInit();
            this.SuspendLayout();
            // 
            // AllFeedbacks
            // 
            this.AllFeedbacks.AccessibleName = "Table";
            this.AllFeedbacks.Location = new System.Drawing.Point(68, 85);
            this.AllFeedbacks.Name = "AllFeedbacks";
            this.AllFeedbacks.PreviewRowHeight = 35;
            this.AllFeedbacks.Size = new System.Drawing.Size(662, 224);
            this.AllFeedbacks.TabIndex = 0;
            this.AllFeedbacks.Text = "sfDataGrid1";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(302, 36);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(204, 33);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "All Feedbacks";
            // 
            // ViewFeedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.AllFeedbacks);
            this.Name = "ViewFeedbacks";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "ViewFeedbacks";
            ((System.ComponentModel.ISupportInitialize)(this.AllFeedbacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid AllFeedbacks;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
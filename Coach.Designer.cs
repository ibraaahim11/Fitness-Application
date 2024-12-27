namespace FitnessApplication
{
    partial class Coach
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
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.Viewprofile = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.requestsbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.Postmealbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Welcomelabel.Location = new System.Drawing.Point(30, 49);
            this.Welcomelabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(211, 50);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome";
            // 
            // Viewprofile
            // 
            this.Viewprofile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Viewprofile.Location = new System.Drawing.Point(39, 139);
            this.Viewprofile.Name = "Viewprofile";
            this.Viewprofile.Size = new System.Drawing.Size(161, 54);
            this.Viewprofile.TabIndex = 1;
            this.Viewprofile.Text = "View Profile ";
            this.Viewprofile.Click += new System.EventHandler(this.Viewprofile_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(262, 139);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(202, 54);
            this.sfButton1.TabIndex = 2;
            this.sfButton1.Text = "View Member Details";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton2.Location = new System.Drawing.Point(546, 139);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(199, 54);
            this.sfButton2.TabIndex = 3;
            this.sfButton2.Text = "Create Challenge ";
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // requestsbutton
            // 
            this.requestsbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.requestsbutton.Location = new System.Drawing.Point(821, 139);
            this.requestsbutton.Name = "requestsbutton";
            this.requestsbutton.Size = new System.Drawing.Size(175, 54);
            this.requestsbutton.TabIndex = 4;
            this.requestsbutton.Text = "View Requests";
            this.requestsbutton.Click += new System.EventHandler(this.requestsbutton_Click);
            // 
            // Postmealbutton
            // 
            this.Postmealbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Postmealbutton.Location = new System.Drawing.Point(39, 215);
            this.Postmealbutton.Name = "Postmealbutton";
            this.Postmealbutton.Size = new System.Drawing.Size(161, 56);
            this.Postmealbutton.TabIndex = 5;
            this.Postmealbutton.Text = "Post Meal";
            this.Postmealbutton.Click += new System.EventHandler(this.Postmealbutton_Click);
            // 
            // Coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.Postmealbutton);
            this.Controls.Add(this.requestsbutton);
            this.Controls.Add(this.sfButton2);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.Viewprofile);
            this.Controls.Add(this.Welcomelabel);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Coach";
            this.Style.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.Coach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private Syncfusion.WinForms.Controls.SfButton Viewprofile;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton requestsbutton;
        private Syncfusion.WinForms.Controls.SfButton Postmealbutton;
    }
}
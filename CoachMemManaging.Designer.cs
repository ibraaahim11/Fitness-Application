namespace FitnessApplication
{
    partial class CoachMemManaging
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
            this.ManageCoachRequests = new Syncfusion.WinForms.Controls.SfButton();
            this.ManageCoaches = new Syncfusion.WinForms.Controls.SfButton();
            this.CoachMemberOverview = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(57, 71);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(203, 27);
            this.autoLabel1.TabIndex = 4;
            this.autoLabel1.Text = "Manage Coaches";
            // 
            // ManageCoachRequests
            // 
            this.ManageCoachRequests.BackColor = System.Drawing.Color.DarkGreen;
            this.ManageCoachRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageCoachRequests.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCoachRequests.ForeColor = System.Drawing.Color.White;
            this.ManageCoachRequests.Location = new System.Drawing.Point(42, 127);
            this.ManageCoachRequests.Name = "ManageCoachRequests";
            this.ManageCoachRequests.Size = new System.Drawing.Size(238, 42);
            this.ManageCoachRequests.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.ManageCoachRequests.Style.ForeColor = System.Drawing.Color.White;
            this.ManageCoachRequests.TabIndex = 5;
            this.ManageCoachRequests.Text = "Manage Coaches\' requests";
            this.ManageCoachRequests.UseVisualStyleBackColor = false;
            this.ManageCoachRequests.Click += new System.EventHandler(this.ManageCoachRequests_Click);
            // 
            // ManageCoaches
            // 
            this.ManageCoaches.BackColor = System.Drawing.Color.DarkGreen;
            this.ManageCoaches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageCoaches.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCoaches.ForeColor = System.Drawing.Color.White;
            this.ManageCoaches.Location = new System.Drawing.Point(42, 210);
            this.ManageCoaches.Name = "ManageCoaches";
            this.ManageCoaches.Size = new System.Drawing.Size(238, 39);
            this.ManageCoaches.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.ManageCoaches.Style.ForeColor = System.Drawing.Color.White;
            this.ManageCoaches.TabIndex = 6;
            this.ManageCoaches.Text = "Manage Coaches";
            this.ManageCoaches.UseVisualStyleBackColor = false;
            this.ManageCoaches.Click += new System.EventHandler(this.ManageCoaches_Click);
            // 
            // CoachMemberOverview
            // 
            this.CoachMemberOverview.BackColor = System.Drawing.Color.DarkGreen;
            this.CoachMemberOverview.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachMemberOverview.ForeColor = System.Drawing.Color.White;
            this.CoachMemberOverview.Location = new System.Drawing.Point(280, 288);
            this.CoachMemberOverview.Name = "CoachMemberOverview";
            this.CoachMemberOverview.Size = new System.Drawing.Size(238, 39);
            this.CoachMemberOverview.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.CoachMemberOverview.Style.ForeColor = System.Drawing.Color.White;
            this.CoachMemberOverview.TabIndex = 7;
            this.CoachMemberOverview.Text = "Coach-Member Overview";
            this.CoachMemberOverview.UseVisualStyleBackColor = false;
            this.CoachMemberOverview.Click += new System.EventHandler(this.CoachMemberOverview_Click);
            // 
            // CoachMemManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoachMemberOverview);
            this.Controls.Add(this.ManageCoaches);
            this.Controls.Add(this.ManageCoachRequests);
            this.Controls.Add(this.autoLabel1);
            this.Name = "CoachMemManaging";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "CoachMemManagin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton ManageCoachRequests;
        private Syncfusion.WinForms.Controls.SfButton ManageCoaches;
        private Syncfusion.WinForms.Controls.SfButton CoachMemberOverview;
    }
}
namespace FitnessApplication
{
    partial class Members
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
            this.memberviewprofilebutton = new Syncfusion.WinForms.Controls.SfButton();
            this.memberlogbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.membercoachesbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.memberchallengesbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.AutoSize = false;
            this.autoLabel1.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Sienna;
            this.autoLabel1.Location = new System.Drawing.Point(5, 24);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(313, 73);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "Welcome , Name";
            // 
            // memberviewprofilebutton
            // 
            this.memberviewprofilebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.memberviewprofilebutton.Location = new System.Drawing.Point(302, 100);
            this.memberviewprofilebutton.Name = "memberviewprofilebutton";
            this.memberviewprofilebutton.Size = new System.Drawing.Size(172, 60);
            this.memberviewprofilebutton.TabIndex = 3;
            this.memberviewprofilebutton.Text = "View profile";
            this.memberviewprofilebutton.Click += new System.EventHandler(this.memberviewprofilebutton_Click);
            // 
            // memberlogbutton
            // 
            this.memberlogbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.memberlogbutton.Location = new System.Drawing.Point(302, 210);
            this.memberlogbutton.Name = "memberlogbutton";
            this.memberlogbutton.Size = new System.Drawing.Size(172, 60);
            this.memberlogbutton.TabIndex = 4;
            this.memberlogbutton.Text = "Log now!";
            this.memberlogbutton.Click += new System.EventHandler(this.memberlogbutton_Click);
            // 
            // membercoachesbutton
            // 
            this.membercoachesbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.membercoachesbutton.Location = new System.Drawing.Point(302, 326);
            this.membercoachesbutton.Name = "membercoachesbutton";
            this.membercoachesbutton.Size = new System.Drawing.Size(172, 60);
            this.membercoachesbutton.TabIndex = 5;
            this.membercoachesbutton.Text = "Coaches";
            // 
            // memberchallengesbutton
            // 
            this.memberchallengesbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.memberchallengesbutton.Location = new System.Drawing.Point(302, 442);
            this.memberchallengesbutton.Name = "memberchallengesbutton";
            this.memberchallengesbutton.Size = new System.Drawing.Size(172, 60);
            this.memberchallengesbutton.TabIndex = 6;
            this.memberchallengesbutton.Text = "Available Challanges";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.memberchallengesbutton);
            this.Controls.Add(this.membercoachesbutton);
            this.Controls.Add(this.memberlogbutton);
            this.Controls.Add(this.memberviewprofilebutton);
            this.Controls.Add(this.autoLabel1);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.Name = "Members";
            this.Style.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Style.ForeColor = System.Drawing.Color.RosyBrown;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Members_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton memberviewprofilebutton;
        private Syncfusion.WinForms.Controls.SfButton memberlogbutton;
        private Syncfusion.WinForms.Controls.SfButton membercoachesbutton;
        private Syncfusion.WinForms.Controls.SfButton memberchallengesbutton;
    }
}
namespace FitnessApplication
{
    partial class MemberStatistics
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
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SuspendLayout();
            // 
            // autoLabel4
            // 
            this.autoLabel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autoLabel4.Location = new System.Drawing.Point(128, 152);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(175, 16);
            this.autoLabel4.TabIndex = 0;
            this.autoLabel4.Text = "Your Average Calorie Intake";
            // 
            // autoLabel5
            // 
            this.autoLabel5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autoLabel5.Location = new System.Drawing.Point(128, 213);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(189, 16);
            this.autoLabel5.TabIndex = 1;
            this.autoLabel5.Text = "Your Average Calories Burned";
            // 
            // autoLabel6
            // 
            this.autoLabel6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autoLabel6.Location = new System.Drawing.Point(386, 213);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(189, 16);
            this.autoLabel6.TabIndex = 2;
            this.autoLabel6.Text = "Your Average Calories Burned";
            // 
            // autoLabel
            // 
            this.autoLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autoLabel.Location = new System.Drawing.Point(386, 152);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(189, 16);
            this.autoLabel.TabIndex = 3;
            this.autoLabel.Text = "Your Average Calories Burned";
            // 
            // autoLabel7
            // 
            this.autoLabel7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.autoLabel7.Location = new System.Drawing.Point(273, 71);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(94, 16);
            this.autoLabel7.TabIndex = 4;
            this.autoLabel7.Text = "YOUR STATS";
            // 
            // MemberStatistics
            // 
            this.ClientSize = new System.Drawing.Size(714, 382);
            this.Controls.Add(this.autoLabel7);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.autoLabel6);
            this.Controls.Add(this.autoLabel5);
            this.Controls.Add(this.autoLabel4);
            this.Name = "MemberStatistics";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "YOUR STATS";
            this.Load += new System.EventHandler(this.MemberStatistics_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel averagecaloriestext;
        private Syncfusion.Windows.Forms.Tools.AutoLabel averageburnedtext;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
    }
}
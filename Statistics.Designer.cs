namespace FitnessApplication
{
    partial class Statistics
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
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.averagecaloriestext = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.averageburnedtext = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(72, 189);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(208, 20);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Your Average Calorie Intake";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Location = new System.Drawing.Point(72, 283);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(223, 20);
            this.autoLabel2.TabIndex = 1;
            this.autoLabel2.Text = "Your Average Calories Burned";
            // 
            // averagecaloriestext
            // 
            this.averagecaloriestext.Location = new System.Drawing.Point(432, 189);
            this.averagecaloriestext.Name = "averagecaloriestext";
            this.averagecaloriestext.Size = new System.Drawing.Size(89, 20);
            this.averagecaloriestext.TabIndex = 2;
            this.averagecaloriestext.Text = "autoLabel3";
            // 
            // averageburnedtext
            // 
            this.averageburnedtext.Location = new System.Drawing.Point(432, 283);
            this.averageburnedtext.Name = "averageburnedtext";
            this.averageburnedtext.Size = new System.Drawing.Size(89, 20);
            this.averageburnedtext.TabIndex = 3;
            this.averageburnedtext.Text = "autoLabel4";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(293, 70);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(111, 20);
            this.autoLabel3.TabIndex = 4;
            this.autoLabel3.Text = "YOUR STATS";
            this.autoLabel3.Click += new System.EventHandler(this.autoLabel3_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.averageburnedtext);
            this.Controls.Add(this.averagecaloriestext);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.autoLabel1);
            this.Name = "Statistics";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel averagecaloriestext;
        private Syncfusion.Windows.Forms.Tools.AutoLabel averageburnedtext;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
    }
}
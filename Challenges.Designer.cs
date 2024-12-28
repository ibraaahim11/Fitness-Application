namespace FitnessApplication
{
    partial class Challenges
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.challengenametextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pointsrewarded = new System.Windows.Forms.NumericUpDown();
            this.startdatepicker = new System.Windows.Forms.DateTimePicker();
            this.enddatepicker = new System.Windows.Forms.DateTimePicker();
            this.Createbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptiontextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.challengenametextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsrewarded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptiontextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Challenge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(40, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Challenge Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(40, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Points Rewarded";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(649, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(649, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // challengenametextbox
            // 
            this.challengenametextbox.BeforeTouchSize = new System.Drawing.Size(371, 26);
            this.challengenametextbox.Location = new System.Drawing.Point(259, 131);
            this.challengenametextbox.Name = "challengenametextbox";
            this.challengenametextbox.Size = new System.Drawing.Size(231, 26);
            this.challengenametextbox.TabIndex = 5;
            // 
            // pointsrewarded
            // 
            this.pointsrewarded.Location = new System.Drawing.Point(259, 213);
            this.pointsrewarded.Name = "pointsrewarded";
            this.pointsrewarded.Size = new System.Drawing.Size(120, 26);
            this.pointsrewarded.TabIndex = 6;
            // 
            // startdatepicker
            // 
            this.startdatepicker.Location = new System.Drawing.Point(827, 129);
            this.startdatepicker.Name = "startdatepicker";
            this.startdatepicker.Size = new System.Drawing.Size(200, 26);
            this.startdatepicker.TabIndex = 7;
            // 
            // enddatepicker
            // 
            this.enddatepicker.Location = new System.Drawing.Point(827, 224);
            this.enddatepicker.Name = "enddatepicker";
            this.enddatepicker.Size = new System.Drawing.Size(200, 26);
            this.enddatepicker.TabIndex = 8;
            // 
            // Createbutton
            // 
            this.Createbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Createbutton.Location = new System.Drawing.Point(45, 379);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(168, 78);
            this.Createbutton.TabIndex = 9;
            this.Createbutton.Text = "Create";
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(40, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // descriptiontextbox
            // 
            this.descriptiontextbox.BeforeTouchSize = new System.Drawing.Size(371, 26);
            this.descriptiontextbox.Location = new System.Drawing.Point(259, 293);
            this.descriptiontextbox.Name = "descriptiontextbox";
            this.descriptiontextbox.Size = new System.Drawing.Size(371, 26);
            this.descriptiontextbox.TabIndex = 11;
            // 
            // Challenges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 647);
            this.Controls.Add(this.descriptiontextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.enddatepicker);
            this.Controls.Add(this.startdatepicker);
            this.Controls.Add(this.pointsrewarded);
            this.Controls.Add(this.challengenametextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Challenges";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Challenges";
            this.Load += new System.EventHandler(this.Challenges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.challengenametextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsrewarded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptiontextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt challengenametextbox;
        private System.Windows.Forms.NumericUpDown pointsrewarded;
        private System.Windows.Forms.DateTimePicker startdatepicker;
        private System.Windows.Forms.DateTimePicker enddatepicker;
        private Syncfusion.WinForms.Controls.SfButton Createbutton;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt descriptiontextbox;
    }
}
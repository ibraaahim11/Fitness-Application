namespace FitnessApplication
{
    partial class offerplans
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
            this.membercombo = new System.Windows.Forms.ComboBox();
            this.exercisecombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.offerbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.caloriepicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.caloriepicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suggested Exercise";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // membercombo
            // 
            this.membercombo.FormattingEnabled = true;
            this.membercombo.Location = new System.Drawing.Point(229, 33);
            this.membercombo.Name = "membercombo";
            this.membercombo.Size = new System.Drawing.Size(121, 28);
            this.membercombo.TabIndex = 2;
            // 
            // exercisecombo
            // 
            this.exercisecombo.FormattingEnabled = true;
            this.exercisecombo.Location = new System.Drawing.Point(26, 189);
            this.exercisecombo.Name = "exercisecombo";
            this.exercisecombo.Size = new System.Drawing.Size(121, 28);
            this.exercisecombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(374, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Suggested Calories";
            // 
            // offerbutton
            // 
            this.offerbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.offerbutton.Location = new System.Drawing.Point(18, 300);
            this.offerbutton.Name = "offerbutton";
            this.offerbutton.Size = new System.Drawing.Size(161, 64);
            this.offerbutton.TabIndex = 6;
            this.offerbutton.Text = "Offer Plan";
            this.offerbutton.Click += new System.EventHandler(this.offerbutton_Click);
            // 
            // caloriepicker
            // 
            this.caloriepicker.Location = new System.Drawing.Point(379, 189);
            this.caloriepicker.Name = "caloriepicker";
            this.caloriepicker.Size = new System.Drawing.Size(120, 26);
            this.caloriepicker.TabIndex = 7;
            // 
            // offerplans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.caloriepicker);
            this.Controls.Add(this.offerbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exercisecombo);
            this.Controls.Add(this.membercombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "offerplans";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "offerplans";
            this.Load += new System.EventHandler(this.offerplans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caloriepicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox membercombo;
        private System.Windows.Forms.ComboBox exercisecombo;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Controls.SfButton offerbutton;
        private System.Windows.Forms.NumericUpDown caloriepicker;
    }
}
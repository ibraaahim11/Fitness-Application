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
            this.ManageCoach = new System.Windows.Forms.Button();
            this.ManageCoaches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageCoach
            // 
            this.ManageCoach.Location = new System.Drawing.Point(42, 35);
            this.ManageCoach.Name = "ManageCoach";
            this.ManageCoach.Size = new System.Drawing.Size(238, 42);
            this.ManageCoach.TabIndex = 0;
            this.ManageCoach.Text = "Manage Coaches\' requests";
            this.ManageCoach.UseVisualStyleBackColor = true;
            this.ManageCoach.Click += new System.EventHandler(this.ManageCoach_Click);
            // 
            // ManageCoaches
            // 
            this.ManageCoaches.Location = new System.Drawing.Point(42, 110);
            this.ManageCoaches.Name = "ManageCoaches";
            this.ManageCoaches.Size = new System.Drawing.Size(238, 39);
            this.ManageCoaches.TabIndex = 1;
            this.ManageCoaches.Text = "Manage Coaches";
            this.ManageCoaches.UseVisualStyleBackColor = true;
            this.ManageCoaches.Click += new System.EventHandler(this.ManageCoaches_Click);
            // 
            // CoachMemManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ManageCoaches);
            this.Controls.Add(this.ManageCoach);
            this.Name = "CoachMemManaging";
            this.Text = "CoachMemManagin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageCoach;
        private System.Windows.Forms.Button ManageCoaches;
    }
}
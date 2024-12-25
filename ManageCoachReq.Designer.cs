namespace FitnessApplication
{
    partial class ManageCoachReq
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
            this.NonAcceptedCoachesData = new System.Windows.Forms.DataGridView();
            this.TextLabel = new System.Windows.Forms.TextBox();
            this.CoachID = new System.Windows.Forms.ComboBox();
            this.Accept = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NonAcceptedCoachesData)).BeginInit();
            this.SuspendLayout();
            // 
            // NonAcceptedCoachesData
            // 
            this.NonAcceptedCoachesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NonAcceptedCoachesData.Location = new System.Drawing.Point(71, 40);
            this.NonAcceptedCoachesData.Name = "NonAcceptedCoachesData";
            this.NonAcceptedCoachesData.RowHeadersWidth = 51;
            this.NonAcceptedCoachesData.RowTemplate.Height = 24;
            this.NonAcceptedCoachesData.Size = new System.Drawing.Size(642, 190);
            this.NonAcceptedCoachesData.TabIndex = 0;
            // 
            // TextLabel
            // 
            this.TextLabel.Enabled = false;
            this.TextLabel.Location = new System.Drawing.Point(187, 12);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(402, 22);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Non Accepted Coaches\' Requests";
            this.TextLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoachID
            // 
            this.CoachID.FormattingEnabled = true;
            this.CoachID.Location = new System.Drawing.Point(176, 253);
            this.CoachID.Name = "CoachID";
            this.CoachID.Size = new System.Drawing.Size(121, 24);
            this.CoachID.TabIndex = 2;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(367, 253);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(142, 23);
            this.Accept.TabIndex = 3;
            this.Accept.Text = "Accept Coach";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reject Coach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coach ID";
            // 
            // ManageCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.CoachID);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.NonAcceptedCoachesData);
            this.Name = "ManageCoach";
            this.Text = "ManageCoach";
            ((System.ComponentModel.ISupportInitialize)(this.NonAcceptedCoachesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NonAcceptedCoachesData;
        private System.Windows.Forms.TextBox TextLabel;
        private System.Windows.Forms.ComboBox CoachID;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
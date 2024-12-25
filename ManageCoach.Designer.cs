namespace FitnessApplication
{
    partial class ManageCoach
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
            this.TextLabel = new System.Windows.Forms.TextBox();
            this.AllCoachesData = new System.Windows.Forms.DataGridView();
            this.CoachID = new System.Windows.Forms.Label();
            this.CoachIDCBox = new System.Windows.Forms.ComboBox();
            this.MemberCount = new System.Windows.Forms.Label();
            this.MemberCount2 = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.Label();
            this.CoachRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberlimitTB = new System.Windows.Forms.TextBox();
            this.EditMemberLimit = new System.Windows.Forms.Button();
            this.RemoveCoach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllCoachesData)).BeginInit();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.Enabled = false;
            this.TextLabel.Location = new System.Drawing.Point(172, 12);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(472, 22);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "All Coaches";
            this.TextLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllCoachesData
            // 
            this.AllCoachesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCoachesData.Location = new System.Drawing.Point(104, 40);
            this.AllCoachesData.Name = "AllCoachesData";
            this.AllCoachesData.RowHeadersWidth = 51;
            this.AllCoachesData.RowTemplate.Height = 24;
            this.AllCoachesData.Size = new System.Drawing.Size(620, 149);
            this.AllCoachesData.TabIndex = 1;
            // 
            // CoachID
            // 
            this.CoachID.AutoSize = true;
            this.CoachID.Location = new System.Drawing.Point(104, 226);
            this.CoachID.Name = "CoachID";
            this.CoachID.Size = new System.Drawing.Size(59, 16);
            this.CoachID.TabIndex = 2;
            this.CoachID.Text = "CoachID";
            // 
            // CoachIDCBox
            // 
            this.CoachIDCBox.FormattingEnabled = true;
            this.CoachIDCBox.Location = new System.Drawing.Point(172, 222);
            this.CoachIDCBox.Name = "CoachIDCBox";
            this.CoachIDCBox.Size = new System.Drawing.Size(121, 24);
            this.CoachIDCBox.TabIndex = 3;
            this.CoachIDCBox.SelectedIndexChanged += new System.EventHandler(this.CoachIDCBox_SelectedIndexChanged);
            // 
            // MemberCount
            // 
            this.MemberCount.AutoSize = true;
            this.MemberCount.Location = new System.Drawing.Point(310, 225);
            this.MemberCount.Name = "MemberCount";
            this.MemberCount.Size = new System.Drawing.Size(94, 16);
            this.MemberCount.TabIndex = 4;
            this.MemberCount.Text = "Member Count";
            // 
            // MemberCount2
            // 
            this.MemberCount2.Enabled = false;
            this.MemberCount2.Location = new System.Drawing.Point(410, 223);
            this.MemberCount2.Name = "MemberCount2";
            this.MemberCount2.Size = new System.Drawing.Size(100, 22);
            this.MemberCount2.TabIndex = 5;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(530, 225);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(88, 16);
            this.Rating.TabIndex = 6;
            this.Rating.Text = "Coach Rating";
            // 
            // CoachRating
            // 
            this.CoachRating.Enabled = false;
            this.CoachRating.Location = new System.Drawing.Point(624, 223);
            this.CoachRating.Name = "CoachRating";
            this.CoachRating.Size = new System.Drawing.Size(100, 22);
            this.CoachRating.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Member Limit";
            // 
            // MemberlimitTB
            // 
            this.MemberlimitTB.Location = new System.Drawing.Point(227, 268);
            this.MemberlimitTB.Name = "MemberlimitTB";
            this.MemberlimitTB.Size = new System.Drawing.Size(100, 22);
            this.MemberlimitTB.TabIndex = 9;
            // 
            // EditMemberLimit
            // 
            this.EditMemberLimit.Location = new System.Drawing.Point(410, 266);
            this.EditMemberLimit.Name = "EditMemberLimit";
            this.EditMemberLimit.Size = new System.Drawing.Size(99, 23);
            this.EditMemberLimit.TabIndex = 10;
            this.EditMemberLimit.Text = "Edit";
            this.EditMemberLimit.UseVisualStyleBackColor = true;
            this.EditMemberLimit.Click += new System.EventHandler(this.EditMemberLimit_Click);
            // 
            // RemoveCoach
            // 
            this.RemoveCoach.Location = new System.Drawing.Point(110, 369);
            this.RemoveCoach.Name = "RemoveCoach";
            this.RemoveCoach.Size = new System.Drawing.Size(314, 27);
            this.RemoveCoach.TabIndex = 11;
            this.RemoveCoach.Text = "Remove Coach";
            this.RemoveCoach.UseVisualStyleBackColor = true;
            this.RemoveCoach.Click += new System.EventHandler(this.RemoveCoach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(142, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Removing Coach By the above CoachID";
            // 
            // ManageCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveCoach);
            this.Controls.Add(this.EditMemberLimit);
            this.Controls.Add(this.MemberlimitTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoachRating);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.MemberCount2);
            this.Controls.Add(this.MemberCount);
            this.Controls.Add(this.CoachIDCBox);
            this.Controls.Add(this.CoachID);
            this.Controls.Add(this.AllCoachesData);
            this.Controls.Add(this.TextLabel);
            this.Name = "ManageCoach";
            this.Text = "ManageCoach";
            ((System.ComponentModel.ISupportInitialize)(this.AllCoachesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextLabel;
        private System.Windows.Forms.DataGridView AllCoachesData;
        private System.Windows.Forms.Label CoachID;
        private System.Windows.Forms.ComboBox CoachIDCBox;
        private System.Windows.Forms.Label MemberCount;
        private System.Windows.Forms.TextBox MemberCount2;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox CoachRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MemberlimitTB;
        private System.Windows.Forms.Button EditMemberLimit;
        private System.Windows.Forms.Button RemoveCoach;
        private System.Windows.Forms.Label label2;
    }
}
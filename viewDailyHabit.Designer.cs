namespace FitnessApplication
{
    partial class viewDailyHabit
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
            this.AllHabits = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.Description = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.HabitNameTB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PointsTB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DescriptionTB = new System.Windows.Forms.RichTextBox();
            this.AddHabit = new Syncfusion.WinForms.Controls.SfButton();
            this.RemoveHabit = new Syncfusion.WinForms.Controls.SfButton();
            this.HabitsIDCB = new Syncfusion.WinForms.ListView.SfComboBox();
            this.EmptyAlert = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.AllHabits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabitNameTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabitsIDCB)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.Color.Green;
            this.autoLabel1.Location = new System.Drawing.Point(478, 43);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(219, 33);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "All Daily Habits";
            // 
            // AllHabits
            // 
            this.AllHabits.AccessibleName = "Table";
            this.AllHabits.Location = new System.Drawing.Point(394, 79);
            this.AllHabits.Name = "AllHabits";
            this.AllHabits.PreviewRowHeight = 35;
            this.AllHabits.Size = new System.Drawing.Size(374, 182);
            this.AllHabits.TabIndex = 1;
            this.AllHabits.Text = "sfDataGrid1";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.Color.Green;
            this.autoLabel2.Location = new System.Drawing.Point(31, 71);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(104, 24);
            this.autoLabel2.TabIndex = 2;
            this.autoLabel2.Text = "Habit Name:";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.Green;
            this.Description.Location = new System.Drawing.Point(31, 116);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(103, 24);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description:";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel4.ForeColor = System.Drawing.Color.Green;
            this.autoLabel4.Location = new System.Drawing.Point(31, 237);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(64, 24);
            this.autoLabel4.TabIndex = 4;
            this.autoLabel4.Text = "Points:";
            // 
            // HabitNameTB
            // 
            this.HabitNameTB.BeforeTouchSize = new System.Drawing.Size(207, 22);
            this.HabitNameTB.Location = new System.Drawing.Point(144, 73);
            this.HabitNameTB.Name = "HabitNameTB";
            this.HabitNameTB.Size = new System.Drawing.Size(207, 22);
            this.HabitNameTB.TabIndex = 5;
            // 
            // PointsTB
            // 
            this.PointsTB.BeforeTouchSize = new System.Drawing.Size(207, 22);
            this.PointsTB.Location = new System.Drawing.Point(144, 239);
            this.PointsTB.Name = "PointsTB";
            this.PointsTB.Size = new System.Drawing.Size(207, 22);
            this.PointsTB.TabIndex = 6;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(144, 116);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(207, 96);
            this.DescriptionTB.TabIndex = 7;
            this.DescriptionTB.Text = "";
            // 
            // AddHabit
            // 
            this.AddHabit.BackColor = System.Drawing.Color.DarkGreen;
            this.AddHabit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHabit.ForeColor = System.Drawing.Color.White;
            this.AddHabit.Location = new System.Drawing.Point(31, 324);
            this.AddHabit.Name = "AddHabit";
            this.AddHabit.Size = new System.Drawing.Size(155, 35);
            this.AddHabit.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.AddHabit.Style.ForeColor = System.Drawing.Color.White;
            this.AddHabit.TabIndex = 8;
            this.AddHabit.Text = "Add Habit";
            this.AddHabit.UseVisualStyleBackColor = false;
            this.AddHabit.Click += new System.EventHandler(this.AddHabit_Click);
            // 
            // RemoveHabit
            // 
            this.RemoveHabit.BackColor = System.Drawing.Color.DarkGreen;
            this.RemoveHabit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveHabit.ForeColor = System.Drawing.Color.White;
            this.RemoveHabit.Location = new System.Drawing.Point(200, 383);
            this.RemoveHabit.Name = "RemoveHabit";
            this.RemoveHabit.Size = new System.Drawing.Size(155, 35);
            this.RemoveHabit.Style.BackColor = System.Drawing.Color.DarkGreen;
            this.RemoveHabit.Style.ForeColor = System.Drawing.Color.White;
            this.RemoveHabit.TabIndex = 9;
            this.RemoveHabit.Text = "Remove Habit";
            this.RemoveHabit.UseVisualStyleBackColor = false;
            this.RemoveHabit.Click += new System.EventHandler(this.RemoveHabit_Click);
            // 
            // HabitsIDCB
            // 
            this.HabitsIDCB.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.HabitsIDCB.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.HabitsIDCB.Location = new System.Drawing.Point(31, 387);
            this.HabitsIDCB.Name = "HabitsIDCB";
            this.HabitsIDCB.Size = new System.Drawing.Size(121, 31);
            this.HabitsIDCB.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HabitsIDCB.TabIndex = 10;
            // 
            // EmptyAlert
            // 
            this.EmptyAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyAlert.ForeColor = System.Drawing.Color.Red;
            this.EmptyAlert.Location = new System.Drawing.Point(210, 343);
            this.EmptyAlert.Name = "EmptyAlert";
            this.EmptyAlert.Size = new System.Drawing.Size(260, 18);
            this.EmptyAlert.TabIndex = 11;
            this.EmptyAlert.Text = "Habit name or Points cannot be empty";
            this.EmptyAlert.Visible = false;
            // 
            // viewDailyHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmptyAlert);
            this.Controls.Add(this.HabitsIDCB);
            this.Controls.Add(this.RemoveHabit);
            this.Controls.Add(this.AddHabit);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.PointsTB);
            this.Controls.Add(this.HabitNameTB);
            this.Controls.Add(this.autoLabel4);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.AllHabits);
            this.Controls.Add(this.autoLabel1);
            this.Name = "viewDailyHabit";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "viewDailyHabit";
            ((System.ComponentModel.ISupportInitialize)(this.AllHabits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabitNameTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabitsIDCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid AllHabits;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel Description;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt HabitNameTB;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PointsTB;
        private System.Windows.Forms.RichTextBox DescriptionTB;
        private Syncfusion.WinForms.Controls.SfButton AddHabit;
        private Syncfusion.WinForms.Controls.SfButton RemoveHabit;
        private Syncfusion.WinForms.ListView.SfComboBox HabitsIDCB;
        private Syncfusion.Windows.Forms.Tools.AutoLabel EmptyAlert;
    }
}
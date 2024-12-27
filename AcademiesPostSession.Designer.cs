namespace FitnessApplication
{
    partial class AcademiesPostSession
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
            this.components = new System.ComponentModel.Container();
            this.labelSession = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationPicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.buttonPostSession = new System.Windows.Forms.Button();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.ForeColor = System.Drawing.Color.IndianRed;
            this.labelSession.Location = new System.Drawing.Point(24, 25);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(195, 29);
            this.labelSession.TabIndex = 10;
            this.labelSession.Text = "Session Details";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(28, 105);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(127, 26);
            this.labelDescription.TabIndex = 22;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(196, 108);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(249, 103);
            this.textBoxDescription.TabIndex = 23;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(197, 476);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(97, 26);
            this.textBoxPrice.TabIndex = 26;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(29, 476);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 26);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Limit members:";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(197, 406);
            this.numericUpDownLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownLimit.TabIndex = 28;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimit.ValueChanged += new System.EventHandler(this.numericUpDownLimit_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(673, 108);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePicker.MinDate = new System.DateTime(2024, 12, 24, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(195, 26);
            this.DatePicker.TabIndex = 30;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(673, 184);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(106, 26);
            this.TimePicker.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Duration:";
            // 
            // DurationPicker
            // 
            this.DurationPicker.CustomFormat = "hh:mm";
            this.DurationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationPicker.Location = new System.Drawing.Point(673, 252);
            this.DurationPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DurationPicker.Name = "DurationPicker";
            this.DurationPicker.ShowUpDown = true;
            this.DurationPicker.Size = new System.Drawing.Size(106, 26);
            this.DurationPicker.TabIndex = 34;
            this.DurationPicker.ValueChanged += new System.EventHandler(this.DurationPicker_ValueChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(197, 255);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(249, 103);
            this.textBoxAddress.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "Address:";
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Location = new System.Drawing.Point(322, 481);
            this.checkBoxFree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(68, 24);
            this.checkBoxFree.TabIndex = 38;
            this.checkBoxFree.Text = "Free";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            this.checkBoxFree.CheckedChanged += new System.EventHandler(this.checkBoxFree_CheckedChanged);
            // 
            // buttonPostSession
            // 
            this.buttonPostSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostSession.Location = new System.Drawing.Point(637, 442);
            this.buttonPostSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPostSession.Name = "buttonPostSession";
            this.buttonPostSession.Size = new System.Drawing.Size(232, 61);
            this.buttonPostSession.TabIndex = 39;
            this.buttonPostSession.Text = "Post Session";
            this.buttonPostSession.UseVisualStyleBackColor = true;
            this.buttonPostSession.Click += new System.EventHandler(this.buttonPostSession_Click);
            // 
            // AcademiesPostSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 852);
            this.Controls.Add(this.buttonPostSession);
            this.Controls.Add(this.checkBoxFree);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DurationPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSession);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AcademiesPostSession";
            this.Text = "Post Session";
            this.Load += new System.EventHandler(this.AcademiesPostSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DurationPicker;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private System.Windows.Forms.Button buttonPostSession;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
    }
}
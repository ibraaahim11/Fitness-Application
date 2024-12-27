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
            this.labelSession = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxAddress = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.buttonPostSession = new Syncfusion.WinForms.Controls.SfButton();
            this.DatePickers = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.ForeColor = System.Drawing.Color.IndianRed;
            this.labelSession.Location = new System.Drawing.Point(21, 20);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(162, 25);
            this.labelSession.TabIndex = 10;
            this.labelSession.Text = "Session Details";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(25, 84);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 22);
            this.labelDescription.TabIndex = 22;
            this.labelDescription.Text = "Description:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(26, 381);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 22);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Limit members:";
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Location = new System.Drawing.Point(175, 325);
            this.numericUpDownLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(120, 22);
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
            this.label2.Location = new System.Drawing.Point(452, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date:";
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(598, 147);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(95, 22);
            this.TimePicker.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Duration:";
            // 
            // DurationPicker
            // 
            this.DurationPicker.CustomFormat = "hh:mm";
            this.DurationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DurationPicker.Location = new System.Drawing.Point(598, 202);
            this.DurationPicker.Name = "DurationPicker";
            this.DurationPicker.ShowUpDown = true;
            this.DurationPicker.Size = new System.Drawing.Size(95, 22);
            this.DurationPicker.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Address:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxDescription.Location = new System.Drawing.Point(175, 84);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(222, 92);
            this.textBoxDescription.TabIndex = 40;
            this.textBoxDescription.ThemeName = "Metro";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxAddress.Location = new System.Drawing.Point(175, 202);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddress.Size = new System.Drawing.Size(222, 92);
            this.textBoxAddress.TabIndex = 41;
            this.textBoxAddress.ThemeName = "Metro";
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Location = new System.Drawing.Point(286, 385);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(57, 20);
            this.checkBoxFree.TabIndex = 38;
            this.checkBoxFree.Text = "Free";
            this.checkBoxFree.UseVisualStyleBackColor = true;
            this.checkBoxFree.CheckedChanged += new System.EventHandler(this.checkBoxFree_CheckedChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.AccessibilityEnabled = true;
            this.textBoxPrice.BeforeTouchSize = new System.Drawing.Size(222, 92);
            this.textBoxPrice.CurrencySymbol = "EGP ";
            this.textBoxPrice.DecimalValue = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.textBoxPrice.Location = new System.Drawing.Point(175, 385);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 42;
            this.textBoxPrice.Text = "EGP 1.00";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // buttonPostSession
            // 
            this.buttonPostSession.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.buttonPostSession.Location = new System.Drawing.Point(611, 352);
            this.buttonPostSession.Name = "buttonPostSession";
            this.buttonPostSession.Size = new System.Drawing.Size(161, 51);
            this.buttonPostSession.TabIndex = 43;
            this.buttonPostSession.Text = "Post Session";
            this.buttonPostSession.Click += new System.EventHandler(this.buttonPostSession_Click_1);
            // 
            // DatePickers
            // 
            this.DatePickers.DateTimeIcon = null;
            this.DatePickers.Location = new System.Drawing.Point(598, 86);
            this.DatePickers.Name = "DatePickers";
            this.DatePickers.Size = new System.Drawing.Size(146, 24);
            this.DatePickers.TabIndex = 44;
            this.DatePickers.ToolTipText = "";
            // 
            // AcademiesPostSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 682);
            this.Controls.Add(this.DatePickers);
            this.Controls.Add(this.buttonPostSession);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxFree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DurationPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSession);
            this.Name = "AcademiesPostSession";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Post Session";
            this.Load += new System.EventHandler(this.AcademiesPostSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DurationPicker;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxDescription;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxAddress;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox textBoxPrice;
        private Syncfusion.WinForms.Controls.SfButton buttonPostSession;
        private Syncfusion.WinForms.Input.SfDateTimeEdit DatePickers;
    }
}
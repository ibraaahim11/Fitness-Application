namespace FitnessApplication
{
    partial class Logging
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
            this.memberviewstreakbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.memberlogcaloriestextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.memberlogexercisescombo = new System.Windows.Forms.ComboBox();
            this.minexerclabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.memberminsexercisedtextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.calorieslabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.actualcalorieslabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.pointsawardedlabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.actualpointslabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.logbothbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.prompttoenterminslabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.datetimelog = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.memberlogcaloriestextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberminsexercisedtextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // memberviewstreakbutton
            // 
            this.memberviewstreakbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.memberviewstreakbutton.Location = new System.Drawing.Point(527, 39);
            this.memberviewstreakbutton.Name = "memberviewstreakbutton";
            this.memberviewstreakbutton.Size = new System.Drawing.Size(168, 28);
            this.memberviewstreakbutton.TabIndex = 0;
            this.memberviewstreakbutton.Text = "View Streak";
            this.memberviewstreakbutton.Click += new System.EventHandler(this.memberviewstreakbutton_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(219, 121);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(97, 20);
            this.autoLabel1.TabIndex = 3;
            this.autoLabel1.Text = "Log Calories";
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(208, 192);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(108, 20);
            this.autoLabel3.TabIndex = 5;
            this.autoLabel3.Text = "Log Exercises";
            // 
            // memberlogcaloriestextbox
            // 
            this.memberlogcaloriestextbox.BeforeTouchSize = new System.Drawing.Size(146, 26);
            this.memberlogcaloriestextbox.Location = new System.Drawing.Point(395, 121);
            this.memberlogcaloriestextbox.Name = "memberlogcaloriestextbox";
            this.memberlogcaloriestextbox.Size = new System.Drawing.Size(146, 26);
            this.memberlogcaloriestextbox.TabIndex = 6;
            // 
            // memberlogexercisescombo
            // 
            this.memberlogexercisescombo.FormattingEnabled = true;
            this.memberlogexercisescombo.Location = new System.Drawing.Point(395, 192);
            this.memberlogexercisescombo.Name = "memberlogexercisescombo";
            this.memberlogexercisescombo.Size = new System.Drawing.Size(146, 28);
            this.memberlogexercisescombo.TabIndex = 7;
            this.memberlogexercisescombo.SelectedIndexChanged += new System.EventHandler(this.memberlogexercisescombo_SelectedIndexChanged);
            // 
            // minexerclabel
            // 
            this.minexerclabel.Location = new System.Drawing.Point(125, 262);
            this.minexerclabel.Name = "minexerclabel";
            this.minexerclabel.Size = new System.Drawing.Size(138, 20);
            this.minexerclabel.TabIndex = 8;
            this.minexerclabel.Text = "Minutes Exercised";
            this.minexerclabel.Click += new System.EventHandler(this.autoLabel2_Click);
            // 
            // memberminsexercisedtextbox
            // 
            this.memberminsexercisedtextbox.BeforeTouchSize = new System.Drawing.Size(146, 26);
            this.memberminsexercisedtextbox.Location = new System.Drawing.Point(349, 262);
            this.memberminsexercisedtextbox.Name = "memberminsexercisedtextbox";
            this.memberminsexercisedtextbox.Size = new System.Drawing.Size(233, 26);
            this.memberminsexercisedtextbox.TabIndex = 9;
            this.memberminsexercisedtextbox.TextChanged += new System.EventHandler(this.textBoxExt2_TextChanged);
            // 
            // calorieslabel1
            // 
            this.calorieslabel1.Location = new System.Drawing.Point(37, 320);
            this.calorieslabel1.Name = "calorieslabel1";
            this.calorieslabel1.Size = new System.Drawing.Size(122, 20);
            this.calorieslabel1.TabIndex = 10;
            this.calorieslabel1.Text = "Calories Burned";
            // 
            // actualcalorieslabel
            // 
            this.actualcalorieslabel.Location = new System.Drawing.Point(193, 320);
            this.actualcalorieslabel.Name = "actualcalorieslabel";
            this.actualcalorieslabel.Size = new System.Drawing.Size(59, 20);
            this.actualcalorieslabel.TabIndex = 11;
            this.actualcalorieslabel.Text = "burned";
            // 
            // pointsawardedlabel1
            // 
            this.pointsawardedlabel1.Location = new System.Drawing.Point(432, 320);
            this.pointsawardedlabel1.Name = "pointsawardedlabel1";
            this.pointsawardedlabel1.Size = new System.Drawing.Size(124, 20);
            this.pointsawardedlabel1.TabIndex = 12;
            this.pointsawardedlabel1.Text = "Points Awarded ";
            // 
            // actualpointslabel
            // 
            this.actualpointslabel.Location = new System.Drawing.Point(585, 320);
            this.actualpointslabel.Name = "actualpointslabel";
            this.actualpointslabel.Size = new System.Drawing.Size(76, 20);
            this.actualpointslabel.TabIndex = 13;
            this.actualpointslabel.Text = "Awarded ";
            // 
            // autoLabel8
            // 
            this.autoLabel8.Location = new System.Drawing.Point(5, 39);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Size = new System.Drawing.Size(346, 20);
            this.autoLabel8.TabIndex = 14;
            this.autoLabel8.Text = "Log your Calories and Exercises To Earn Points!";
            // 
            // logbothbutton
            // 
            this.logbothbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.logbothbutton.Location = new System.Drawing.Point(302, 383);
            this.logbothbutton.Name = "logbothbutton";
            this.logbothbutton.Size = new System.Drawing.Size(130, 34);
            this.logbothbutton.TabIndex = 15;
            this.logbothbutton.Text = "Log";
            this.logbothbutton.Click += new System.EventHandler(this.logbothbutton_Click);
            // 
            // prompttoenterminslabel
            // 
            this.prompttoenterminslabel.ForeColor = System.Drawing.Color.Brown;
            this.prompttoenterminslabel.Location = new System.Drawing.Point(349, 291);
            this.prompttoenterminslabel.Name = "prompttoenterminslabel";
            this.prompttoenterminslabel.Size = new System.Drawing.Size(233, 20);
            this.prompttoenterminslabel.TabIndex = 16;
            this.prompttoenterminslabel.Text = "Please Enter Minutes Exercised";
            // 
            // datetimelog
            // 
            this.datetimelog.Checked = false;
            this.datetimelog.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimelog.Location = new System.Drawing.Point(585, 121);
            this.datetimelog.Name = "datetimelog";
            this.datetimelog.Size = new System.Drawing.Size(200, 26);
            this.datetimelog.TabIndex = 19;
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datetimelog);
            this.Controls.Add(this.prompttoenterminslabel);
            this.Controls.Add(this.logbothbutton);
            this.Controls.Add(this.autoLabel8);
            this.Controls.Add(this.actualpointslabel);
            this.Controls.Add(this.pointsawardedlabel1);
            this.Controls.Add(this.actualcalorieslabel);
            this.Controls.Add(this.calorieslabel1);
            this.Controls.Add(this.memberminsexercisedtextbox);
            this.Controls.Add(this.minexerclabel);
            this.Controls.Add(this.memberlogexercisescombo);
            this.Controls.Add(this.memberlogcaloriestextbox);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.memberviewstreakbutton);
            this.Name = "Logging";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Logging";
            this.Load += new System.EventHandler(this.Logging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberlogcaloriestextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberminsexercisedtextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton memberviewstreakbutton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt memberlogcaloriestextbox;
        private System.Windows.Forms.ComboBox memberlogexercisescombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel minexerclabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt memberminsexercisedtextbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel calorieslabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel actualcalorieslabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel pointsawardedlabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel actualpointslabel;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.WinForms.Controls.SfButton logbothbutton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel prompttoenterminslabel;
        private System.Windows.Forms.DateTimePicker datetimelog;
    }
}
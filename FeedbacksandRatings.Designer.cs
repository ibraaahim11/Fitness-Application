namespace FitnessApplication
{
    partial class FeedbacksandRatings
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
            this.feedbacklabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.memberfeedbacktextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sendfeedbackbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.rateyourcoachlabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.memberratecoachtextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.memberfeedbackcombo = new System.Windows.Forms.ComboBox();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.promptratecoachlabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.dateTimePickerfeedback = new System.Windows.Forms.DateTimePicker();
            this.promptenterfeedbacklabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.membersendratingbutton = new Syncfusion.WinForms.Controls.SfButton();
            this.ratefitnesstrackertextbox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ratefitnesstrackerlabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.memberfeedbacktextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberratecoachtextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratefitnesstrackertextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // feedbacklabel1
            // 
            this.feedbacklabel1.Location = new System.Drawing.Point(43, 180);
            this.feedbacklabel1.Name = "feedbacklabel1";
            this.feedbacklabel1.Size = new System.Drawing.Size(80, 20);
            this.feedbacklabel1.TabIndex = 1;
            this.feedbacklabel1.Text = "Feedback";
            // 
            // memberfeedbacktextbox
            // 
            this.memberfeedbacktextbox.BeforeTouchSize = new System.Drawing.Size(97, 26);
            this.memberfeedbacktextbox.Location = new System.Drawing.Point(178, 180);
            this.memberfeedbacktextbox.Name = "memberfeedbacktextbox";
            this.memberfeedbacktextbox.Size = new System.Drawing.Size(416, 26);
            this.memberfeedbacktextbox.TabIndex = 2;
            // 
            // sendfeedbackbutton
            // 
            this.sendfeedbackbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sendfeedbackbutton.Location = new System.Drawing.Point(114, 422);
            this.sendfeedbackbutton.Name = "sendfeedbackbutton";
            this.sendfeedbackbutton.Size = new System.Drawing.Size(170, 28);
            this.sendfeedbackbutton.TabIndex = 3;
            this.sendfeedbackbutton.Text = "Send Feedback";
            this.sendfeedbackbutton.Click += new System.EventHandler(this.sendfeedbackbutton_Click);
            // 
            // rateyourcoachlabel
            // 
            this.rateyourcoachlabel.Location = new System.Drawing.Point(427, 340);
            this.rateyourcoachlabel.Name = "rateyourcoachlabel";
            this.rateyourcoachlabel.Size = new System.Drawing.Size(128, 20);
            this.rateyourcoachlabel.TabIndex = 4;
            this.rateyourcoachlabel.Text = "Rate your Coach";
            // 
            // memberratecoachtextbox
            // 
            this.memberratecoachtextbox.BeforeTouchSize = new System.Drawing.Size(97, 26);
            this.memberratecoachtextbox.Location = new System.Drawing.Point(598, 340);
            this.memberratecoachtextbox.Name = "memberratecoachtextbox";
            this.memberratecoachtextbox.Size = new System.Drawing.Size(97, 26);
            this.memberratecoachtextbox.TabIndex = 5;
            this.memberratecoachtextbox.TextChanged += new System.EventHandler(this.memberratecoachtextbox_TextChanged);
            // 
            // memberfeedbackcombo
            // 
            this.memberfeedbackcombo.FormattingEnabled = true;
            this.memberfeedbackcombo.Location = new System.Drawing.Point(270, 84);
            this.memberfeedbackcombo.Name = "memberfeedbackcombo";
            this.memberfeedbackcombo.Size = new System.Drawing.Size(191, 28);
            this.memberfeedbackcombo.TabIndex = 8;
            this.memberfeedbackcombo.SelectedIndexChanged += new System.EventHandler(this.memberfeedbackcombo_SelectedIndexChanged);
            // 
            // autoLabel3
            // 
            this.autoLabel3.Location = new System.Drawing.Point(29, 84);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(136, 20);
            this.autoLabel3.TabIndex = 9;
            this.autoLabel3.Text = "Type of Feedback";
            // 
            // promptratecoachlabel
            // 
            this.promptratecoachlabel.ForeColor = System.Drawing.Color.Brown;
            this.promptratecoachlabel.Location = new System.Drawing.Point(221, 383);
            this.promptratecoachlabel.Name = "promptratecoachlabel";
            this.promptratecoachlabel.Size = new System.Drawing.Size(262, 20);
            this.promptratecoachlabel.TabIndex = 10;
            this.promptratecoachlabel.Text = "* Please Rate on a scale from 1 to 5";
            // 
            // dateTimePickerfeedback
            // 
            this.dateTimePickerfeedback.Location = new System.Drawing.Point(535, 84);
            this.dateTimePickerfeedback.Name = "dateTimePickerfeedback";
            this.dateTimePickerfeedback.Size = new System.Drawing.Size(210, 26);
            this.dateTimePickerfeedback.TabIndex = 12;
            // 
            // promptenterfeedbacklabel
            // 
            this.promptenterfeedbacklabel.ForeColor = System.Drawing.Color.Brown;
            this.promptenterfeedbacklabel.Location = new System.Drawing.Point(178, 218);
            this.promptenterfeedbacklabel.Name = "promptenterfeedbacklabel";
            this.promptenterfeedbacklabel.Size = new System.Drawing.Size(223, 20);
            this.promptenterfeedbacklabel.TabIndex = 13;
            this.promptenterfeedbacklabel.Text = "* Please Enter Your Feedback";
            // 
            // membersendratingbutton
            // 
            this.membersendratingbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.membersendratingbutton.Location = new System.Drawing.Point(511, 422);
            this.membersendratingbutton.Name = "membersendratingbutton";
            this.membersendratingbutton.Size = new System.Drawing.Size(201, 28);
            this.membersendratingbutton.TabIndex = 14;
            this.membersendratingbutton.Text = "Send Coach Rating";
            this.membersendratingbutton.Click += new System.EventHandler(this.membersendratingbutton_Click);
            // 
            // ratefitnesstrackertextbox
            // 
            this.ratefitnesstrackertextbox.BeforeTouchSize = new System.Drawing.Size(97, 26);
            this.ratefitnesstrackertextbox.Location = new System.Drawing.Point(232, 340);
            this.ratefitnesstrackertextbox.Name = "ratefitnesstrackertextbox";
            this.ratefitnesstrackertextbox.Size = new System.Drawing.Size(97, 26);
            this.ratefitnesstrackertextbox.TabIndex = 15;
            // 
            // ratefitnesstrackerlabel
            // 
            this.ratefitnesstrackerlabel.Location = new System.Drawing.Point(14, 340);
            this.ratefitnesstrackerlabel.Name = "ratefitnesstrackerlabel";
            this.ratefitnesstrackerlabel.Size = new System.Drawing.Size(183, 20);
            this.ratefitnesstrackerlabel.TabIndex = 16;
            this.ratefitnesstrackerlabel.Text = "Rate Our FitnessTracker";
            // 
            // FeedbacksandRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 478);
            this.Controls.Add(this.ratefitnesstrackerlabel);
            this.Controls.Add(this.ratefitnesstrackertextbox);
            this.Controls.Add(this.membersendratingbutton);
            this.Controls.Add(this.promptenterfeedbacklabel);
            this.Controls.Add(this.dateTimePickerfeedback);
            this.Controls.Add(this.promptratecoachlabel);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.memberfeedbackcombo);
            this.Controls.Add(this.memberratecoachtextbox);
            this.Controls.Add(this.rateyourcoachlabel);
            this.Controls.Add(this.sendfeedbackbutton);
            this.Controls.Add(this.memberfeedbacktextbox);
            this.Controls.Add(this.feedbacklabel1);
            this.Name = "FeedbacksandRatings";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "FeedbacksandRatings";
            this.Load += new System.EventHandler(this.FeedbacksandRatings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberfeedbacktextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberratecoachtextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratefitnesstrackertextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel feedbacklabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt memberfeedbacktextbox;
        private Syncfusion.WinForms.Controls.SfButton sendfeedbackbutton;
        private Syncfusion.Windows.Forms.Tools.AutoLabel rateyourcoachlabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt memberratecoachtextbox;
        private System.Windows.Forms.ComboBox memberfeedbackcombo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel promptratecoachlabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerfeedback;
        private Syncfusion.Windows.Forms.Tools.AutoLabel promptenterfeedbacklabel;
        private Syncfusion.WinForms.Controls.SfButton membersendratingbutton;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt ratefitnesstrackertextbox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel ratefitnesstrackerlabel;
    }
}
using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using DBapplication;
using Syncfusion.Reflection;
using Syncfusion.Windows.Forms.Tools;

namespace FitnessApplication
{
    public partial class FeedbacksandRatings : SfForm
    {
        Controller controller;
        Badges BadgesForm;
        int ID, feedbacktypeid,coachrating,trackerrating;
        string Username,feedbacktext;
        Members basemembersform;

        string feedbackdate;

        public FeedbacksandRatings(int ID, string Username, Members basemembersform)
        {
            InitializeComponent();
            controller = new Controller();

            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;

            loadfeedbackpage();
        }
        public void loadfeedbackpage()
        {


            ID = controller.GetMemberID(Username);
            Name = controller.GetMemberName(ID);
            memberfeedbackcombo.DataSource = controller.GetFeedbackTypes();
            // memberlogexercisescombo.DataSource = controller.GetExercises();
            memberfeedbackcombo.DisplayMember = "TypeName";
            memberfeedbackcombo.ValueMember = "TypeName";

            dateTimePickerfeedback.Format = DateTimePickerFormat.Custom;
            dateTimePickerfeedback.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            memberfeedbackcombo.SelectedIndex = -1;
            feedbacklabel1.Visible = false;
            memberfeedbacktextbox.Visible = false;
            sendfeedbackbutton.Visible = false;
            promptratecoachlabel.Visible = false;
            ratefitnesstrackerlabel.Visible = false;
            ratefitnesstrackertextbox.Visible = false;
            if (!controller.DoesMemberHaveCoach(ID))
            {
                rateyourcoachlabel.Visible = false;
                membersendratingbutton.Visible = false;
            }
        }

        private void membersendratingbutton_Click(object sender, EventArgs e)
        {
            bool validd=true;

            if (memberratecoachtextbox.Visible)
            {   if (memberratecoachtextbox.Text != " ")
                {
                    if (int.TryParse(memberratecoachtextbox.Text, out coachrating))
                    {
                        if (coachrating < 1 || coachrating > 5)
                        {
                            MessageBox.Show("Coach Rating must be between 1 and 5.");
                            validd = false;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid rating entered. Please enter a number between 1 and 5.");
                        validd = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please rate your coach.");
                }
            }

          int result=  controller.UpdateCoachedByRating(ID, coachrating);
            if(result>0)
            {
                MessageBox.Show("Rating submitted successfully!");
                memberratecoachtextbox.Text = "";
            }
            else
            {
                MessageBox.Show("Error submitting rating. Please try again.");
            }

        }
     
        private void FeedbacksandRatings_Load(object sender, EventArgs e)
        {
            // Set form background color to a light red shade
            this.BackColor = Color.FromArgb(255, 235, 235); // Light pastel red background

            // Customize buttons
            var buttons = new[] { sendfeedbackbutton, membersendratingbutton };
            foreach (var button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.FromArgb(220, 80, 80); // Lighter red border
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 80, 80); // Lighter red hover color
                button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(200, 40, 40); // Medium red button color
            }

            // Customize labels (autoLabels)
            var labels = new[] { feedbacklabel1, rateyourcoachlabel, autoLabel3, promptratecoachlabel, promptenterfeedbacklabel, ratefitnesstrackerlabel };
            foreach (var label in labels)
            {
                label.ForeColor = Color.FromArgb(100, 20, 20); // Darker red for text color
            }

            // Customize textboxes
            var textboxes = new[] { memberfeedbacktextbox, memberratecoachtextbox, ratefitnesstrackertextbox };
            foreach (var textbox in textboxes)
            {
                textbox.BackColor = Color.FromArgb(255, 245, 245); // Light pastel red textbox background
                textbox.ForeColor = Color.Black; // Black text for textbox
            }

            // Customize the ComboBox
            memberfeedbackcombo.BackColor = Color.FromArgb(255, 245, 245); // Light pastel red background
            memberfeedbackcombo.ForeColor = Color.Black; // Black text

            // Customize DateTimePicker
            dateTimePickerfeedback.CalendarForeColor = Color.Black; // Black text for the calendar
            dateTimePickerfeedback.CalendarMonthBackground = Color.FromArgb(255, 245, 245); // Light pastel red background
            dateTimePickerfeedback.CalendarTitleBackColor = Color.FromArgb(200, 40, 40); // Medium red for calendar title
            dateTimePickerfeedback.CalendarTitleForeColor = Color.White; // White text for calendar title

            // Customize specific labels for prompts
            promptratecoachlabel.ForeColor = Color.FromArgb(180, 40, 40); // Medium red for prompt
            promptenterfeedbacklabel.ForeColor = Color.FromArgb(180, 40, 40); // Medium red for prompt


        }


        private void memberfeedbackcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            feedbacklabel1.Visible = false;
            memberfeedbacktextbox.Visible = false;
            sendfeedbackbutton.Visible = false;
            promptenterfeedbacklabel.Visible = false;
            ratefitnesstrackerlabel.Visible = false;
            ratefitnesstrackertextbox.Visible = false;
            if (memberfeedbackcombo.SelectedIndex > -1)
            {
                feedbacktypeid = controller.GetFeedbackTypeID(memberfeedbackcombo.SelectedValue.ToString());
               // feedbacktypeid = (int)(memberfeedbackcombo.SelectedValue);
                feedbacklabel1.Visible = true;
                memberfeedbacktextbox.Visible = true;
                sendfeedbackbutton.Visible = true;
                promptenterfeedbacklabel.Visible = true;
                ratefitnesstrackerlabel.Visible = true;
                ratefitnesstrackertextbox.Visible = true;




            }
        }

        private void sendfeedbackbutton_Click(object sender, EventArgs e)
        {     
            bool valid = true;

            if (memberfeedbackcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a feedback type.");
                valid = false;
                return;
            }
            else 
            {

                feedbackdate = dateTimePickerfeedback.Text;
                if (feedbackdate == " ")
                {
                    MessageBox.Show("Please select a date.");
                    valid = false;
                    return;
                }

                if (memberfeedbacktextbox.Text == " ")
                {
                    MessageBox.Show("Please enter feedback text.");
                    valid = false;
                    return;
                }
                else
                {
                    feedbacktext = memberfeedbacktextbox.Text;
                }

                if (ratefitnesstrackertextbox.Text != " ")
                {
                    if (int.TryParse(ratefitnesstrackertextbox.Text, out trackerrating))
                    {
                        if (trackerrating < 1 || trackerrating > 5)
                        {
                            MessageBox.Show("Rating must be between 1 and 5.");
                            valid = false;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid rating entered. Please enter a number between 1 and 5.");
                        valid = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please rate our tracker");
                    valid = false;
                    return;
                   
                }
            }

           
           
            
          
           

            if (valid)
            {
                   
                   int result = controller.Insertfeedback(ID, feedbacktext, trackerrating, feedbacktypeid, feedbackdate );

                if (result > 0)
                {
                    MessageBox.Show("Feedback submitted successfully!");
                    memberfeedbackcombo.SelectedIndex = -1;
                    memberfeedbacktextbox.Text = "";
                    memberratecoachtextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Error submitting feedback. Please try again.");
                }
            }
        }
        

        private void memberratecoachtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

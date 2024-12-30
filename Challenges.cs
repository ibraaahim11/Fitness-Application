using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class Challenges : SfForm
    {
        private Controller controller;
        private int points;
        private string challengename, description, StartDate, EndDate;

        private int ID;
        private string username;
        private Coach BaseCoachForm;

        public Challenges(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            startdatepicker.MinDate = DateTime.Today;
            startdatepicker.Value = DateTime.Now;
            enddatepicker.MinDate = DateTime.Today;
            enddatepicker.Value = DateTime.Now;
        }

        private bool ReadChallengeDetails()
        {
            //get all the info
            description = descriptiontextbox.Text;
            challengename = challengenametextbox.Text;
            //store the number of points
            points = (int)pointsrewarded.Value;

            DateTime startDate = startdatepicker.Value;
            DateTime endDate = enddatepicker.Value;

            //convert date to sting
            StartDate = startDate.ToString("yyyy-MM-dd");
            EndDate = endDate.ToString("yyyy-MM-dd");

            if (description == "" || StartDate == "" || EndDate == "" || points == 0 || challengename == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResetChallengeDetails()
        {
            challengenametextbox.Text = string.Empty;
            descriptiontextbox.Text = string.Empty;
            pointsrewarded.Value = pointsrewarded.Minimum;

            startdatepicker.Value = DateTime.Now;
            enddatepicker.Value = DateTime.Now;
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            int result;
            if (ReadChallengeDetails())
            {
                if (points <= 0)
                {
                    MessageBox.Show("Please enter an appropriate number of points.");
                    return;
                }
                else
                {
                    result = controller.InsertCoachChallenge(challengename, points, description, StartDate, EndDate, ID);
                }
            }
            else
            {
                MessageBox.Show("Please do not leave any field empty.");
                return;
            }

            if (result == 1)
            {
                MessageBox.Show("Challenge posted successfully.");
                ResetChallengeDetails();
            }
            else
            {
                MessageBox.Show("Error posting Challenge.");
            }
        }

        private void Challenges_Load(object sender, EventArgs e)
        {
            Style.TitleBar.BackColor = Color.DodgerBlue;
            Style.TitleBar.ForeColor = Color.White;

            Style.TitleBar.CloseButtonForeColor = Color.White;
            Style.TitleBar.MinimizeButtonForeColor = Color.White;
            Style.TitleBar.MaximizeButtonForeColor = Color.White;

            Style.TitleBar.CloseButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MinimizeButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MaximizeButtonHoverBackColor = Color.CornflowerBlue;

            Style.TitleBar.CloseButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MaximizeButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MinimizeButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.BackColor = Color.DodgerBlue;
            Style.TitleBar.ForeColor = Color.White;

            Style.TitleBar.CloseButtonForeColor = Color.White;
            Style.TitleBar.MinimizeButtonForeColor = Color.White;
            Style.TitleBar.MaximizeButtonForeColor = Color.White;

            Style.TitleBar.CloseButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MinimizeButtonHoverBackColor = Color.CornflowerBlue;
            Style.TitleBar.MaximizeButtonHoverBackColor = Color.CornflowerBlue;

            Style.TitleBar.CloseButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MaximizeButtonPressedBackColor = Color.RoyalBlue;
            Style.TitleBar.MinimizeButtonPressedBackColor = Color.RoyalBlue;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
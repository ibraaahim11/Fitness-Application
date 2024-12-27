using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using Syncfusion.WinForms.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FitnessApplication
{
    public partial class Challenges : SfForm
    {
        Controller controller;
        int points, coachId;
        string challengename, description, StartDate, EndDate;

        public Challenges(int coachid)
        {
            InitializeComponent();
            controller = new Controller();
            coachId = coachid;
            startdatepicker.MinDate = DateTime.Today;
            startdatepicker.Value = DateTime.Now;
            enddatepicker.MinDate = DateTime.Today;
            enddatepicker.Value = DateTime.Now;

        }

        private bool ReadChallengeDetails()
        {
            //get all the info
           description=descriptiontextbox.Text;
           challengename=challengenametextbox.Text;
            //store the number of points
            points = (int)pointsrewarded.Value;
            
            DateTime startDate = startdatepicker.Value;
            DateTime endDate = enddatepicker.Value;

            //convert date to sting
            StartDate = startDate.ToString("yyyy-MM-dd");
            EndDate = endDate.ToString("yyyy-MM-dd");

         


            if (description == "" || StartDate == "" || EndDate == "" || points == 0 || challengename == "" )
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
                    result = controller.InsertCoachChallenge(challengename,points,description,StartDate,EndDate,coachId);
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

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

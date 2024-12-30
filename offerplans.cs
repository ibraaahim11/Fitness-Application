using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class offerplans : SfForm
    {
        private Controller controller;
        private int ID;
        private string username;
        private Coach BaseCoachForm;

        public offerplans(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            //get info of members
            DataTable dt = controller.GetUsernamesofMembers(ID);
            membercombo.DataSource = dt;
            membercombo.DisplayMember = "Username";
            membercombo.ValueMember = "Username";
            //get info of exercises
            DataTable data = controller.GetExerciseNames();
            exercisecombo.DataSource = data;
            exercisecombo.DisplayMember = "ExerciseName";
            exercisecombo.ValueMember = "ExerciseName";
        }

        private void offerplans_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void offerbutton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string datesuggested = date.ToString("yyyy-MM-dd");
            int result, result_2;
            if (exercisecombo.Text == "" || membercombo.Text == "" || caloriepicker.Value == 0)
            {
                MessageBox.Show("Please enter Valid Data");
            }
            else
            {
                result = controller.InsertSuggestedCalorie(membercombo.Text, ID, Convert.ToInt32(caloriepicker.Value), datesuggested);
                result_2 = controller.InsertSuggestedExercises(membercombo.Text, ID, exercisecombo.Text, datesuggested);
                if (result == 1 && result_2 == 1)
                {
                    MessageBox.Show("Plan is Sent");
                }
                else
                {
                    MessageBox.Show("An error Occured");
                }
            }
        }
    }
}
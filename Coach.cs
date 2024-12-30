using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;

namespace FitnessApplication
{
    public partial class Coach : SfForm
    {
        // Controller obj
        private Controller controller;

        private CoachProfile profile;
        private ViewMember member;
        private Challenges challengeform;
        private Requests requestform;
        private PostMeals PostMeals;
        private AwardBadges AwardBadges;
        private offerplans offerplans;
        private Feedback feedback;
        private int ID;
        private string username;
        private string Name;
        Login BasicLoginForm;

        public Coach(string Username, Login basicLoginForm)
        {
            //coach info for welcome screen

            InitializeComponent();
            controller = new Controller();
            username = Username;
            LoadCoachInfo();
            BasicLoginForm = basicLoginForm;

        }

        private void LoadCoachInfo()
        {
            // For now username is set since there is no login.
            ID = controller.GetCoachID(username);
            Name = controller.GetCoachName(ID);
            Welcomelabel.Text = $"Welcome, {Name}";
        }

        private void Coach_Load(object sender, EventArgs e)
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

        public void UpdateData(string NewUsername)
        {
            username = NewUsername;
            LoadCoachInfo();
        }

        private void Viewprofile_Click(object sender, EventArgs e)
        {
            profile = new CoachProfile(ID, username, this);
            profile.Show();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            member = new ViewMember(ID, username, this);
            member.Show();
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            challengeform = new Challenges(ID, username, this);
            challengeform.Show();
        }

        private void requestsbutton_Click(object sender, EventArgs e)
        {
            requestform = new Requests(ID, username, this);
            requestform.Show();
        }

        private void Postmealbutton_Click(object sender, EventArgs e)
        {
            PostMeals = new PostMeals(ID, username, this);
            PostMeals.Show();
        }

        private void awardbutton_Click(object sender, EventArgs e)
        {
            AwardBadges = new AwardBadges(ID, username, this);
            AwardBadges.Show();
        }

        private void Offerbutton_Click(object sender, EventArgs e)
        {
            offerplans = new offerplans(ID, username, this);
            offerplans.Show();
        }

        private void feedbackbutton_Click(object sender, EventArgs e)
        {
            feedback = new Feedback(ID, username, this);
            feedback.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            BasicLoginForm.refreshlogin();
            Close();
        }
    }
}
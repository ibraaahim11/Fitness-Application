using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using Syncfusion.WinForms.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessApplication
{
    public partial class Coach : SfForm
    {
        // Controller obj
        Controller controller;
        CoachProfile profile;
        ViewMember member;
        Challenges challengeform;
        Requests requestform;
        PostMeals PostMeals;
        int ID;
        string username = "michael_williams";
        string Name;
        public Coach()
        {
            //coach info for welcome screen 
            
            InitializeComponent();
            controller = new Controller();
            LoadCoachInfo();
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

        }

        private void Viewprofile_Click(object sender, EventArgs e)
        {
            profile = new CoachProfile(ID, username, this);
            profile.Show();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            member = new ViewMember(ID);
            member.Show();
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            challengeform=new Challenges(ID);
            challengeform.Show();
        }

        private void requestsbutton_Click(object sender, EventArgs e)
        {
            requestform = new Requests(ID);
            requestform.Show();
        }

        private void Postmealbutton_Click(object sender, EventArgs e)
        {
            PostMeals=new PostMeals(ID);
            PostMeals.Show();
        }
    }
}

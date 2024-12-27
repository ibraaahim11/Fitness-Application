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

namespace FitnessApplication
{
    public partial class Academies : SfForm
    {
        // Controller obj
        Controller controller;
        // Forms to open
        AcademiesProfile ProfileForm;
        AcademiesPostSession PostSessionForm;
        AcademiesViewSessions ViewSessionsForm;

        // Basic Academy info for welcome screen
        int ID;
        // For now as there is no login screen
        string Username = "KickFitAcademy";
        string Name;

        public Academies()
        {
            InitializeComponent();
            // Initializing controller
            controller = new Controller();
            LoadAcademyInfo();


        }
        public void UpdateData(string NewUsername)
        { 
            Username = NewUsername;
            LoadAcademyInfo();
        }
        private void LoadAcademyInfo()
        {
            // For now username is set since there is no login.
            ID = controller.GetAcademyID(Username);
            Name = controller.GetAcademyName(ID);
            labelWelcomeAcademy.Text = $"Welcome, {Name}";

        }
        private void Academies_Load(object sender, EventArgs e)
        {
            // Sets the back color and fore color of the title bar.
            this.Style.TitleBar.BackColor = Color.LightCoral; 
            this.Style.TitleBar.ForeColor = Color.White;      


            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;


            this.Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;  
            this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

            this.Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson; 
            this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;

        }

        private void buttonViewProfile_Click(object sender, EventArgs e)
        {
            // We will give the profile form access to this form.. in order to update data if needed.
            ProfileForm = new AcademiesProfile(ID, Username, this);

            ProfileForm.Show();
            

        }

        private void buttonPostSession_Click(object sender, EventArgs e)
        {
            PostSessionForm = new AcademiesPostSession(Username, ID);
            PostSessionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSessionsForm = new AcademiesViewSessions(Username, ID);
            ViewSessionsForm.Show();
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcomeAcademy_Click(object sender, EventArgs e)
        {

        }
    }
}

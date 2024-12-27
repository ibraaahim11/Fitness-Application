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

namespace FitnessApplication
{
    public partial class Academies : Form
    {
        // Controller obj
        Controller controller;
        // Forms to open
        AcademiesProfile ProfileForm;
        AcademiesPostSession PostSessionForm;

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
    }
}

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
using Syncfusion.Windows.Forms;
namespace FitnessApplication
{
    public partial class Members : SfForm
    {
        Controller controller;
        MembersProfile ProfileForm;
        Logging logform;
        Badges badgeform;
        FeedbacksandRatings feedbackform;
        Statistics statsform;
        int ID;
        // For now as there is no login screen
        string Username = "alice_johnson";
        string Name;
        int rank;

        public Members(string Username)
        {
            InitializeComponent();
            controller = new Controller();
            LoadmemberInfo();
        }
        public void UpdateData(string NewUsername)
        {
            Username = NewUsername;
            LoadmemberInfo();
        }

        private void LoadmemberInfo()
        {
          
            ID = controller.GetMemberID(Username);
            Name = controller.GetMemberName(ID);
            autoLabel1.Text = $"Welcome, {Name}";

        }

        private void Members_Load(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(204, 229, 204); 

            var buttons = new[] { memberviewprofilebutton, memberlogbutton, memberfeedbackbutton, memberrankbutton, memberbadgesbutton, sfButton1 };
            foreach (var button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.FromArgb(96, 128, 96); // Medium green border
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 200, 160); // Light green hover color
                button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(80, 120, 80); // Dark green button background
            }

          
            autoLabel1.ForeColor = Color.FromArgb(50, 90, 50); // Darker green for label text


            memberrankbutton.BackColor = Color.FromArgb(192, 192, 192); // Light grey
            memberrankbutton.ForeColor = Color.FromArgb(80, 80, 80); // Dark grey text

            memberbadgesbutton.BackColor = Color.FromArgb(192, 192, 192); // Light grey
            memberbadgesbutton.ForeColor = Color.FromArgb(80, 80, 80); // Dark grey text

            sfButton1.BackColor = Color.FromArgb(192, 192, 192); // Light grey
            sfButton1.ForeColor = Color.FromArgb(80, 80, 80); // Dark grey text

            this.ForeColor = Color.FromArgb(50, 90, 50); 
            this.Style.BackColor = Color.FromArgb(204, 229, 204); 
            this.Style.ForeColor = Color.FromArgb(50, 90, 50); 

           
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;

        }


        private void memberviewprofilebutton_Click(object sender, EventArgs e)
        {
            
            ProfileForm = new MembersProfile(ID, Username, this);



            ProfileForm.Show();
        }

        private void memberlogbutton_Click(object sender, EventArgs e)
        {
            logform = new Logging(ID, Username, this);



            logform.Show();
        }

        private void memberrankbutton_Click(object sender, EventArgs e)
        {
            rank = controller.GetMemberRankById(ID);
            if (rank == 1)
            {
                MessageBox.Show("You're the top member!");
            }
            else if (rank == 2)
            {
                MessageBox.Show("You're the second top member!");
            }
            else if (rank == 3)
            {
                MessageBox.Show("You're the third top member!");
            }
            else
            {
                MessageBox.Show($"You're ranked {rank}th over all member !");

            }
        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            badgeform = new Badges(ID, Username, this);



            badgeform.Show();
        }

        private void memberfeedbackbutton_Click(object sender, EventArgs e)
        {
            feedbackform= new FeedbacksandRatings(ID, Username, this);
            feedbackform.Show();
        }

        private void sfButton1_Click_1(object sender, EventArgs e)
        {
            statsform = new Statistics(ID, Username, this);
            statsform.Show();
        }
    }
}

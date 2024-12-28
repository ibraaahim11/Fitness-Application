using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using Syncfusion.WinForms.Controls;

namespace FitnessApplication
{
    public partial class ManageBadges : SfForm
    {
        Controller controllerobj = new Controller();
        public ManageBadges()
        {
            InitializeComponent();

            this.Text = "Manage Badges";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            AllBadges.DataSource = controllerobj.GetAllBadges();
            BadgeIDCB.DisplayMember = "BadgeID";
            BadgeIDCB.ValueMember = "BadgeID";
            BadgeIDCB.DataSource = controllerobj.GetAllBadges();
            BadgeIDCB.SelectedIndex = 0;

        }

        private void AddBadge_Click(object sender, EventArgs e)
        {
            if (BadgeNameTB.Text == "" || DescriptionTB.Text == "")
                Emptyalert.Visible = true;
            else
            {
                int points = 0;
                Emptyalert.Visible = false;
                if (PointsTB.Text != "")
                {
                    if (int.TryParse(PointsTB.Text, out points))
                    {
                        if (controllerobj.AddBadge(BadgeNameTB.Text, DescriptionTB.Text, points) == 0)
                            MessageBox.Show("Error inserting badge");
                        else
                        {
                            MessageBox.Show("Badge Added successfully! ");
                            AllBadges.DataSource = controllerobj.GetAllBadges();
                            AllBadges.Refresh();
                            BadgeIDCB.DataSource = controllerobj.GetAllBadges();
                        }
                    }
                    else
                    {
                        MessageBox.Show("points must be integer");
                    }
                }

            }
        }

        private void RemoveBadge_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BadgeIDCB.SelectedValue);
            if (controllerobj.RemoveBadge(id) == 0)
                MessageBox.Show("Couldn't remove badge");
            else
            {
                MessageBox.Show("Badge removed successfully!");
                AllBadges.DataSource = controllerobj.GetAllBadges();
                BadgeIDCB.DataSource= controllerobj.GetAllBadges();
                if (controllerobj.GetAllBadges() != null)
                {
                    BadgeIDCB.SelectedItem = controllerobj.GetAllBadges().Rows[0];
                }
                else
                {
                    BadgeIDCB.SelectedValue = null;
                }
            }
        }
    }
}

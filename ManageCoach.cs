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
using MetroFramework;
using MetroFramework.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.WinForms.Controls;

namespace FitnessApplication
{
    public partial class ManageCoach : SfForm
    {
        Controller controllerobj = new Controller(); 
        public ManageCoach()
        {
            InitializeComponent();
            this.Text = "Coach Managing";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            AllAvaCoachesData.DataSource = controllerobj.GetAllCoachesData();
                
            

            CoachIDCBox.DisplayMember = "CoachID";
            CoachIDCBox.ValueMember = "CoachID";
            CoachIDCBox.DataSource = controllerobj.GetAllCoachesData();
            if (controllerobj.GetAllCoachesData() != null)
                CoachIDCBox.SelectedItem = controllerobj.GetAllCoachesData().Rows[0];


        }

        private void CoachIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(CoachIDCBox.SelectedValue);
            if (controllerobj.GetAvgRating(ID) == 0)
                CoachRating.Text = "null";
            else
                CoachRating.Text = controllerobj.GetAvgRating(ID).ToString();
            if (controllerobj.GetCoachedMemCount(ID) == 0)
                CoachMemCount.Text = "0";
            else
                CoachMemCount.Text = controllerobj.GetCoachedMemCount(ID).ToString();
        }

        private void RemoveCoach_Click(object sender, EventArgs e)
        {
            if (controllerobj.GetAllCoachesData() == null)
            {
                MessageBox.Show("There is no coach to remove");
            }
            else
            {
                if (controllerobj.RemoveCoach((int)CoachIDCBox.SelectedValue) == 0)
                    MessageBox.Show("Coach isn't removed");
                else
                {
                    MessageBox.Show("Coach removed Successfully");
                    AllAvaCoachesData.DataSource = controllerobj.GetAllCoachesData();
                    AllAvaCoachesData.Refresh();
                    CoachIDCBox.DataSource = controllerobj.GetAllCoachesData();
                    if (controllerobj.GetAllCoachesData() != null)
                    {
                        CoachIDCBox.SelectedItem = controllerobj.GetAllCoachesData().Rows[0];
                    }
                    else
                    {
                        CoachIDCBox.SelectedValue = null;
                    }
                }
            }
        }

        private void EditMemberLimitB_Click(object sender, EventArgs e)
        {
            int newLimit;
            if (CoachIDCBox.SelectedValue == null)
                MessageBox.Show("No Coach to edit");
            else
            {
                if (int.TryParse(MemberlimitTBox.Text, out newLimit))
                {
                    if (newLimit < Convert.ToInt16(CoachMemCount.Text))
                        MessageBox.Show("Cannot Set a limit lower than the current member count for the coach");
                    else
                    {
                        if (controllerobj.UpdateMemberLimit((int)CoachIDCBox.SelectedValue, newLimit) == 0)
                            MessageBox.Show("Couldn't Set new limit");
                        else
                        {
                            MessageBox.Show("New limit set successfully");
                            AllAvaCoachesData.DataSource = controllerobj.GetAllCoachesData();
                            AllAvaCoachesData.Refresh();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Limit must be an integer");
                }
            }
        }
    }
}

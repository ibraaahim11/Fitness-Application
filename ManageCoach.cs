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
    public partial class ManageCoach : Form
    {
        Controller controllerobj = new Controller(); 
        public ManageCoach()
        {
            InitializeComponent();
            AllCoachesData.DataSource = controllerobj.GetAllCoachesData();
            CoachIDCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CoachIDCBox.DisplayMember = "CoachID";
            CoachIDCBox.ValueMember = "CoachID";
            CoachIDCBox.DataSource = controllerobj.GetAllCoachesData();
        }

        private void CoachIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt16(CoachIDCBox.SelectedValue);
            if (controllerobj.GetAvgRating(ID) == 0)
                CoachRating.Text = "null";
            else
                CoachRating.Text = controllerobj.GetAvgRating(ID).ToString();
            if (controllerobj.GetCoachedMemCount(ID) == 0)
                MemberCount2.Text = "0";
            else
                MemberCount2.Text = controllerobj.GetCoachedMemCount(ID).ToString();
        }

        private void EditMemberLimit_Click(object sender, EventArgs e)
        {
            int newLimit;
            if(int.TryParse(MemberlimitTB.Text, out newLimit))
            {
                if (newLimit < Convert.ToInt16(MemberCount2.Text))
                    MessageBox.Show("Cannot Set a limit lower than the current member count for the coach");
                else
                {
                    if (controllerobj.UpdateMemberLimit((int)CoachIDCBox.SelectedValue, newLimit) == 0)
                        MessageBox.Show("Couldn't Set new limit");
                    else
                    {
                        MessageBox.Show("New limit set successfully");
                        AllCoachesData.DataSource = controllerobj.GetAllCoachesData();
                        AllCoachesData.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Limit must be an integer");
            }
        }

        private void RemoveCoach_Click(object sender, EventArgs e)
        {
            if (controllerobj.RemoveCoach((int)CoachIDCBox.SelectedValue) == 0)
                MessageBox.Show("Coach isn't removed");
            else
            {
                MessageBox.Show("Coach removed Successfully");
                AllCoachesData.DataSource = controllerobj.GetAllCoachesData();
                AllCoachesData.Refresh();
            }
        }
    }
}

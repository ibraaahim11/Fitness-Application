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
    public partial class ManageCoachReq : Form
    {
        Controller controllerobj = new Controller();
        public ManageCoachReq()
        {
            InitializeComponent();
            NonAcceptedCoachesData.DataSource = controllerobj.GetNonAcceptedCoachesData();
            CoachID.DropDownStyle = ComboBoxStyle.DropDownList;  //combobox read only
            CoachID.DisplayMember = "CoachID";
            CoachID.ValueMember = "CoachID";
            CoachID.DataSource = controllerobj.GetNonAcceptedCoachesData();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            int Coachid = Convert.ToInt16(CoachID.SelectedValue);
            if (controllerobj.AcceptCoach(Coachid) == 0)
                MessageBox.Show("Couldn't Accept Coach");
            else
                MessageBox.Show("Coach Accepted successfully");
            NonAcceptedCoachesData.DataSource = controllerobj.GetNonAcceptedCoachesData();
            NonAcceptedCoachesData.Refresh();
            CoachID.DataSource = controllerobj.GetNonAcceptedCoachesData();
            CoachID.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Coachid = Convert.ToInt16(CoachID.SelectedValue);
            if (controllerobj.RejectCoach(Coachid) == 0)
                MessageBox.Show("Couldn't Reject Coach");
            else
                MessageBox.Show("Coach Rejected successfully");
            NonAcceptedCoachesData.DataSource = controllerobj.GetNonAcceptedCoachesData();
            NonAcceptedCoachesData.Refresh();
            CoachID.DataSource = controllerobj.GetNonAcceptedCoachesData();
            CoachID.Refresh();
        }
    }
}

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

namespace FitnessApplication
{
    public partial class Requests : SfForm
    {
        int coachID;
        Controller controller;
        public Requests(int coachid)
        {
            InitializeComponent();
            controller= new Controller();
            coachID = coachid;
            DataTable dt = controller.GetAllCoachRequests(coachID);
            if (dt != null && dt.Rows.Count > 0)
            {
                sfDataGrid1.DataSource = dt;
                sfDataGrid1.Refresh();
                Acceptbutton.Enabled = true;
                Declinebutton.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Request are found");
            }

        }

        private void Requests_Load(object sender, EventArgs e)
        {

        }

        private void Acceptbutton_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text == "")
            {
                MessageBox.Show("Please enter Member username");
            }
            else
            {
                int result = controller.AcceptMember(idtextbox.Text, coachID);
                if (result == 1)
                {
                    MessageBox.Show("Member is Accepted");
                }
                else
                {
                    MessageBox.Show("Member is Declined");
                }
            }

        }
    }
}

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
        int ID;
        string username;
        Coach BaseCoachForm;
        public Requests(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
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

        private void Acceptbutton_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text == "")
            {
                MessageBox.Show("Please enter Member username");
            }
            else
            {
                int result = controller.AcceptMember(idtextbox.Text, ID);
                if (result == 1)
                {
                    MessageBox.Show("Member is Accepted");
                }
                else
                {
                    MessageBox.Show("An error occurred!");
                }
            }

        }

        private void Declinebutton_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text == "")
            {
                MessageBox.Show("Please enter Member username");
            }
            else
            {
                int result = controller.DeclineMember(idtextbox.Text, ID);
                if (result == 1)
                {
                    MessageBox.Show("Member is Declined");
                }
                else
                {
                    MessageBox.Show("An error occurred!");
                }
            }
        }
    }
}

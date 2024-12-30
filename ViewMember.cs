using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class ViewMember : SfForm
    {
        private ViewMember viewmember;
        private Statistics statistics;
        private Controller controller;
        private int ID;
        private string username;
        private Coach BaseCoachForm;

        public ViewMember(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            DataTable dt = controller.GetUsernamesofMembers(ID);
            usernamecombo.DataSource = dt;
            usernamecombo.DisplayMember = "Username";
            usernamecombo.ValueMember = "Username";
        }

        private void ViewMember_Load(object sender, EventArgs e)
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

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            int memberID = controller.GetMemberID(usernamecombo.Text);
            DataTable dt = controller.ViewMember(memberID);
            if (dt != null && dt.Rows.Count > 0)
            {
                sfDataGrid1.DataSource = dt;
                sfDataGrid1.Refresh();
            }
            else
            {
                MessageBox.Show("No data found for the selected member.");
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            if (usernamecombo.Text == "")
            {
                MessageBox.Show("Please Select a Member");
            }
            else
            {
                int result = controller.RemoveMember(ID, usernamecombo.Text);
                if (result == 1)
                {
                    MessageBox.Show("Member has been Removed Successfully");
                }
                else
                {
                    MessageBox.Show("An error occurred!");
                }
            }
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            statistics = new Statistics(ID, username, BaseCoachForm);
            statistics.Show();
        }
    }
}
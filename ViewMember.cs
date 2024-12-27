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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessApplication
{
    public partial class ViewMember : SfForm
    {
        ViewMember viewmember;
        Controller controller;
        //int ID;
        public ViewMember(int coachID)
        {
            InitializeComponent();
            controller=new Controller();
            DataTable dt = controller.GetUsernamesofMembers(coachID);
            usernamecombo.DataSource = dt;
            usernamecombo.DisplayMember = "Username";
            usernamecombo.ValueMember = "Username";

        }

        private void ViewMember_Load(object sender, EventArgs e)
        {

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

       
    }
}

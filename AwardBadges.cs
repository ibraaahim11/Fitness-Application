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
    public partial class AwardBadges : SfForm
    {
        Controller controller;
        string memberusername, badgename, dateposted;
        int ID;
        string username;
        Coach BaseCoachForm;
        public AwardBadges(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            //load all badge info
            DataTable dt = controller.GetAllBadges();
            badgedatagrid.DataSource = dt;
            badgedatagrid.Refresh();
            badgecombo.DataSource = dt;
            badgecombo.DisplayMember = "BadgeName";
            badgecombo.ValueMember = "BadgeName";
            //load all member info 
            DataTable dataTable = controller.GetMembersandBadges(ID);
            memberdatagrid.DataSource = dataTable;
            memberdatagrid.Refresh();
            membercombo.DataSource = dataTable;
            membercombo.DisplayMember = "Username";
            membercombo.ValueMember = "Username";


        }

        private void AwardBadges_Load(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool ReadAwardDetails()
        {
             memberusername = membercombo.Text;
             badgename = badgecombo.Text;
            DateTime date = DateTime.Now;
             dateposted = date.ToString("yyyy-MM-dd");

            if (memberusername == "" || badgename == "" || dateposted == "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void giveawardbutton_Click(object sender, EventArgs e)
        {
            int result;
            if (ReadAwardDetails())
            {
                    result = controller.AwardBadge(memberusername,ID,badgename,dateposted);
            }
            else
            {
                MessageBox.Show("Please do not leave any field empty.");
                return;
            }

            if (result == 1)
            {
                MessageBox.Show("Member has been Awarded");
               
            }
            else
            {
                MessageBox.Show("An Error has occurred");
            }
        }
        }
    }



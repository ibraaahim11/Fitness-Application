using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using DBapplication;
namespace FitnessApplication
{
    public partial class Badges : SfForm
    {
        Controller controller;
        Badges BadgesForm;
        int ID;
        string Username;
        Members basemembersform;
        public Badges(int ID, string Username, Members basemembersform)
        {
         
            InitializeComponent();
            controller = new Controller();

            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;

            loadbadge();

        }
       public void loadbadge()
        {
            DataTable dt = controller.getbadgesearnedbyMember(ID);
              memberBadgesdatagrid.DataSource = dt;
        }
        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void Badges_Load(object sender, EventArgs e)
        {
            // Set the form background color to a soft yellow
            this.BackColor = Color.FromArgb(255, 250, 205); // Light pastel yellow background

            // Customize the DataGrid with a yellow palette
           // this.memberBadgesdatagrid.Style.BackColor = Color.FromArgb(255, 255, 240); // Ivory background for DataGrid
            this.memberBadgesdatagrid.Style.HeaderStyle.BackColor = Color.FromArgb(255, 223, 89); // Goldenrod for headers
            this.memberBadgesdatagrid.Style.HeaderStyle.TextColor = Color.Black; // Black text for headers
            this.memberBadgesdatagrid.Style.CellStyle.BackColor = Color.FromArgb(255, 255, 224); // Light golden background for cells
            this.memberBadgesdatagrid.Style.CellStyle.TextColor = Color.FromArgb(102, 51, 0); // Deep yellow-brown text for contrast
            this.memberBadgesdatagrid.Style.SelectionStyle.BackColor = Color.FromArgb(255, 215, 0); // Gold for selection
            this.memberBadgesdatagrid.Style.SelectionStyle.TextColor = Color.Black;

            // Customize the label
            this.autoLabel1.ForeColor = Color.FromArgb(255, 193, 37); // Yellow-orange text
            this.autoLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold); // Bigger font for better visibility
            this.autoLabel1.BackColor = Color.Transparent; // Transparent background to blend with the form

            // Set form-wide text and icon alignment
            this.ForeColor = Color.FromArgb(255, 165, 0); // Orange for general text
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Badges";

        }
    }
}

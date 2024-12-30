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
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms.Tools;

namespace FitnessApplication
{
    public partial class MemberStatistics : SfForm
    {
        Controller controller;
        Statistics statisticsform;
        int ID;
        string Username;
        Members basemembersform;
        decimal calin;
        decimal calb;
        public MemberStatistics(int ID, string Username, Members basemembersform)
        {
            InitializeComponent();
            controller = new Controller();

            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;
            loadstats();


        }

        private void MemberStatistics_Load_1(object sender, EventArgs e)
        {// Set a gradient-like vibrant background for the form




            // Set the background color of the form to soft pastel pink
            this.BackColor = Color.FromArgb(255, 240, 245); // Lighter pastel pink

            // Set label styles with a slightly darker pink tones
            autoLabel4.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for label text
            autoLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            autoLabel5.ForeColor = Color.FromArgb(255, 105, 120); // Matching darker pink for label text
            autoLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            autoLabel.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for dynamic text
            autoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            autoLabel6.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink to match dynamic data styling
            autoLabel6.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            // New label (YOUR STATS) styling with slightly darker pink
            autoLabel7.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for contrast
            autoLabel7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Set general form text color to a darker pink
            this.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for general text
            this.Style.BackColor = Color.FromArgb(255, 240, 245); // Light pastel pink for background
            this.Style.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink text color

            // Centering the icon for MDI child (if needed)
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;




        }

        private void Statistics_Paint(object sender, PaintEventArgs e)
        {
            // Create gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(48, 25, 52),  // Deep purple
                Color.FromArgb(191, 148, 228),  // Soft lavender
                45F)) // Angle of gradient
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle); // Apply gradient to form background
            }
        }


        public void loadstats()
        {
            calin = controller.GetAverageCaloriesIntake(ID);
            calb = controller.GetAverageCaloriesBurned(ID);
            autoLabel.Text = calin.ToString();
            autoLabel6.Text = calb.ToString();

        }

        private void autoLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
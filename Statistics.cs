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

namespace FitnessApplication
{
    public partial class Statistics : SfForm
    {
        Controller controller;
        Statistics statisticsform;
        int ID;
        string Username;
        Members basemembersform;
        decimal calin;
        decimal calb;
        public Statistics(int ID, string Username, Members basemembersform)
        {
            InitializeComponent();
            controller = new Controller();

            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;
            loadstats();
          

        }

        private void Statistics_Load(object sender, EventArgs e)
        {// Set a gradient-like vibrant background for the form



         
            // Set the background color of the form to soft pastel pink
            this.BackColor = Color.FromArgb(255, 240, 245); // Lighter pastel pink

            // Set label styles with a slightly darker pink tones
            autoLabel1.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for label text
            autoLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            autoLabel2.ForeColor = Color.FromArgb(255, 105, 120); // Matching darker pink for label text
            autoLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            averagecaloriestext.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for dynamic text
            averagecaloriestext.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            averageburnedtext.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink to match dynamic data styling
            averageburnedtext.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            // New label (YOUR STATS) styling with slightly darker pink
            autoLabel3.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for contrast
            autoLabel3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Set general form text color to a darker pink
            this.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink for general text
            this.Style.BackColor = Color.FromArgb(255, 240, 245); // Light pastel pink for background
            this.Style.ForeColor = Color.FromArgb(255, 105, 120); // Slightly darker pink text color

            // Centering the icon for MDI child (if needed)
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        

            //// Set the background color of the form to soft pastel pink
            //this.BackColor = Color.FromArgb(255, 240, 245); // Lighter pastel pink

            //// Set label styles with soft pastel pink tones
            //autoLabel1.ForeColor = Color.FromArgb(255, 182, 193); // Lighter pink for label text
            //autoLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            //autoLabel2.ForeColor = Color.FromArgb(255, 182, 193); // Matching lighter pink for label text
            //autoLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            //averagecaloriestext.ForeColor = Color.FromArgb(255, 182, 193); // Lighter pink for dynamic text
            //averagecaloriestext.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            //averageburnedtext.ForeColor = Color.FromArgb(255, 182, 193); // Lighter pink to match dynamic data styling
            //averageburnedtext.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            //// New label (YOUR STATS) styling
            //autoLabel3.ForeColor = Color.FromArgb(255, 182, 193); // Lighter pink for contrast
            //autoLabel3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            //// Set general form text color to a softer pink
            //this.ForeColor = Color.FromArgb(255, 182, 193); // Lighter pink for general text
            //this.Style.BackColor = Color.FromArgb(255, 240, 245); // Light pastel pink for background
            //this.Style.ForeColor = Color.FromArgb(255, 182, 193); // Lighter pink text color

            //// Centering the icon for MDI child (if needed)
            //this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            //this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        

        

            //this.BackColor = Color.FromArgb(48, 25, 52); // Deep purple for background


            //this.autoLabel1.ForeColor = Color.FromArgb(191, 148, 228); // Soft lavender text for labels
            //this.autoLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            //this.autoLabel2.ForeColor = Color.FromArgb(191, 148, 228); // Matching lavender for consistency
            //this.autoLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            //this.autoLabel3.ForeColor = Color.FromArgb(191, 148, 228); // Matching lavender for consistency
            //this.autoLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);


            //this.averagecaloriestext.ForeColor = Color.FromArgb(229, 229, 229); // Light gray for dynamic text
            //this.averagecaloriestext.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            //this.averageburnedtext.ForeColor = Color.FromArgb(229, 229, 229); // Light gray to match dynamic data styling
            //this.averageburnedtext.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            //// General styling adjustments
            //this.ForeColor = Color.FromArgb(191, 148, 228); // Lavender for general text
            //this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            //this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            //this.Text = "Statistics";

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
            averagecaloriestext.Text = calin.ToString();
            averageburnedtext.Text = calb.ToString();

        }

        private void autoLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}

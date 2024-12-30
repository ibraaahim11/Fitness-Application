using DBapplication;
using Syncfusion.WinForms.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class ViewFeedbacks : SfForm
    {
        private Controller controllerobj = new Controller();

        public ViewFeedbacks()
        {
            InitializeComponent();

            this.Text = "FeedBacks";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            AllFeedbacks.DataSource = controllerobj.GetAllFeedbacks();
        }
    }
}
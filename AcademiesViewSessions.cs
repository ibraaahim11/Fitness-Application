using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class AcademiesViewSessions : SfForm
    {
        private string Username; private int ID; private string UserType;

        private AcademySessions SessionsForm;

        private string[] sortingOptions = { "Oldest", "Newest" };

        private string[] limitOptions = { "None", "5", "10", "15", "20" };
        private Controller controller;

        public AcademiesViewSessions(string Username, int ID, string UserType)
        {
            InitializeComponent();
            this.ID = ID; this.Username = Username;
            this.UserType = UserType;

            controller = new Controller();
            ConfigureMessageBoxAdv();

            // Add later if fey wa2t: string[] sortingOptions = { "Oldest", "Newest", "Most Attendees", "Least Attendees" };
            sfComboBoxSortBy.DataSource = sortingOptions;
            sfComboBoxSortBy.SelectedIndex = 0;

            sfComboBoxLimit.DataSource = limitOptions;
            sfComboBoxLimit.SelectedIndex = 0;
        }

        private void AcademiesViewSessions_Load(object sender, EventArgs e)
        {
            if (UserType == "academy")
            {
                // Sets the back color and fore color of the title bar.
                this.Style.TitleBar.BackColor = Color.LightCoral;
                this.Style.TitleBar.ForeColor = Color.White;

                this.Style.TitleBar.CloseButtonForeColor = Color.White;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.White;

                this.Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;
                this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
                this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

                this.Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson;
                this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
                this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;
            }
            else
            {
                this.Style.TitleBar.BackColor = Color.LightGreen;
                this.Style.TitleBar.ForeColor = Color.ForestGreen;

                this.Style.TitleBar.CloseButtonForeColor = Color.ForestGreen;
                this.Style.TitleBar.MinimizeButtonForeColor = Color.ForestGreen;
                this.Style.TitleBar.MaximizeButtonForeColor = Color.ForestGreen;

                this.Style.TitleBar.CloseButtonHoverBackColor = Color.MediumSeaGreen;
                this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.MediumSeaGreen;
                this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.MediumSeaGreen;

                this.Style.TitleBar.CloseButtonPressedBackColor = Color.SeaGreen;
                this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.SeaGreen;
                this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.SeaGreen;
            }
        }

        public void ShowResults(int StartingIndex)
        {
            if (StartingIndex < 0)
                StartingIndex = 0;
            string SortBy = (string)sfComboBoxSortBy.SelectedValue;
            string LimitString = (string)sfComboBoxLimit.SelectedValue;
            // Default
            int LimitInt = 0;

            if (LimitString.ToLower() != "none")
            {
                LimitInt = int.Parse(LimitString);
            }
            // Depending on user
            DataTable Sessions;
            if (UserType == "academy")
            {
                Sessions = controller.GetAcademySessions(ID, SortBy, LimitInt);
            }
            else
            {
                Sessions = controller.GetAllSessions(SortBy, LimitInt);
            }

            if (Sessions == null)
            {
                MessageBoxAdv.Show(this, "No sessions posted.", "No Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SessionsForm = new AcademySessions(Username, ID, Sessions, StartingIndex, this, UserType);
                SessionsForm.Show();
            }
        }

        private void sfButtonShow_Click(object sender, EventArgs e)
        {
            ShowResults(0);
        }

        public void ConfigureMessageBoxAdv()
        {
            if (UserType == "academy")
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                var metroColorTable = MessageBoxAdv.MetroColorTable;
                metroColorTable.BackColor = Color.White;
                metroColorTable.ForeColor = Color.Black;
                metroColorTable.BorderColor = Color.IndianRed;
                metroColorTable.CaptionBarColor = Color.LightCoral;
                metroColorTable.CaptionForeColor = Color.White;
                metroColorTable.OKButtonBackColor = Color.LightCoral;
                metroColorTable.YesButtonBackColor = Color.LightCoral;
                metroColorTable.NoButtonBackColor = Color.LightCoral;

                MessageBoxAdv.MetroColorTable = metroColorTable;
            }
            else
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                var metroColorTable = MessageBoxAdv.MetroColorTable;
                metroColorTable.BackColor = Color.White;
                metroColorTable.ForeColor = Color.DarkOliveGreen;
                metroColorTable.BorderColor = Color.ForestGreen;
                metroColorTable.CaptionBarColor = Color.MediumSeaGreen;
                metroColorTable.CaptionForeColor = Color.White;
                metroColorTable.OKButtonBackColor = Color.MediumSeaGreen;
                metroColorTable.YesButtonBackColor = Color.MediumSeaGreen;
                metroColorTable.NoButtonBackColor = Color.MediumSeaGreen;

                MessageBoxAdv.MetroColorTable = metroColorTable;
            }
        }
    }
}
using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class MemberViewMealPlans : SfForm
    {
        private string Username; private int ID; private string UserType;

        private MemberMealPlans MealPlansForm;

        private string[] sortingOptions = { "Oldest", "Newest" };

        private string[] limitOptions = { "None", "5", "10", "15", "20" };
        private Controller controller;

        public MemberViewMealPlans(string Username, int ID)
        {
            InitializeComponent();
            this.ID = ID; this.Username = Username;

            controller = new Controller();
            ConfigureMessageBoxAdv();

            sfComboBoxSortBy.DataSource = sortingOptions;
            sfComboBoxSortBy.SelectedIndex = 0;

            sfComboBoxLimit.DataSource = limitOptions;
            sfComboBoxLimit.SelectedIndex = 0;
        }

        private void MemberViewMealPlans_Load(object sender, EventArgs e)
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
            DataTable MealPlans;

            MealPlans = controller.GetAllMeals(SortBy, LimitInt);

            if (MealPlans == null)
            {
                MessageBoxAdv.Show(this, "No Meals posted.", "No Meals", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MealPlansForm = new MemberMealPlans(MealPlans);
                MealPlansForm.Show();
            }
        }

        private void sfButtonShow_Click(object sender, EventArgs e)
        {
            ShowResults(0);
        }

        public void ConfigureMessageBoxAdv()
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

        private void sfButtonShow_Click_1(object sender, EventArgs e)
        {
            ShowResults(0);
        }
    }
}
using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;

namespace FitnessApplication
{
    public partial class MemberMealPlans : SfForm
    {
        private DataTable Meals;

        private int current_meal_index;

        private int maxMealsIndex;

        // Data of form
        private string Description, Address, Date, Time, Duration;

        private int limit; private float priceFloat;

        private Controller controller;

        public MemberMealPlans(DataTable Meals)
        {
            InitializeComponent();
            controller = new Controller();
            this.Meals = Meals;

            maxMealsIndex = Meals.Rows.Count - 1;
            current_meal_index = 0;

            ConfigureMessageBoxAdv();

            Update_Meals_Num_Label();
            Load_Meal();
        }

        private void MemberMealPlans_Load(object sender, EventArgs e)
        {
            Style.TitleBar.BackColor = Color.LightGreen;
            Style.TitleBar.ForeColor = Color.ForestGreen;

            Style.TitleBar.CloseButtonForeColor = Color.ForestGreen;
            Style.TitleBar.MinimizeButtonForeColor = Color.ForestGreen;
            Style.TitleBar.MaximizeButtonForeColor = Color.ForestGreen;

            Style.TitleBar.CloseButtonHoverBackColor = Color.MediumSeaGreen;
            Style.TitleBar.MinimizeButtonHoverBackColor = Color.MediumSeaGreen;
            Style.TitleBar.MaximizeButtonHoverBackColor = Color.MediumSeaGreen;

            Style.TitleBar.CloseButtonPressedBackColor = Color.SeaGreen;
            Style.TitleBar.MaximizeButtonPressedBackColor = Color.SeaGreen;
            Style.TitleBar.MinimizeButtonPressedBackColor = Color.SeaGreen;
        }

        private void Load_Meal()
        {
            string MealName = Meals.Rows[current_meal_index]["MealName"].ToString();
            string Username = Meals.Rows[current_meal_index]["Username"].ToString();
            string Steps = Meals.Rows[current_meal_index]["Steps"].ToString();
            string Ingredients = Meals.Rows[current_meal_index]["Ingredients"].ToString();

            string MealType = Meals.Rows[current_meal_index]["MealType"].ToString();
            string Calories = Meals.Rows[current_meal_index]["CaloriesPerServing"].ToString();

            string Fats = Meals.Rows[current_meal_index]["Fats"].ToString();
            string Carbs = Meals.Rows[current_meal_index]["Carbs"].ToString();
            string Protein = Meals.Rows[current_meal_index]["Protein"].ToString();

            string DatePosted = Meals.Rows[current_meal_index]["DatePosted"].ToString();
            string Duration = ((TimeSpan)Meals.Rows[current_meal_index]["Duration"]).ToString(@"hh\:mm");

            labelMealName.Text = MealName;
            labelUsername.Text = $"By @{Username}";
            labelDate.Text = DatePosted;
            textBoxIngredients.Text = Ingredients;
            textBoxSteps.Text = Steps;
            labelDuration.Text = Duration;

            labelCarbs.Text = $"{Carbs}g Fats";
            labelProtein.Text = $"{Protein}g Fats";
            labelFats.Text = $"{Fats}g Fats";

            labelCalories.Text = $"{Calories} Calories Per Serving";

            labelType.Text = $"For {MealType}";
        }

        private void Update_Meals_Num_Label()
        {
            autoLabelNumMeal.Text = $"Meal #{current_meal_index + 1} of {maxMealsIndex + 1}";
        }

        private void sfButtonPrevious_Click_1(object sender, EventArgs e)
        {
            current_meal_index--;
            if (current_meal_index < 0) { current_meal_index = 0; }
            Load_Meal();
            Update_Meals_Num_Label();
        }

        private void sfButtonNextMeal_Click(object sender, EventArgs e)
        {
            current_meal_index++;
            if (current_meal_index > maxMealsIndex)
            { current_meal_index = maxMealsIndex; }

            Load_Meal();
            Update_Meals_Num_Label();
        }

        private void labelCarbs_Click(object sender, EventArgs e)
        {
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
    }
}
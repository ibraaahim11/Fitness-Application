using DBapplication;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class PostMeals : SfForm
    {
        private Controller controller;
        private int calories;
        private double fats, protein, carbs;
        private string namemeal, ingredients, steps, duration, dateposted, mealtype;
        private int ID;
        private string username;
        private Coach BaseCoachForm;

        public PostMeals(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            DataTable dt = controller.GetMealTypes();
            mealtypecombo.DataSource = dt;
            mealtypecombo.DisplayMember = "MealType";
            mealtypecombo.ValueMember = "MealType";
        }

        private void PostMeals_Load(object sender, EventArgs e)
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

        private bool ReadMealDetails()
        {
            namemeal = descriptiontextbox.Text;
            ingredients = ingredientstextbox.Text;
            steps = stepstextbox.Text;
            mealtype = mealtypecombo.Text;
            calories = (int)caloriesperserving.Value;
            fats = (double)totalfatstextbox.DoubleValue;
            protein = (double)totalproteintextbox.DoubleValue;
            carbs = (double)totalcarbstextbox.DoubleValue;

            DateTime Date = dateTimePicker1.Value;

            //convert date to sting
            dateposted = Date.ToString("yyyy-MM-dd");

            TimeSpan durationT = DurationPicker.Value.TimeOfDay;

            // Convert timespan to string
            duration = durationT.ToString(@"hh\:mm\:ss");

            if (namemeal == "" || ingredients == "" || steps == "" || calories == 0 || dateposted == "" || duration == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResetMealDetails()
        {
            descriptiontextbox.Text = string.Empty;
            ingredientstextbox.Text = string.Empty;
            stepstextbox.Text = string.Empty;
            caloriesperserving.Value = caloriesperserving.Minimum;
            totalfatstextbox.DoubleValue = totalfatstextbox.MinValue;
            totalproteintextbox.DoubleValue = totalproteintextbox.MinValue;
            totalcarbstextbox.DoubleValue = totalcarbstextbox.MinValue;

            dateTimePicker1.Value = DateTime.Now;
            DurationPicker.Value = DurationPicker.MinDate;
        }

        private void postmealbutton_Click(object sender, EventArgs e)
        {
            int result;
            if (ReadMealDetails())
            {
                if (calories <= 0)
                {
                    MessageBox.Show("Please enter an appropriate number of points.");
                    return;
                }
                else
                {
                    result = controller.InsertNewMeal(ID, namemeal, ingredients, steps, dateposted, duration, mealtype, fats, protein, carbs, calories);
                }
            }
            else
            {
                MessageBox.Show("Please do not leave any field empty.");
                return;
            }

            if (result == 1)
            {
                MessageBox.Show("Meal posted successfully.");
                ResetMealDetails();
            }
            else
            {
                MessageBox.Show("Error posting Meal.");
            }
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
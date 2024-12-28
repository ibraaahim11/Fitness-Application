using DBapplication;
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

namespace FitnessApplication
{
    public partial class viewDailyHabit : SfForm
    {
        Controller controllerobj = new Controller();
        public viewDailyHabit()
        {
            InitializeComponent();

            this.Text = "Manage DailyHabits";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Style.TitleBar.BackColor = Color.DarkGreen;
            this.Style.TitleBar.ForeColor = Color.White;
            this.Style.TitleBar.Height = 50;
            this.Style.TitleBar.Font = new Font("Arial", 14, FontStyle.Bold);
            this.Style.Border.Width = 2;
            this.Style.Border.Color = Color.DarkGreen;

            AllHabits.DataSource = controllerobj.getAllHabits();
            HabitsIDCB.DisplayMember = "HabitID";
            HabitsIDCB.ValueMember = "HabitID";
            HabitsIDCB.DataSource = controllerobj.getAllHabits();
            HabitsIDCB.SelectedIndex = 0;
        }

        private void AddHabit_Click(object sender, EventArgs e)
        {
            if (HabitNameTB.Text == "" || PointsTB.Text == "")
                EmptyAlert.Visible = true;
            else
            {
                EmptyAlert.Visible = false;
                int points = 0;
                if (PointsTB.Text != "")
                {
                    if (int.TryParse(PointsTB.Text, out points))
                    {
                        if (controllerobj.AddDailyHabit(HabitNameTB.Text, DescriptionTB.Text, points) == 0)
                            MessageBox.Show("Error inserting Habit");
                        else
                        {
                            MessageBox.Show("Habit Added successfully! ");
                            AllHabits.DataSource = controllerobj.getAllHabits();
                            AllHabits.Refresh();
                            HabitsIDCB.DataSource = controllerobj.getAllHabits();
                        }
                    }
                    else
                    {
                        MessageBox.Show("points must be integer");
                    }
                }
            }
        }

        private void RemoveHabit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(HabitsIDCB.SelectedValue);
            if (controllerobj.RemoveDailyHabit(id) == 0)
                MessageBox.Show("Couldn't remove badge");
            else
            {
                MessageBox.Show("Badge removed successfully!");
                AllHabits.DataSource = controllerobj.getAllHabits();
                HabitsIDCB.DataSource = controllerobj.getAllHabits();
                if (controllerobj.getAllHabits() != null)
                {
                    HabitsIDCB.SelectedItem = controllerobj.getAllHabits().Rows[0];
                }
                else
                {
                    HabitsIDCB.SelectedValue = null;
                }
            }
        }
    }
}

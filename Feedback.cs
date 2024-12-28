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

namespace FitnessApplication
{
    public partial class Feedback : SfForm
    {
        Controller controller;
        int ID;
        string username;
        Coach BaseCoachForm;
        public Feedback(int ID, string username, Coach BaseCoachForm)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.username = username;
            this.BaseCoachForm = BaseCoachForm;
            //get feedback names
            DataTable dt = controller.GetFeedbackTypes();
            comboBox1.DataSource=dt;
            comboBox1.DisplayMember = "TypeName";
            comboBox1.ValueMember = "TypeName";
        }

            private void Feedback_Load(object sender, EventArgs e)
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

        private void Feedbackbutton_Click(object sender, EventArgs e)
        {
            DateTime date= DateTime.Now;
            string dateposted = date.ToString("yyyy-hh-dd");
            int result;
            if (comboBox1.Text == "" || textBoxExt1.Text == "" )
            {
                MessageBox.Show("Please enter all Information");
            }
            else
            {
                result = controller.InsertFeedback(textBoxExt1.Text,Convert.ToInt16(ratingControl1.Value),comboBox1.Text,dateposted);
                if (result == 1) 
                {
                    MessageBox.Show("Feedback Sent");
                }
                else
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }
    }
    }

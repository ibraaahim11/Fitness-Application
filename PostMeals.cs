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
    public partial class PostMeals : SfForm
    {
        Controller controller;
        public PostMeals(int coachid)
        {
            InitializeComponent();
            controller = new Controller();

        }

        private void PostMeals_Load(object sender, EventArgs e)
        {
            Style.TitleBar.BackColor = Color.LightBlue;
            Style.TitleBar.ForeColor = Color.White;

            Style.TitleBar.CloseButtonForeColor = Color.White;
            Style.TitleBar.MinimizeButtonForeColor = Color.White;
            Style.TitleBar.MaximizeButtonForeColor = Color.White;

            Style.TitleBar.CloseButtonHoverBackColor = Color.LightSkyBlue;
            Style.TitleBar.MinimizeButtonHoverBackColor = Color.LightSkyBlue;
            Style.TitleBar.MaximizeButtonHoverBackColor = Color.LightSkyBlue;

            Style.TitleBar.CloseButtonPressedBackColor = Color.DeepSkyBlue;
            Style.TitleBar.MaximizeButtonPressedBackColor = Color.DeepSkyBlue;
            Style.TitleBar.MinimizeButtonPressedBackColor = Color.DeepSkyBlue;

        }
    }
}

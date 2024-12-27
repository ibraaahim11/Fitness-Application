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

        }
    }
}

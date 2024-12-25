using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class CoachMemManaging : Form
    {
        public CoachMemManaging()
        {
            InitializeComponent();
        }

        private void ManageCoach_Click(object sender, EventArgs e)
        {
            Form F = new ManageCoachReq();
            F.Show();
        }

        private void ManageCoaches_Click(object sender, EventArgs e)
        {
            Form F = new ManageCoach();
            F.Show();
        }
    }
}

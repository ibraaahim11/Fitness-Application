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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Syncfusion.Windows.Forms;
namespace FitnessApplication
{
    public partial class Members : SfForm
    {
        Controller controller;
        MembersProfile ProfileForm;
        Logging logform;

        int ID;
        // For now as there is no login screen
        string Username = "alice_johnson";
        string Name;


        public Members()
        {
            InitializeComponent();
            controller = new Controller();
            LoadmemberInfo();
        }
        public void UpdateData(string NewUsername)
        {
            Username = NewUsername;
            LoadmemberInfo();
        }
   
        private void LoadmemberInfo()
        {
            // For now username is set since there is no login.
            ID = controller.GetMemberID(Username);
            Name = controller.GetMemberName(ID);
            autoLabel1.Text = $"Welcome, {Name}";

        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void memberviewprofilebutton_Click(object sender, EventArgs e)
        {
            // We will give the profile form access to this form.. in order to update data if needed.
            //ProfileForm = new AcademiesProfile(ID, Username, this);
           ProfileForm = new MembersProfile(ID, Username, this);

          

            ProfileForm.Show();
        }

        private void memberlogbutton_Click(object sender, EventArgs e)
        {
            logform = new Logging(ID, Username, this);



            logform.Show();
        }
    }
}

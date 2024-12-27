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
using Syncfusion.Windows.Forms;

namespace FitnessApplication
{
    public partial class MembersProfile : SfForm
    {
        Controller controller;
        AcademiesProfile ProfileForm;
        // Basic Academy info for welcome screen
        int ID,age;
        string Username, Name , Password ,firstname,lastname,gender;
        decimal weight, height;

        private void membershowpasswordcheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            memberpasswordtextbox.UseSystemPasswordChar = !memberpasswordtextbox.UseSystemPasswordChar;
        }

        private void membereditprofilebutton_Click(object sender, EventArgs e)
        {

        }

       
       
        Members basemembersform;
        public MembersProfile(int ID, string Username, Members basemembersform)
        {
            InitializeComponent();

            controller = new Controller();
          
            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;
           LoadMProfile();
        }

        private void autoLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MembersProfile_Load(object sender, EventArgs e)
        {

        }
        public void LoadMProfile()
        {
            // Getting the info

            ID = controller.GetMemberID(Username);
            Name = controller.GetMemberName(ID);
            ///// use it in hello or welcome
            firstname = controller.GetMemberFirstName(ID);
            lastname = controller.GetMemberLastName(ID);
            age = controller.GetMemberAge(ID);
            weight = controller.GetMemberWeight(ID);
            height = controller.GetMemberHeight(ID);
            gender = controller.GetMemberGender(ID);
            Password = controller.GetMemberPassword(Username);


            string genderText;

            if (gender == "F")
            {
                genderText = "Female";
            }
            else if (gender == "M")
            {
                genderText = "Male";
            }else
            {
                genderText = "invalid";
            }
            
            

            memberusernametextbox.Text = Username;
            memberfirstnametextbox.Text = firstname;
            memberlastnametextbox.Text = lastname;
            memberagetextbox.Text = age.ToString();
            memberweighttextbox.Text = weight.ToString();
            memberheighttextbox.Text = height.ToString();
            membergendertextbox.Text = genderText.ToString();
            memberpasswordtextbox.Text = Password;





            // decimal weight = controller.GetMemberWeight(memberId);
            // decimal 



            // Load data into the respective text boxes


        }

    }
    
}

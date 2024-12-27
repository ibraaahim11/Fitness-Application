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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FitnessApplication
{
    public partial class MembersProfile : SfForm
    {
        Controller controller;
        MembersProfile ProfileForm;
        // Basic Academy info for welcome screen
        int ID,age, FitnessGoalID;
        string Username, Name , Password ,firstname,lastname,gender,FitnessGoalName;
        decimal weight, height;
        Members basemembersform;

        int allowedcalories;
        public void LoadMProfile()
        {
          
            // Getting the info
            string[] fitnessGoals = { "Lose Weight", "Gain Muscle", "Maintain Weight", "Improve Endurance", "Increase Flexibility"," " };


           


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

            FitnessGoalID = controller.GetMemberFitnessGoalID(ID);
            memberfitnessgoalcombo.DataSource = fitnessGoals;
            FitnessGoalName = controller.GetFitnessGoalName(FitnessGoalID);
            memberfitnessgoalcombo.SelectedItem = FitnessGoalName;
          
          
         
          
            string genderText;

            if (gender == "F")
            {
                genderText = "Female";
            }
            else if (gender == "M")
            {
                genderText = "Male";
            }
            else
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



            memberpasswordtextbox.UseSystemPasswordChar = true;
            memberusernametextbox.ReadOnly = true;
            memberfirstnametextbox.ReadOnly = true;
            memberlastnametextbox.ReadOnly = true;
            memberagetextbox.ReadOnly = true;
            memberweighttextbox.ReadOnly = true;
            memberheighttextbox.ReadOnly = true;
            membergendertextbox.ReadOnly = true;
            memberpasswordtextbox.ReadOnly = true;
            memberfitnessgoalcombo.Enabled = false;



            // Load data into the respective text boxes


        }
        public MembersProfile(int ID, string Username, Members basemembersform)
        {
            InitializeComponent();
            memberconfirmbutton.Visible = false;
            controller = new Controller();

            this.ID = ID;
            this.Username = Username;
            this.basemembersform = basemembersform;
            LoadMProfile();
        }

        private void membershowPasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (membershowPasswordcheckbox.Checked)
            {
                
                memberpasswordtextbox.UseSystemPasswordChar = false;
            }
            else
            {
              
                memberpasswordtextbox.UseSystemPasswordChar = true;
            }
        }



        private void membereditprofilebutton_Click(object sender, EventArgs e)
        {     
            memberusernametextbox.ReadOnly = false;
            memberfirstnametextbox.ReadOnly = false;
            memberlastnametextbox.ReadOnly = false;
            memberagetextbox.ReadOnly = false;
            memberweighttextbox.ReadOnly = false;
            memberheighttextbox.ReadOnly = false;
            membergendertextbox.ReadOnly = false;
            memberpasswordtextbox.ReadOnly = false;
            memberconfirmbutton.Visible = true;
            memberfitnessgoalcombo.Enabled = true;

        }
        private void memberconfirmbutton_Click(object sender, EventArgs e)
        {
            // Read data
            //Name = textBoxName.Text; Description = textBoxDescription.Text; AreaOfExpertise = textBoxAOE.Text;
            //Password = textBoxPassword.Text;
            bool valid=true;
            char gendertext;
            ID = controller.GetMemberID(Username);
            firstname = memberfirstnametextbox.Text;
            lastname = memberlastnametextbox.Text;
            if (int.TryParse(memberagetextbox.Text, out age))
            {
                
            }
            else
            {
                valid = false;
               
                MessageBox.Show("Invalid age entered. Please enter a valid number.");
                return;
            }
            if (decimal.TryParse(memberweighttextbox.Text, out weight))
            {
               
            }
            else
            {
                valid = false;
                MessageBox.Show("Invalid weight entered. Please enter a valid number.");
                return;
            }
            if (decimal.TryParse(memberheighttextbox.Text, out height))
            {

            }
            else
            {
                valid = false;
                MessageBox.Show("Invalid height entered. Please enter a valid number.");
                return;
            }
           


            if (membergendertextbox.Text == "Female")
            {
                gendertext = 'F';
            }
            else if (membergendertextbox.Text == "Male")
            {
                gendertext = 'M';
            }
            else
            {
                valid = false;
                MessageBox.Show("Invalid gender entered. Please enter a valid gender either Female or Male .");
                return;
            }
            FitnessGoalName = memberfitnessgoalcombo.SelectedItem.ToString();

            Password = memberpasswordtextbox.Text;

            // Old username will be used to update new username
            string NewUsername = memberusernametextbox.Text;




          
            // ... (existing validation logic) ...

            string newUsername = memberusernametextbox.Text;
            FitnessGoalName = memberfitnessgoalcombo.SelectedItem.ToString();

          
           

            // Update member's fitness goal (if changed)
          

            // ... (rest of the confirmation logic) ...
        
            if (NewUsername == "" || firstname == "" || lastname == "" || memberagetextbox.Text == "" || memberweighttextbox.Text == "" || memberheighttextbox.Text == "" || membergendertextbox.Text == "" || Password == "" )
            {
                valid = false;
                MessageBox.Show("Do not leave any fields empty.");
                return;
            }
          
            // Update profile
            int resultBasicInfo = controller.UpdateMemberProfile( Username, firstname, lastname, age, weight, height, gendertext);
            int resultUsernamePassword = controller.UpdateUsernamePasswordmember(Username, NewUsername, Password);
            int resultFitnessGoal = controller.SetFitnessGoal(Username, FitnessGoalName);
            if (resultBasicInfo == 1 && resultUsernamePassword == 1)
            {    
                MessageBox.Show("Profile Updated Successfully.");
                // Return to original state
                memberconfirmbutton.Visible = false;

                memberusernametextbox.ReadOnly = true;
                memberfirstnametextbox.ReadOnly = true;
                memberlastnametextbox.ReadOnly = true;
                memberagetextbox.ReadOnly = true;
                memberweighttextbox.ReadOnly = true;
                memberheighttextbox.ReadOnly = true;
                membergendertextbox.ReadOnly = true;
                memberpasswordtextbox.ReadOnly = true;
                memberfitnessgoalcombo.Enabled = false;
                // The base member form should have its data updated
                basemembersform.UpdateData(NewUsername);
                ///////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////// ADD TO OMARS VERSION///////////////////////////////////////////
                controller.UpdateAllowedCalorieIntake(weight, height, age, gendertext, Username);
                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////////
            }
            else if (resultBasicInfo != 1 && resultUsernamePassword != 1 && resultFitnessGoal != 1)
            {
                MessageBox.Show("Profile could not be updated.");
                return;
            }
            else if (resultUsernamePassword != 1)
            {
                MessageBox.Show("Username is already taken.");
                return;
            }


        }

        private void memberpasswordtextbox_TextChanged(object sender, EventArgs e)
        {

        }

   
        


       
       
       
     
        private void autoLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MembersProfile_Load(object sender, EventArgs e)
        {

        }
        

    }
    
}

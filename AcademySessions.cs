using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class AcademySessions : SfForm
    {
        private string Username; private int ID;
        private DataTable Sessions;
        private int sessionID;
        private int AcademyID;
        private int current_session_index;
        private int seats_left;
        private int maxSessionsIndex;
        private bool EditMode = false;
        private int NumMembersAttending;
        private bool Full;
        private AcademiesViewSessions BaseSessionsForm;
        private string UserType;

        private bool MemberEditMode = false;

        // Data of form
        private string Description, Address, Date, Time, Duration;

        private int limit; private float priceFloat;

        private Controller controller;

        // Forms
        private AcademiesSessionStats StatsForm;

        public AcademySessions(string Username, int ID, DataTable Sessions, int StartingIndex, AcademiesViewSessions BaseSessionsForm, string UserType)
        {
            InitializeComponent();
            controller = new Controller();
            this.Username = Username; this.ID = ID;
            this.Sessions = Sessions; this.UserType = UserType;
            maxSessionsIndex = Sessions.Rows.Count - 1;
            current_session_index = StartingIndex;
            this.BaseSessionsForm = BaseSessionsForm;
            DatePickers.MinDateTime = DateTime.Now;

            ConfigureMessageBoxAdv();

            Update_Sessions_Num_Label();
            Load_Session();

            if (UserType != "academy")
            {
                sfButtonCancelEditing.Visible = false;
                sfButtonDelete.Visible = false;
                sfButtonEdit.Visible = false;
                sfButtonUpload.Visible = false;
                sfButtonStats.Visible = false;

                sfButtonReserve.Visible = true;
                numericUpDownNumSeats.Visible = true;
                labelseats.Visible = true;
            }
        }

        private void AcademySessions_Load(object sender, EventArgs e)
        {
            // Sets the back color and fore color of the title bar.
            if (UserType == "academy")
            {
                Style.TitleBar.BackColor = Color.LightCoral;
                Style.TitleBar.ForeColor = Color.White;

                Style.TitleBar.CloseButtonForeColor = Color.White;
                Style.TitleBar.MinimizeButtonForeColor = Color.White;
                Style.TitleBar.MaximizeButtonForeColor = Color.White;

                Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;
                Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
                Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

                Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson;
                Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
                Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;
            }
            else
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
        }

        private void Load_Session()
        {
            sfButtonCancelReservEditing.Visible = false;
            labelReservationExists.Visible = false;
            sfButtonReserve.Enabled = true;
            numericUpDownNumSeats.Enabled = true;

            sessionID = (int)Sessions.Rows[current_session_index]["SessionID"];
            AcademyID = (int)Sessions.Rows[current_session_index]["AcademyID"];

            textBoxDescription.Text = Sessions.Rows[current_session_index]["Description"].ToString();
            textBoxAddress.Text = Sessions.Rows[current_session_index]["Location"].ToString();
            numericUpDownLimit.Value = (int)Sessions.Rows[current_session_index]["Limit"];
            limit = (int)numericUpDownLimit.Value;
            textBoxPrice.Text = Sessions.Rows[current_session_index]["Price"].ToString();

            checkBoxFree.Checked = textBoxPrice.Text == "EGP 0.00";

            DatePickers.Text = Sessions.Rows[current_session_index]["Date"].ToString();
            DatePickers.Value = (System.DateTime)Sessions.Rows[current_session_index]["Date"];
            DurationPicker.Text = Sessions.Rows[current_session_index]["Duration"].ToString();
            TimePicker.Text = Sessions.Rows[current_session_index]["Time"].ToString();

            NumMembersAttending = controller.GetNumberOfMembersAttendingSession(sessionID, AcademyID);

            Full = controller.IsSessionFull(sessionID, AcademyID);

            labelStatus.Text = "Status:";
            if (DatePickers.Value > DateTime.Now)
            {
                labelStatus.Text += " Done";
            }
            else if (Full)
            {
                labelStatus.Text += " Full";
            }
            else
            {
                labelStatus.Text += " Open";
            }

            seats_left = controller.GetSeatsLeft(sessionID, AcademyID);

            labelStatus.Text += $" ({seats_left} seats left!)";

            if (Full)
            {
                sfButtonReserve.Enabled = false;
                numericUpDownNumSeats.Enabled = false;
            }
            else
            {
                sfButtonReserve.Enabled = true;
                numericUpDownNumSeats.Enabled = true;
            }
            if (UserType == "member")
            {
                if (controller.ReservationExists(sessionID, ID, AcademyID))
                {
                    labelReservationExists.Visible = true;
                    sfButtonReserve.Enabled = false;
                    numericUpDownNumSeats.Enabled = false;

                    int numseats = controller.GetNumberOfSeatsOfMember(sessionID, ID, AcademyID);
                    numericUpDownNumSeats.Value = numseats;
                    sfButtonEditReservation.Visible = true;
                    sfButtonDeleteReservation.Visible = true;
                    sfButtonEditReservation.Enabled = true;
                    sfButtonDeleteReservation.Enabled = true;
                }
                else
                {
                    numericUpDownNumSeats.Value = 1;
                    sfButtonEditReservation.Visible = false;
                    sfButtonDeleteReservation.Visible = false;
                    MemberEditMode = false;
                }
            }
        }

        private void Update_Sessions_Num_Label()
        {
            autoLabelNumSession.Text = $"Session #{current_session_index + 1} of {maxSessionsIndex + 1}";
        }

        private void sfButtonNextSession_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                sfButtonCancelEditing_Click(sender, e);
            }
            current_session_index++;
            if (current_session_index > maxSessionsIndex)
            { current_session_index = maxSessionsIndex; }

            Load_Session();
            Update_Sessions_Num_Label();
        }

        private void sfButtonPrevious_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                sfButtonCancelEditing_Click(sender, e);
            }
            current_session_index--;
            if (current_session_index < 0) { current_session_index = 0; }
            Load_Session();
            Update_Sessions_Num_Label();
        }

        private void autoLabelNumSession_Click(object sender, EventArgs e)
        {
        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxExtSearchSession_Click(object sender, EventArgs e)
        {
            textBoxExtSearchSession.Text = "";
        }

        private void textBoxExtSearchSession_Enter(object sender, EventArgs e)
        {
        }

        private void textBoxExtSearchSession_MouseEnter(object sender, EventArgs e)
        {
        }

        private void textBoxExtSearchSession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (EditMode)
                {
                    sfButtonCancelEditing_Click(sender, e);
                }

                int num_session;
                if (int.TryParse(textBoxExtSearchSession.Text, out num_session))
                {
                    if (num_session < 1)
                    {
                        current_session_index = 0;
                    }
                    else if (num_session > maxSessionsIndex + 1)
                    {
                        current_session_index = maxSessionsIndex;
                    }
                    else
                    {
                        current_session_index = num_session - 1;
                    }
                    Load_Session();
                    Update_Sessions_Num_Label();
                }
            }
        }

        private void sfButtonEdit_Click(object sender, EventArgs e)
        {
            EditMode = true;
            sfButtonEdit.Visible = false;
            sfButtonCancelEditing.Visible = true;
            sfButtonUpload.Visible = true;

            textBoxAddress.ReadOnly = false; textBoxDescription.ReadOnly = false; textBoxPrice.ReadOnly = false;
            numericUpDownLimit.ReadOnly = false;
            checkBoxFree.Enabled = true;
            DatePickers.Enabled = true;
            DurationPicker.Enabled = true; TimePicker.Enabled = true;
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBoxAdv.Show(this,
                "Are you sure you want to delete this session?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int query_result = controller.DeleteSession(sessionID, ID);
                if (query_result == 1)
                {
                    MessageBoxAdv.Show(this, "Session has been deleted.", "Session deleted ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BaseSessionsForm.ShowResults(current_session_index - 1);
                    this.Close();
                }
                else
                {
                    MessageBoxAdv.Show("Session could not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBoxAdv.Show(this, "Session deletion canceled.", "Action Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != "EGP 0.00")
            {
                checkBoxFree.Checked = false;
            }
            else
            { checkBoxFree.Checked = true; }
        }

        private void checkBoxFree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFree.Checked)
            {
                textBoxPrice.Text = "EGP 0.00";
            }
        }

        private void DoneEditing()
        {
            EditMode = false;
            sfButtonEdit.Visible = true;
            sfButtonCancelEditing.Visible = false;
            sfButtonUpload.Visible = false;

            textBoxAddress.ReadOnly = true; textBoxDescription.ReadOnly = true; textBoxPrice.ReadOnly = true;
            numericUpDownLimit.ReadOnly = true;
            checkBoxFree.Enabled = false;
            DatePickers.Enabled = false;
            DurationPicker.Enabled = false; TimePicker.Enabled = false;
        }

        private void sfButtonStats_Click(object sender, EventArgs e)
        {
            if (NumMembersAttending == 0)
            {
                MessageBoxAdv.Show("You have no members attending.", "No Members", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StatsForm = new AcademiesSessionStats(Username, AcademyID, sessionID);
                StatsForm.Show();
            }
        }

        private void sfButtonReserve_Click(object sender, EventArgs e)
        {
            int num_seats = (int)numericUpDownNumSeats.Value;
            if (MemberEditMode)
            {
                controller.DeleteReservation(sessionID, ID, AcademyID);
            }

            if (num_seats + controller.GetNumberOfMembersAttendingSession(sessionID, AcademyID) > limit)
            {
                MessageBoxAdv.Show("Not enough capacity.", "Reservation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int result = controller.ReserveSession(ID, sessionID, AcademyID, num_seats);
                if (result == 1)
                {
                    MessageBoxAdv.Show($"You have reserved {num_seats} places.", "Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxAdv.Show("Error occurred while reserving", "Reservation Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (controller.GetSeatsTaken(sessionID, AcademyID) == limit)
                {
                    controller.MarkSessionAsFull(sessionID, AcademyID);
                }
                Load_Session();
            }
        }

        private void sfButtonEditReservation_Click(object sender, EventArgs e)
        {
            sfButtonReserve.Enabled = true;
            numericUpDownNumSeats.Enabled = true;
            MemberEditMode = true;
            numericUpDownNumSeats.Value = 1;
            sfButtonEditReservation.Visible = false;
            sfButtonCancelReservEditing.Visible = true;
        }

        private void sfButtonDeleteReservation_Click(object sender, EventArgs e)
        {
            controller.DeleteReservation(sessionID, ID, AcademyID);
            numericUpDownNumSeats.Enabled = false;
            EditMode = false;
            sfButtonEditReservation.Enabled = false;
            sfButtonDeleteReservation.Enabled = false;
            labelReservationExists.Visible = false;
            controller.MarkSessionAsNotFull(sessionID, AcademyID);

            sfButtonReserve.Enabled = true;
            numericUpDownNumSeats.Enabled = true;
            Load_Session();
        }

        private void sfButtonCancelReservEditing_Click(object sender, EventArgs e)
        {
            Load_Session();
            sfButtonCancelReservEditing.Visible = false;
            sfButtonEditReservation.Visible = true;
        }

        private void sfButtonCancelEditing_Click(object sender, EventArgs e)
        {
            Load_Session();
            DoneEditing();
        }

        private bool ReadSessionDetails()
        {
            Description = textBoxDescription.Text;
            Address = textBoxAddress.Text;
            limit = (int)numericUpDownLimit.Value;

            Date = DatePickers.DateTimeText;
            Time = TimePicker.Text;
            Duration = DurationPicker.Text;
            if (Description == "" || Address == "" || Date == "" || Time == "" || Duration == "" || (textBoxPrice.Text == "" && checkBoxFree.Checked == false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void sfButtonUpload_Click(object sender, EventArgs e)
        {
            int result;
            if (ReadSessionDetails())
            {
                if (limit <= 0)
                {
                    MessageBoxAdv.Show(this,
                        "Please enter an appropriate limit.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (limit < NumMembersAttending)
                {
                    MessageBoxAdv.Show(this,
                        $"There are already {NumMembersAttending} members attending.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string priceWithoutEGP = textBoxPrice.Text.Substring(3);
                    float.TryParse(priceWithoutEGP, out float priceFloat);

                    result = controller.AcademyUpdateSession(sessionID, ID, Description, priceFloat, limit, Duration, Address, Date, Time);
                }
            }
            else
            {
                MessageBoxAdv.Show(this,
                    "Do not leave any fields empty.",
                    "No changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (result == 1)
            {
                MessageBoxAdv.Show(this,
                    "Session updated successfully",
                    "Profile Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DoneEditing();

                BaseSessionsForm.ShowResults(current_session_index);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating session.");
            }
        }

        public void ConfigureMessageBoxAdv()
        {
            if (UserType == "academy")
            {
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
                var metroColorTable = MessageBoxAdv.MetroColorTable;
                metroColorTable.BackColor = Color.White;
                metroColorTable.ForeColor = Color.Black;
                metroColorTable.BorderColor = Color.IndianRed;
                metroColorTable.CaptionBarColor = Color.LightCoral;
                metroColorTable.CaptionForeColor = Color.White;
                metroColorTable.OKButtonBackColor = Color.LightCoral;
                metroColorTable.YesButtonBackColor = Color.LightCoral;
                metroColorTable.NoButtonBackColor = Color.LightCoral;

                MessageBoxAdv.MetroColorTable = metroColorTable;
            }
            else
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
}
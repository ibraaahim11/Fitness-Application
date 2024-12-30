using DBapplication;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApplication
{
    public partial class AcademiesPostSession : SfForm
    {
        private Controller controller;

        // Data of user
        private string Username; private int ID;

        // Data of form
        private string Description, Address, Date, Time, Duration;

        private int limit; private float priceFloat;

        public AcademiesPostSession(string Username, int ID)
        {
            InitializeComponent();
            controller = new Controller();
            this.ID = ID;
            this.Username = Username;

            ConfigureMessageBoxAdv();

            DatePickers.MinDateTime = DateTime.Today;

            DurationPicker.Value = DurationPicker.MinDate;
            TimePicker.Value = DateTime.Now;
            DatePickers.Value = DateTime.Now;
        }

        private void checkBoxFree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFree.Checked == true)
            {
                textBoxPrice.Text = string.Empty;
            }
        }

        private void numericUpDownLimit_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            string priceString = textBoxPrice.Text.Substring(3);
            if (float.TryParse(priceString, out priceFloat))
            {
                if (priceFloat > 0) { checkBoxFree.Checked = false; }
            }
            else
            {
                textBoxPrice.Text = "";
            }
        }

        private void buttonPostSession_Click_1(object sender, EventArgs e)
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
                else
                {
                    result = controller.AcademyInsertSession(Description, priceFloat, limit, Duration, Address, Date, Time, ID);
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
                    "Session posted successfully.",
                    "Session Posted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ResetSessionDetails();
            }
            else
            {
                MessageBoxAdv.Show(this,
                    "Session could not be posted.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private bool ReadSessionDetails()
        {
            Description = textBoxDescription.Text;
            Address = textBoxAddress.Text;
            limit = (int)numericUpDownLimit.Value;
            // priceFloat already stored

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

        private void ResetSessionDetails()
        {
            textBoxAddress.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            numericUpDownLimit.Value = numericUpDownLimit.Minimum;
            textBoxPrice.Text = string.Empty;
            checkBoxFree.Checked = false;

            DurationPicker.Value = DurationPicker.MinDate;

            TimePicker.Value = DateTime.Now;
            DatePickers.Value = DateTime.Now;
        }

        private void AcademiesPostSession_Load(object sender, EventArgs e)
        {
            // Sets the back color and fore color of the title bar.
            this.Style.TitleBar.BackColor = Color.LightCoral;
            this.Style.TitleBar.ForeColor = Color.White;

            this.Style.TitleBar.CloseButtonForeColor = Color.White;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.White;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.White;

            this.Style.TitleBar.CloseButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MinimizeButtonHoverBackColor = Color.IndianRed;
            this.Style.TitleBar.MaximizeButtonHoverBackColor = Color.IndianRed;

            this.Style.TitleBar.CloseButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Crimson;
            this.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Crimson;
        }

        public static void ConfigureMessageBoxAdv()
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
    }
}
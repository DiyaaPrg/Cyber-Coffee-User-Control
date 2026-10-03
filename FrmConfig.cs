using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCoffe_User_Control
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        public FrmConfig(decimal PricePerHour)
        {
            InitializeComponent();
            this.PricePerhour = PricePerHour;
        }

        private decimal PricePerhour=0;

        ctrlWorkstation.WorkstationEventArgs workstationSettings = new ctrlWorkstation.WorkstationEventArgs();

        public event EventHandler<ctrlWorkstation.WorkstationEventArgs> OnSettingsSaved;

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            btnForFree.Checked = true;

            this.MaximizeBox = false;


            tbHour.TextChanged += ValidateTimeForPriceCalculation;
            tbMinutes.TextChanged += ValidateTimeForPriceCalculation;
            tbSeconds.TextChanged += ValidateTimeForPriceCalculation;

            if (PricePerhour != -1) // -1 means not found, so set it empty!
                tbPricePerHour.Text = PricePerhour.ToString("F2");
            else
                tbPricePerHour.Text = string.Empty;
        }

        private void tbPricePerHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidate.ValidateNumber(e);

        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidate.ValidateFloat(e);
        }

        private void tbHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidate.ValidateNumber(e);
        }

        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidate.ValidateNumber(e);
        }

        private void tbSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidate.ValidateNumber(e);
        }

        private bool _ValidateInputsBeforeSave()
        {
            //to avoid empty time values
            tbHour.Text = (clsValidate.IsEmpty(tbHour)) ? "0" : tbHour.Text;
            tbMinutes.Text = (clsValidate.IsEmpty(tbMinutes)) ? "0" : tbMinutes.Text;
            tbSeconds.Text = (clsValidate.IsEmpty(tbSeconds)) ? "0" : tbSeconds.Text;



            if (string.IsNullOrEmpty(tbPricePerHour.Text))
                return false;
            if (workstationSettings.SessionType is ctrlWorkstation.enSessionType.byPrice && clsValidate.IsEmpty(tbPrice))
                return false;

            //if (workstationSettings.SessionType is ctrlWorkstation.enSessionType.byTime)
            //{
            //    if ((clsValidate.IsEmpty(tbHour)) || (clsValidate.IsEmpty(tbMinutes)) || (clsValidate.IsEmpty(tbSeconds)))
            //    {
            //        return false;
            //    }
            //}
                
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            workstationSettings.SessionType = (btnForFree.Checked) ? ctrlWorkstation.enSessionType.free : ((btnByTime.Checked) ? ctrlWorkstation.enSessionType.byTime : ctrlWorkstation.enSessionType.byPrice);

            if (!_ValidateInputsBeforeSave())
            {
                MessageBox.Show("Data is not Valid!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            workstationSettings.PricePerHour = (clsValidate.IsEmpty(tbPricePerHour)) ? 0: Convert.ToDecimal(tbPricePerHour.Text);

            if (workstationSettings.SessionType == ctrlWorkstation.enSessionType.free)
                OnSettingsSaved?.Invoke(this, workstationSettings);
            else
            {
                workstationSettings.Hours = (clsValidate.IsEmpty(tbPricePerHour)) ? (byte)0: Convert.ToByte(tbHour.Text);
                workstationSettings.Minutes = (clsValidate.IsEmpty(tbPricePerHour)) ? (byte)0: Convert.ToByte(tbMinutes.Text);
                workstationSettings.Seconds = (clsValidate.IsEmpty(tbPricePerHour)) ? (byte)0 :Convert.ToByte(tbSeconds.Text);
                workstationSettings.TotalPrice = (clsValidate.IsEmpty(tbPricePerHour)) ? 0: Convert.ToDecimal(tbPrice.Text);

                OnSettingsSaved?.Invoke(this, workstationSettings);
            }

            MessageBox.Show("Settings Saved", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void _SetDefaultInputs()
        {
            tbHour.Text = "";
            tbMinutes.Text = "";
            tbSeconds.Text = "";

            tbPrice.Text = "";
        }

        private void btnForFree_Click(object sender, EventArgs e)
        {
            workstationSettings.SessionType = ctrlWorkstation.enSessionType.free;

            _SetDefaultInputs();

            lblMethodText.Text = "Timer starts immediately. When the customer finishes, stop the session and the price is calculated then.\r\n";
            btnForFree.Checked = true;

            MethodButton_Click(sender, e);
        }

        private void btnByTime_Click(object sender, EventArgs e)
        {
            workstationSettings.SessionType = ctrlWorkstation.enSessionType.byTime;

            _SetDefaultInputs();

            lblMethodText.Text = "Enter the time. The price is calculated automatically: price per hour × time.\r\n";
            btnByTime.Checked = true;

            MethodButton_Click(sender, e);
        }

        private void btnByPrice_Click(object sender, EventArgs e)
        {
            workstationSettings.SessionType = ctrlWorkstation.enSessionType.byPrice;

            _SetDefaultInputs();

            lblMethodText.Text = "Enter the amount paid. The time is calculated automatically: price ÷ price per hour.\r\n";
            btnByPrice.Checked = true;

            MethodButton_Click(sender, e);
        }

        private void tbPricePerHour_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsEmpty(tbPricePerHour))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPricePerHour, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPricePerHour, null);
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (workstationSettings.SessionType != ctrlWorkstation.enSessionType.byPrice)
                return;


            if (clsValidate.IsEmpty(tbPrice))
            {
                _SetDefaultInputs();
                return;

            }

            // if price for paying can achive above 23 hours, 

            decimal PriceToPay = (clsValidate.IsEmpty(tbPrice))? 0: Convert.ToDecimal(tbPrice.Text);
            decimal PricePerHour = (clsValidate.IsEmpty(tbPricePerHour)) ? 0 : Convert.ToDecimal(tbPricePerHour.Text);

            if (PriceToPay / PricePerHour > 23) // result is more than 23 hours for session
            {
                MessageBox.Show("Price entered is large! Enter a valid price", "Pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPrice.Text = "";
                return;
            }    


            int hours = 0, seconds = 0, minutes = 0;

            clsCalculation.FindTimeByPrice(PricePerHour, PriceToPay, ref hours, ref minutes, ref seconds);

            tbHour.Text = hours.ToString();
            tbMinutes.Text = minutes.ToString();
            tbSeconds.Text = seconds.ToString();
        }

        private void tbHour_TextChanged(object sender, EventArgs e)
        {
            //if (workstationSettings.Method != ctrlWorkstation.enBookingMethod.byTime)
            //    return;

            //if ((!string.IsNullOrEmpty(tbHour.Text))  )
            //    tbPrice.Text =
            //        $"{(clsCalculation.CalculatePriceByTime(Convert.ToDecimal(tbPricePerHour.Text), Convert.ToByte(tbHour.Text), Convert.ToByte(tbMinutes.Text), Convert.ToByte(tbSeconds.Text)))}";
        }

        private void tbMinutes_TextChanged(object sender, EventArgs e)
        {
            //    if ((!string.IsNullOrEmpty(tbMinutes.Text)) )
            //        tbPrice.Text = $"{(clsCalculation.CalculatePriceByTime(Convert.ToDecimal(tbPricePerHour.Text), Convert.ToByte(tbHour.Text), Convert.ToByte(tbMinutes.Text), Convert.ToByte(tbSeconds.Text)))}";
        }

        private void tbSeconds_TextChanged(object sender, EventArgs e)
        {
            //if ((!string.IsNullOrEmpty(tbSeconds.Text)) )
                //tbPrice.Text = $"{(clsCalculation.CalculatePriceByTime(Convert.ToDecimal(tbPricePerHour.Text), Convert.ToByte(tbHour.Text), Convert.ToByte(tbMinutes.Text), Convert.ToByte(tbSeconds.Text)))}";
        }

        private void MethodButton_Click(object sender, EventArgs e)
        {
            var clicked = (Guna2Button)sender;

            foreach (Control ctrl in PnlMethods.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.Checked = false;
                }
            }

            clicked.Checked = true;

            if (btnForFree.Checked)
            {
                tbHour.Enabled = false;
                tbMinutes.Enabled = false;
                tbSeconds.Enabled = false;
                tbPrice.Enabled = false;
            }
            else if (btnByPrice.Checked)
            {
                tbPrice.Enabled = true;
                tbHour.Enabled = false;
                tbMinutes.Enabled = false;
                tbSeconds.Enabled = false;
            }
            else if (btnByTime.Checked)
            {
                tbPrice.Enabled = false;
                tbHour.Enabled = true;
                tbMinutes.Enabled = true;
                tbSeconds.Enabled = true;
            }

        }

        private void ValidateTimeForPriceCalculation(object sender, EventArgs e)
        {
            if (workstationSettings.SessionType != ctrlWorkstation.enSessionType.byTime)
                return;

            //convert time units to real data (byte) or 0 if empty:
            byte hours   = (string.IsNullOrEmpty(tbHour.Text))    ? (byte)0 : Convert.ToByte(tbHour.Text);
            byte minutes = (string.IsNullOrEmpty(tbMinutes.Text)) ? (byte)0 : Convert.ToByte(tbMinutes.Text);
            byte seconds = (string.IsNullOrEmpty(tbSeconds.Text)) ? (byte)0 : Convert.ToByte(tbSeconds.Text);

            decimal PricePerHour = (clsValidate.IsEmpty(tbPricePerHour)) ? 0 :  Convert.ToDecimal(tbPricePerHour.Text);

            if (hours > 23)
            {
                hours = 23;
                tbHour.Text = "23";
            }
            if (minutes > 59)
            {
                minutes = 59;
                tbMinutes.Text = "59";
            }
            if (seconds > 59)
            {
                seconds = 59;
                tbSeconds.Text = "59";
            }


            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                tbPrice.Text = "";
                return;
            }


            decimal Price = clsCalculation.CalculatePriceByTime(PricePerHour, hours, minutes, seconds);
            tbPrice.Text = Price.ToString("F2");


        }

        private void tbPricePerHour_TextChanged(object sender, EventArgs e)
        {
            //if (workstationSettings.Method == ctrlWorkstation.enBookingMethod.byPrice)
            //{
            //    //tbPrice_TextChanged(sender, e);
            //}
            //else if (workstationSettings.Method == ctrlWorkstation.enBookingMethod.byTime)
            //{
            //    //ValidateTime(sender, e);
            //}
        }

    }
}

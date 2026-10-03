using CyberCoffe_User_Control.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCoffe_User_Control
{
    public partial class ctrlWorkstation : UserControl
    {
        public enum enSessionType { free = 1, byTime = 2, byPrice = 3 }

        private WorkstationEventArgs _Workstation = new WorkstationEventArgs();

        public static event EventHandler<WorkstationEventArgs> OnSessionEnd;

        private byte _WorkstationNum { get; set; }

        public byte WorkstationNum
        {
            set 
            {
                _WorkstationNum = value;
                lbPCNumber.Text = $"PC-{value.ToString("D2")}";
            }
            get { return _WorkstationNum; }
        }

        private byte _Seconds=0;
        private byte _Minutes = 0;
        private byte _Hours = 0;


        public class WorkstationEventArgs : EventArgs
        {
            public byte Hours { set; get; }
            public byte Minutes { set; get; }
            public byte Seconds { set; get; }
            public decimal PricePerHour { set; get; }
            public decimal TotalPrice { set; get; }

            public enSessionType SessionType;

            public WorkstationEventArgs(byte hours, byte minutes, byte seconds, decimal pricePerHour, decimal TotalPrice, enSessionType method)
            {
                this.Hours = hours;
                this.Minutes = minutes;
                this.Seconds = seconds;
                this.PricePerHour = pricePerHour;
                this.TotalPrice = TotalPrice;
                this.SessionType = method;
            }

            public WorkstationEventArgs(decimal pricePerHour, enSessionType method)
            {
                this.PricePerHour = pricePerHour;
                this.SessionType = method;
            }

            public WorkstationEventArgs()
            {
                this.SessionType = enSessionType.free;
                this.Hours = 0;
                this.Minutes = 0;
                this.Seconds = 0;
                this.PricePerHour = 0;
                this.TotalPrice = 0;
            }

        }

        public ctrlWorkstation()
        {
            InitializeComponent();
        }

        private void _SetTimeDataToStart()
        {
            if (_Workstation.SessionType == enSessionType.free)
            {
                _Seconds = 0;
                _Minutes = 0;
                _Hours = 0;
                return;
            }

            _Seconds = _Workstation.Seconds;
            _Minutes = _Workstation.Minutes;
            _Hours = _Workstation.Hours;
        }

        private void _SetEventsToStart()
        {
            if (_Workstation.SessionType == enSessionType.free)
            {
                timer1.Tick += countUp_timer;
            }
            else 
                timer1.Tick += countDown_timer;

        }

        private void _SetSettings(object sender, WorkstationEventArgs workstationsettings)
        {
            _Workstation = workstationsettings;

            _SetEventsToStart();
            _SetTimeDataToStart();

            lblTime.Text = $"{_Workstation.Hours:D2}:{_Workstation.Minutes:D2}:{_Workstation.Seconds:D2}";

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmConfig frm = new FrmConfig();
            frm.OnSettingsSaved += _SetSettings;
            frm.ShowDialog();

            
        }

        private void countUp_timer(object sender, EventArgs e)
        {
            ++_Seconds;

            if (_Seconds >=60)
            {
                ++_Minutes;
                _Seconds = 0;

                if (_Minutes >= 60)
                {
                    _Minutes = 0;
                    ++_Hours;
                }
            }

            lblTime.Text = $"{_Hours:D2}:{_Minutes:D2}:{_Seconds:D2}";
        }

        private void countDown_timer(object sender, EventArgs e)
        {
            if (_Seconds == 0)
            {
                if (_Minutes > 0)
                {
                    _Seconds = 60;
                    --_Minutes;
                }
                else
                {
                    if (_Hours > 0)
                    {
                        --_Hours;
                        _Minutes = 59;
                        _Seconds = 60;
                    }
                }
            }
            if (_Seconds == 0 && _Minutes == 0 && _Hours == 0)
            {
                timer1.Stop();

                _ManageEndTime();
                return;
            }


            --_Seconds;

            lblTime.Text = $"{_Hours:D2}:{_Minutes:D2}:{_Seconds:D2}";

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (btnStart.Tag is true)
            {
                btnStart.Tag = false;
                btnStart.Text = "Start";
                timer1.Stop();
            }
            else
            {
                if (_Workstation.PricePerHour == 0)
                {
                    MessageBox.Show("Enter session settings first!", "Start Session", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }

                picPC.Image = Resources.computer_reserved;
                btnSettings.Enabled = false;
                btnStart.Tag = true;
                btnStart.Text = "Pause";

                btnStop.Enabled = true;
                timer1.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _ManageEndTime();
        }

        private void _ManageEndTime()
        {
            timer1.Stop();

            if (_Workstation.SessionType == enSessionType.free)
            {
                _Workstation.Hours = _Hours;
                _Workstation.Minutes = _Minutes;
                _Workstation.Seconds = _Seconds;
                _Workstation.TotalPrice = clsCalculation.CalculatePriceByTime(_Workstation.PricePerHour, _Hours, _Minutes, _Seconds);
            }


            //Show bill:
            FrmInvoice frm = new FrmInvoice();
            frm.WorkstationNum = _WorkstationNum;

            OnSessionEnd?.Invoke(this, _Workstation);


            frm.ShowDialog();

            

            // Reset: 
            _Workstation = new WorkstationEventArgs();
            btnSettings.Enabled = true;
            btnStop.Enabled = false;
            picPC.Image = Resources.computer_free;
            lblTime.Text = $"{_Workstation.Hours:D2}:{_Workstation.Minutes:D2}:{_Workstation.Seconds:D2}";

            timer1.Tick -= countDown_timer;
            timer1.Tick -= countUp_timer;


            btnStart.Text = "Start";
            btnStart.Tag = false; 

            

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

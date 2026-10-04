using CyberCoffe_User_Control.Settings;
using CyberCoffee_Business;
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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private enum enFromClicked {General=1, TimeSession=2, Pricing=3, System=4}

        private enFromClicked _LastFormClicked;

        private UcPricing _ucpricing = new UcPricing();

        private void btnPricing_Click(object sender, EventArgs e)
        {
            if (_LastFormClicked is enFromClicked.Pricing)
                return;

            _LastFormClicked = enFromClicked.Pricing;

            AddFormToPnlMain(_ucpricing);

            _ucpricing.LoadData();
        }


        public void AddFormToPnlMain(UserControl userControl)
        {
            PnlControl.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            PnlControl.Controls.Add(userControl);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            if (_LastFormClicked is enFromClicked.General)
                return;

            _LastFormClicked = enFromClicked.General;
        }

        private void btnTimeSession_Click(object sender, EventArgs e)
        {
            if (_LastFormClicked is enFromClicked.TimeSession)
                return;

            _LastFormClicked = enFromClicked.TimeSession;
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            if (_LastFormClicked is enFromClicked.System)
                return;

            _LastFormClicked = enFromClicked.System;
        }

        

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            btnPricing.PerformClick(); //perm
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save all user controls edits:

            if(_ucpricing.Save())
            {
                MessageBox.Show("Settings Saved!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Reopen The app to apply changes!");
            }
            else
                MessageBox.Show("Data Failed To Save!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

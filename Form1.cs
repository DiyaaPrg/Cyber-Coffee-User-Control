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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (clsWorkstationPricing.Find())
            {
                ctrlWorkstation1.SetPricePerHour();
                ctrlWorkstation2.SetPricePerHour();
                ctrlWorkstation3.SetPricePerHour();
                ctrlWorkstation4.SetPricePerHour();
                ctrlWorkstation5.SetPricePerHour();
                ctrlWorkstation6.SetPricePerHour();
                ctrlWorkstation7.SetPricePerHour();
                ctrlWorkstation8.SetPricePerHour();
            }
        }

        private void _SetUserControlNum()
        {
            //byte count = 1;

            foreach (Control control in this.Controls)
            {
                if (control is ctrlWorkstation workstation)
                {
                    workstation.WorkstationNum =Convert.ToByte(control.Tag);
                    //++count;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _SetUserControlNum();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();
        }
    }
}

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
    public partial class FrmInvoice : Form
    {

        public byte WorkstationNum { set { lbPCNumber.Text = $"PC-{value.ToString("D2")}"; } }

        public FrmInvoice()
        {
            InitializeComponent();
            ctrlWorkstation.OnSessionEnd += LoadData;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void LoadData(object sender, ctrlWorkstation.WorkstationEventArgs e)
        {


            lbPricePerhour.Text = $"$ {e.PricePerHour}";
            lbSessionType.Text = $"{e.SessionType}";
            lbHours.Text = $"{e.Hours}";
            lbMinutes.Text = $"{e.Minutes}";
            lbSeconds.Text = $"{e.Seconds}";

            lbTotalAmount.Text = $"$ {e.TotalPrice.ToString("F2")}";
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
        }
    }
}

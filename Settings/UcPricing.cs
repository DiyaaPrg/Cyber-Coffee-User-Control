using CyberCoffee_Business;
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

namespace CyberCoffe_User_Control.Settings
{
    public partial class UcPricing : UserControl
    {
        public UcPricing()
        {
            InitializeComponent();
        }

        private void rbSamePrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSamePrice.Checked)
            {
                rbIndividualPrice.Checked = false;
                NupDoUnifiedRate.Enabled = true;
                _FindNumericUpDownInsidePanelAndDoAction(PnlIndividualPrice, _DisableNumericUodDownInIndividualPanel);
            }
        }

        private void rbIndividualPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIndividualPrice.Checked)
            {
                rbSamePrice.Checked = false;
                NupDoUnifiedRate.Enabled = false;

                _FindNumericUpDownInsidePanelAndDoAction(PnlIndividualPrice, _EnableNumericUodDownInIndividualPanel);
            }
        }

        private void _DisableNumericUodDownInIndividualPanel(Guna2NumericUpDown guna2NumericUp)
        {
            guna2NumericUp.Enabled = false;
        }

        private void _EnableNumericUodDownInIndividualPanel(Guna2NumericUpDown guna2NumericUp)
        {
            guna2NumericUp.Enabled = true;
        }

        private void _FindNumericUpDownInsidePanelAndDoAction(Guna2Panel OutsidePanel, Action<Guna2NumericUpDown> action)
        {
            foreach (Control control in OutsidePanel.Controls)
            {
                if (control.GetType() == typeof(Guna2Panel))
                {
                    foreach (Control ControlInsidePanel in control.Controls)
                    {
                        if (ControlInsidePanel.GetType() == typeof(Guna2NumericUpDown))
                        {
                            action?.Invoke((Guna2NumericUpDown)ControlInsidePanel);
                        }
                    }
                }
            }
        }

        private void _FillNumericUpDownFromDictionary(Guna2NumericUpDown guna2NumericUp)
        {
            byte ComputerNum = Convert.ToByte(guna2NumericUp.Tag);

            guna2NumericUp.Value = clsWorkstationPricing.PerDeviceRates[ComputerNum];

        }

        public void LoadData()
        {
            if (clsWorkstationPricing.pricingMode is clsWorkstationPricing.PricingMode.Unified)
            {
                NupDoUnifiedRate.Value = clsWorkstationPricing.UnifiedRate ?? 0;
            }
            else if (clsWorkstationPricing.pricingMode is clsWorkstationPricing.PricingMode.PerDevice)
            {
                _FindNumericUpDownInsidePanelAndDoAction(PnlIndividualPrice, _FillNumericUpDownFromDictionary);
            }
            else
                return;
        }

        private void UcPricing_Load(object sender, EventArgs e)
        {
            rbSamePrice.Checked = true;
        }

        private void FillDictionaryWithRatesFromNumericUpDownControl(Guna2NumericUpDown guna2NumericUp)
        {
            byte ComputerNum = Convert.ToByte(guna2NumericUp.Tag);
            clsWorkstationPricing.PerDeviceRates.Add(ComputerNum, Convert.ToDecimal(guna2NumericUp.Value));
        }

        public bool Save()
        {
            clsWorkstationPricing.pricingMode = (rbSamePrice.Checked) 
                ? clsWorkstationPricing.PricingMode.Unified : clsWorkstationPricing.PricingMode.PerDevice;

            if (clsWorkstationPricing.pricingMode is clsWorkstationPricing.PricingMode.Unified)
                clsWorkstationPricing.UnifiedRate = Convert.ToDecimal(NupDoUnifiedRate.Value);
            else
            {
                _FindNumericUpDownInsidePanelAndDoAction(PnlIndividualPrice, FillDictionaryWithRatesFromNumericUpDownControl);
            }


            return clsWorkstationPricing.Save();
        }

    }
}

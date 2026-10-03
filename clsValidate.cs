using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCoffe_User_Control
{
    internal class clsValidate
    {
        static public void ValidateNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        static public void ValidateFloat(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        static public bool IsEmpty(Guna2TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
                return true;
            return false;
        }

    }


}

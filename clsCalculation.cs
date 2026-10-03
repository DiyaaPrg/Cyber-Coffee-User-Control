using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCoffe_User_Control
{
    internal class clsCalculation
    {
        public static decimal CalculatePriceByTime(decimal pricePerHour, byte hours, byte minutes, byte seconds)
        {
            decimal Minutes = seconds / 60 + minutes;
            decimal TotalHours = (Minutes / 60 + hours);

            return (TotalHours * pricePerHour);

        }

        public static void FindTimeByPrice(decimal pricePerHour, decimal PriceToPay, ref int hours, ref int minutes, ref int seconds)
        {
            int remainder;
            int TotalSeconds = (int) ((PriceToPay / pricePerHour) * 3600);
            hours = (int) (Math.Floor((decimal)TotalSeconds / 3600));
            remainder = TotalSeconds % 3600;
            minutes =(int)(Math.Floor((decimal)(remainder / 60)));
            remainder = remainder % 60;
            seconds = (int)remainder;


        }
    }
}

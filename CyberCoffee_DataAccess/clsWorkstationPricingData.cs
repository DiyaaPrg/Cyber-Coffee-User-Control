using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCoffee_DataAccess
{
    public static class clsWorkstationPricingData
    {
        public enum PricingMode { Unified = 1, PerDevice = 2 }

        public static PricingMode? Find(string folderKeyPath, string ValueName)
        {
            int ?Mode=null;
            try
            {
                 Mode= Convert.ToInt32(Registry.GetValue(folderKeyPath, ValueName, null));
            }
            catch (Exception ex)
            {
                return null;
            }

            return (PricingMode)Mode;
        }

        public static decimal? FindUnifiedRate(string UnifiedRateKeyPath, string ValueName)
        {
            decimal? value=null;
            try
            {
                value = Convert.ToDecimal(Registry.GetValue(UnifiedRateKeyPath, ValueName, true));
            }
            catch(Exception ex)
            {
                value = null;
            }
            return value;
        }

        public static Dictionary<byte, decimal> FindDevicesRate(string DevicesRatesKeyPath)
        {
            Dictionary<byte, decimal> DevicesRates = new Dictionary<byte, decimal>();

            byte count = 1;
            decimal value;
            while (true)
            {
                try
                {
                    object obj = Registry.GetValue(DevicesRatesKeyPath, count.ToString(), true);

                    if (obj != null)
                    {
                        value = Convert.ToDecimal(obj);
                        DevicesRates.Add(count, value);
                    }
                    else
                        break;
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"An error occurred: {ex.Message}");
                }
                ++count;
            }

            return DevicesRates;
        }

        public static bool AddPricingModeToRegistry(string folderKeyPath, string ValueName, int valueData)
        {
            try
            {
                Registry.SetValue(folderKeyPath, ValueName, valueData);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool AddDevicesRateToRegistry(string folderKeyPath, Dictionary<byte, decimal> DevicesRates)
        {
            foreach (byte key in DevicesRates.Keys)
            {
                try
                {

                    Registry.SetValue(folderKeyPath, key.ToString(), DevicesRates[key]);
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool AddUnifiedRateToRegistry(string folderKeyPath, string ValueName, decimal ?valueData)
        {
            try
            {
                Registry.SetValue(folderKeyPath, ValueName, valueData);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}

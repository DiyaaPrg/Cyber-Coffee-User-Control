using CyberCoffee_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CyberCoffee_Business
{
     public static class clsWorkstationPricing
    {
        public  enum PricingMode{Unified=1,  PerDevice=2}

        public static PricingMode? pricingMode = null;

        public static decimal? UnifiedRate = null;
        public static Dictionary<byte, decimal> PerDeviceRates = new Dictionary<byte, decimal>();

        private const string _FolderKeyPath = @"HKEY_CURRENT_USER\Software\CyberCoffee";
        private const string _UnifiedRateKeyPath = @"HKEY_CURRENT_USER\Software\CyberCoffee\UnifiedRate";
        private const string _DevicesRatesKeyPath = @"HKEY_CURRENT_USER\Software\CyberCoffee\DevicesRates";
        private const string _UnifiedRateValueName = "UnifiedRate";
        //private static string _DevicesRatesValueName = "";
        private const string _ModeValueName = "PricingMode";



        private static bool _AddUnifiedRateToRegistry()
        {
            // change PricingMode value in windows registry: ( add)
            pricingMode = PricingMode.Unified;

            _AddPricingModeToRegistry();

            // check UnifiedRate folder exist first (if not create folder in registry):
            //if exists: delete its value 

            // add new value
            return clsWorkstationPricingData.AddUnifiedRateToRegistry(_UnifiedRateKeyPath, _UnifiedRateValueName, UnifiedRate);

        }

        private static bool _AddDevicesRateToRegistry()
        {
            // change PricingMode value in windows registry: (add)
            pricingMode = PricingMode.PerDevice;
            _AddPricingModeToRegistry();


            // check UnifiedRate folder exist first (if not create folder in registry):
            //if exists: delete its value 
            return clsWorkstationPricingData.AddDevicesRateToRegistry(_DevicesRatesKeyPath, PerDeviceRates);


        }

        private static bool _AddPricingModeToRegistry()
        {
            return clsWorkstationPricingData.AddPricingModeToRegistry(_FolderKeyPath, _ModeValueName, (int)pricingMode);
        }

        private static bool _FindUnifiedRate()
        {
            UnifiedRate = clsWorkstationPricingData.FindUnifiedRate(_UnifiedRateKeyPath, _UnifiedRateValueName);
            return (UnifiedRate != null);
        }

        private static bool _FindDevicesRate()
        {
            PerDeviceRates = clsWorkstationPricingData.FindDevicesRate(_DevicesRatesKeyPath);
            return (PerDeviceRates != null);
        }

        public static bool Find()
        {
            var ModeFind = clsWorkstationPricingData.Find(_FolderKeyPath, _ModeValueName);
            pricingMode = (PricingMode)ModeFind;

            // find mode if (unified then enter unified folder and get value (check it exist), or devicesRates then same thing):
            if ( ModeFind is clsWorkstationPricingData.PricingMode.Unified)
            {
                return _FindUnifiedRate();
            }
            else if (ModeFind is clsWorkstationPricingData.PricingMode.PerDevice)
            {
                return _FindDevicesRate();
            }
            else
            {
                return false;
            }
        }

        public static bool Save()
        {
            switch(pricingMode)
            {
                case PricingMode.Unified:
                    return _AddUnifiedRateToRegistry();

                case PricingMode.PerDevice:
                    return _AddDevicesRateToRegistry();

                default:
                    break;
                    
            }

            return false;
        }


    }
}

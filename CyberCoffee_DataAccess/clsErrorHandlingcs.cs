using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCoffee_DataAccess
{
    internal class clsErrorHandlingcs
    {
        public const string SourceName = "CyberCafé";

        public static void WriteInLogEvent(string message)
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName, message, EventLogEntryType.Error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class EventLogs
    {
        static void Main()
        {
            if (!EventLog.Exists("Raja Event"))
            {
                EventLog.CreateEventSource("My System", "Raja Event");
            }
            EventLog myLog = new EventLog("Raja Event");
            myLog.Source = "My System";
            myLog.WriteEntry("Raja has started event");
            Console.WriteLine("Raj's event has started successfully");
            Console.ReadKey();
        }
    }
}

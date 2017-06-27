using ServiceBus.Scenarios;
using System;
using System.Diagnostics;

namespace ServiceBus.WebSockets.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Trace.TraceLevel = TraceLevel.Frame;
         //   Trace.TraceListener = (l, f, a) => Console.WriteLine(DateTime.Now.ToString("[hh:mm:ss.fff]") + " " + string.Format(f, a));

            try
            {
                new WebSocketsExample().Run();
            }
            catch (Exception e)
            {
                Trace.WriteLine(TraceLevel.Error, e.ToString());
            }
        }
    }
}

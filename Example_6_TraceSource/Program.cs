using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6_TraceSource
{
    class Program
    {
        static void Main(string[] args)
        {

            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 2 + 4;
            Debug.Assert(i == 6);
            Debug.WriteLineIf(i > 0, "i > 0");
            Console.ReadLine();
   
        }

        private void TraceToOutput()
        {

            TraceSource traceSource = new TraceSource("TraceSource", SourceLevels.All);
            traceSource.TraceInformation("Tracing");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical");
            traceSource.TraceData(TraceEventType.Information, 1, new object[] { "x", "y", "z" });
            traceSource.Flush();
            traceSource.Close();
        }

        private void TraceToFile()
        {
            Stream TrFile = File.Create("Hello_Debug_Trace.txt");
            TextWriterTraceListener txtLstnr =
                new TextWriterTraceListener(TrFile);

            TraceSource traceSource = new
                TraceSource("TraceSource", SourceLevels.All);
            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(txtLstnr);
            traceSource.TraceInformation("Trace output");
            traceSource.Flush();
            traceSource.Close();
        }
    }
}

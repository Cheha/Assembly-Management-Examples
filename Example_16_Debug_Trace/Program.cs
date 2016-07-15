using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DebugAndTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 0;
            int c = a / b;
            Debug.WriteLine("Helloo");
            
            //
            Debug.Indent();
            Debug.WriteLine("Two");
            Debug.WriteLine("Three");
            Debug.Unindent();

            // End.
            Debug.WriteLine("Four");
            //Debug.Fail("Message");
            //Debug.Assert(4 > 5);
        }
    }
}

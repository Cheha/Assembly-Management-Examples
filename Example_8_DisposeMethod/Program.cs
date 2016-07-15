using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example_8_DisposeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader rdr = null;
            try {
                rdr = new StreamReader("Hello_Debug_Trace.txt");
                string s = rdr.ReadToEnd();
                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("StreamReader: "+ex.Message); 
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Dispose();
                }
            }
            TextReader rdr1 = null;
            try {
                using (rdr1 = new StreamReader("Hello_Debug_Trace.txt"))
                {
                    string s = rdr1.ReadToEnd();
                    Console.WriteLine(s); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("StreamReader: " + ex.Message); 
            }
        }
    }
}

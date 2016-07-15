using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Example_7_PerfomanceCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounter theCpuCounter = new PerformanceCounter("Process", "% Processor Time",
                Process.GetCurrentProcess().ProcessName);
            PerformanceCounter theMemoryCounter = new PerformanceCounter("Process", "Working set",
                Process.GetCurrentProcess().ProcessName);
            theCpuCounter.NextValue();
            theMemoryCounter.NextValue();
            Console.WriteLine("Use spasebar key to stop");
            {
                string str = "CPU, Memory:";
                Console.WriteLine(str);
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(" " + theCpuCounter.RawValue + ", " + theMemoryCounter.RawValue);
                        Console.SetCursorPosition(str.Length, Console.CursorTop);
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
            }
        }
    }
}

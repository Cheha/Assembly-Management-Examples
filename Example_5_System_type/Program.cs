using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_System_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly systemAssembly = Assembly.Load("system, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            Type[] systemTypes = systemAssembly.GetTypes();

            foreach (var item in systemTypes)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Type: {0}", item);
                MethodInfo[] methodsInfo = item.GetMethods();
                foreach (var method in methodsInfo)
                {
                    Console.WriteLine("Method: {0}", method.Name);
                }
            }
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_12_ObsoleteAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            //student.SayHello();
            //student.SayBye();
        }
    }

    public class Student
    {
        [Obsolete]
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        [Obsolete("This method is private", true)]
        public void SayBye()
        {
            Console.WriteLine("Hello");
        }
    }
}

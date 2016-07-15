using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrainAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("BrainAcademy.Customer");

            Console.WriteLine("BrainAcademy.Customer properties");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo prop in properties) {
                Console.WriteLine(prop.PropertyType.Name + " " + prop.Name);
            }

            Console.WriteLine("BrainAcademy.Customer methods");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo meth in methods)
            {
                Console.WriteLine(meth.ReturnType.Name + " " + meth.Name);
            }

            Console.WriteLine("BrainAcademy.Customer constructors");
            ConstructorInfo[] contructors = T.GetConstructors();
            foreach (ConstructorInfo ctor in contructors)
            {
                Console.WriteLine(ctor.ToString());
            }



            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer() {
            this.Id = 1;
            this.Name = "Sergey";
        }

        public Customer(int id, string name) {
            this.Id = id;
            this.Name = name;
        }

        public void PrintId() {
            Console.WriteLine("Customers id: {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Customers name: {0}", this.Name);
        }
    }
}

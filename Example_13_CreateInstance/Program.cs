using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BrainAcademy
{
    public class Customer
    {
        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Get the type contained in the name string
            Type type = Type.GetType("BrainAcademy.Customer");
            // create an instance of that type
            object instance = Activator.CreateInstance(type);
            // Get a property on the type that is stored in the
            // property string
            PropertyInfo property = type.GetProperty("Name");

            // Set the value of the given property on the given instance
            property.SetValue(instance, "Alex", null);
            Customer cust = (Customer)instance;
            // at this stage instance.Bar will equal to the value
            Console.WriteLine(((Customer)instance).Name);

            //////////////////////////////////////////////

            Customer customer = new Customer();
            customer.Name = "Viktor";

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BirdSpeciesLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
        AllowMultiple = true, Inherited = false)]
    public sealed class BirdSpeciesAttribute : Attribute
    {
        public string Classification { get; set; }

        public BirdSpeciesAttribute(string birdSpecies)
        {
            Classification = birdSpecies;
        }

        public BirdSpeciesAttribute() { }
    }
}

namespace Example_4_Assembly_load
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("system, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            Console.WriteLine("GAC: {0}", asm.GlobalAssemblyCache);
            Console.WriteLine("Name: {0}", asm.GetName().Name);
            Console.WriteLine("Version: {0}", asm.GetName().Version);
            Console.WriteLine("Cuslture: {0}", asm.GetName().CultureInfo.DisplayName);
            Console.Read();
        }
    }
}

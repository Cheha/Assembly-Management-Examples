using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Attribute_creation
{
    using BirdSpeciesLibrary;
    class Program
    {
        static void Main(string[] args)
        {
            var crow = new Crow();
            crow.GetAttributeInfo();
            Console.ReadLine();
        }
    }
}

namespace BirdSpeciesLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
        AllowMultiple=true, Inherited=false)]
    public sealed class BirdSpeciesAttribute : Attribute
    {
        public string Classification { get; set; }

        public BirdSpeciesAttribute(string birdSpecies) {
            Classification = birdSpecies;
            Console.WriteLine(birdSpecies);
        }

        public BirdSpeciesAttribute() { }
    }

    // Examples
    [Serializable]
    [BirdSpecies("Crow")]
    public class Crow {
        public void GetAttributeInfo()
        {
            Type type = typeof(Crow);
            BirdSpeciesAttribute birdSpecAttr = 
                (BirdSpeciesAttribute)Attribute.GetCustomAttribute(typeof(Crow), typeof(BirdSpeciesAttribute));

            // Get the Name value.
            Console.WriteLine("The Attribute is: {0}.", birdSpecAttr.Classification);
        }
    }

    [BirdSpecies("Parrot")]
    public class Parrot { 
        
    }
}

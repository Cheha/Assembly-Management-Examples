using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrainAcademy.Classes
{
    public static class Calculator
    {
        public static double Add(double arg1, double arg2)
        {
            return arg1 + arg2;
        }

        public static double Sub(double arg1, double arg2)
        {
            return arg1 - arg2;
        }

        public static double Mul(double arg1, double arg2)
        {
            return arg1 * arg2;
        }

        public static double Div(double arg1, double arg2)
        {
            if (arg2 == 0.0)
            {
                throw new DivideByZeroException("Argument equals zero");
            }
            return arg1 / arg2;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public bool HasCard { get; set; }

        public Customer() {
            Name = null;
            Amount = 0.0;
            HasCard = false;
        }

        public Customer(string name, double amount, bool hasCard) {
            this.HasCard = hasCard;
            this.Name = name + 50;
            this.Amount = amount;
        }

        public bool IsEnaugh(double sum) {
            return this.Amount > sum;
        } 
    }

    public class Program
    {
        

        static void Main(string[] args)
        {
        }
    }

}

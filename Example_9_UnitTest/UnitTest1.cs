using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainAcademy.Classes;

namespace Example_9_UnitTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Check_Correct_Division()
        {
            // arrange
            double arg1 = 4.0;
            double arg2 = 2.0;
            double expected = 2.0;
            //act
            double actual = arg1 / arg2;
            // assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod,
        ExpectedException(typeof(DivideByZeroException))]
        public void Check_Exception_Division()
        { 
            // arrange 
            int arg1 = 1;
            int arg2 = 0;
            // act
            int actual = arg1 / arg2;
        }
    }

    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Check_Constructor_Without_Params_Success() { 
            // arrange
            string name = "Unknown";
            double amount = 0.0;
            bool hasCard = false;
            // act
            Customer testCustomer = new Customer();
            // assert
            Assert.AreEqual(name, testCustomer.Name);
            Assert.AreEqual(amount, testCustomer.Amount);
            Assert.AreEqual(hasCard, testCustomer.HasCard);
        }

        [TestMethod]
        public void Check_Constructor_With_Params_Success() {
            // arrange
            string name = "John";
            double amount = 150.0;
            bool hasCard = true;
            // act
            Customer testCustomer = new Customer(name, amount, hasCard);
            // assert
            Assert.AreEqual(name, testCustomer.Name);
            Assert.AreEqual(amount + 50, testCustomer.Amount);
            Assert.AreEqual(hasCard, testCustomer.HasCard);
        }

        [TestMethod]
        public void Check_IsEnaugh_Success() { 
            // arrange
            string name = "John";
            double amount = 150.0;
            bool hasCard = true;
            Customer testCustomer = new Customer(name, amount, hasCard);
            double sum = 100.0;
            // act
            bool isSuccess = testCustomer.IsEnaugh(sum);
            // assert
            Assert.AreEqual(true, isSuccess);
        }


    }
}

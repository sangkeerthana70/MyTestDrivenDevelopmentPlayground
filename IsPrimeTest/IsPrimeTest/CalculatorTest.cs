using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorTest
    {
        Calculator calculator;
        [SetUp]
        public void SetUp()
        {
             calculator = new Calculator();
        }
        

        [Test]
        public void addReturnsInteger()
        {
            //Calculator calculator = new Calculator();
            var actual = calculator.addNumbers(2, 3);
            int expected = 5;
            Assert.IsTrue(actual.GetType() == expected.GetType(), "Result should be of type integer");
        }
        [TestCase(7,97)]
        [TestCase(15, 25)]
        public void AddResultGreaterThanInput(int n1, int n2)
        {
            //Calculator calculator = new Calculator();
            var actual = calculator.addNumbers(n1,n2);
            Assert.IsTrue(((actual > n1) && (actual > n2)), "Result should be greater than individual numbers");
        }
        [TestCase(7, 97)]
        [TestCase(15, 25)]
        [TestCase(7, -97)]
        //this method checks for adding two zeros as well
        public void AddTwoPositiveIntegers(int n1, int n2)
        {
            
            var actual = calculator.addNumbers(n1, n2);
            Console.WriteLine(actual);
            Assert.IsTrue(actual == (n1 + n2), "Result should return only positive integers");
        }
        [TestCase(7, -97)]
        [TestCase(15, 25)]
        //this method checks for subtraction
        public void SubtractTwoNumbers(int n1, int n2)
        {

            var actual = calculator.subtractNumbers(n1, n2);
            Console.WriteLine(actual);
            Assert.IsTrue(actual == (n1 - n2), "Result should return only negative integers");
        }


    }
}

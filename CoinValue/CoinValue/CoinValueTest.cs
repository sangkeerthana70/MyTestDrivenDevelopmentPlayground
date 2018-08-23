using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinValue
{
    class CoinValueTest
    {
        //global variable
        Coin coin;
        [SetUp]
        public void SetUp()
        {
            coin = new Coin();
        }
        [TestCase("Zero")]
        public void ReturnsInteger(string input)
        {
            var actual = coin.GetCoinValue(input);
            var expected = -1;
            Console.WriteLine(actual.GetType());
            Assert.AreEqual(actual.GetType(), expected.GetType(),"Result should be of type integer");
        }
        [TestCase("Quarter")]
        public void QuarterReturns25(string input)
        {            
                var actual = coin.GetCoinValue(input);
                var expected = 25;
                Console.WriteLine(actual);
                Assert.AreEqual(actual, expected, "Result should return an integer");           
        }
        [TestCase("Dime")]
        public void DimeReturns10(string input)
        {
            var actual = coin.GetCoinValue(input);
            var expected = 10;
            Console.WriteLine(actual);
            Assert.IsTrue(actual == expected, "Actual result should return an integer");
        }


    }
}

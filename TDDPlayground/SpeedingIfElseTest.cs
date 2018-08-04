using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDPlayground
{
    class SpeedingIfElseTest
    {
        [Test]
        public void test_no_ticket([Values(0, 40, 50, 60, -40)] int speed)
        {
            string ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            //Console.WriteLine("input = {0} , output = {1} ", speed, ticket);
            Assert.AreEqual("No ticket", ticket);
        }

        [Test]
        public void test_small_ticket([Values(61, 79, 80)] int speed)
        {
            string ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            //Console.WriteLine("input = {0} , output = {1} ", speed, ticket);
            Assert.AreEqual("Small ticket", ticket);
        }


        [Test]
        public void test_big_ticket([Values(81, 110)] int speed)
        {
            string ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            //Console.WriteLine("input = {0} , output = {1} ", speed, ticket);
            Assert.AreEqual("Big ticket", ticket);
        }



    }
}

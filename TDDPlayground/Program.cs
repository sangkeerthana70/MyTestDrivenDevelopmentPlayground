using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            //TDD Phase
            int speed;
            string ticket;

            speed = 0;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 50;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 60;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 61;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 79;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = 80;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);


            speed = 81;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

            speed = -49;
            ticket = SpeedingIfElse.IssueSpeedTicket(speed);
            Console.WriteLine("input = {0} , output = {1} ", speed, ticket);

        }
    }
}

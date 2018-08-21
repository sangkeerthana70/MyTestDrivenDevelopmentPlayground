using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        //property
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        //empty constructor
        public Calculator()
        {
            
        }
        //method
        public int addNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int subtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        
        
            



        
    }

    
}

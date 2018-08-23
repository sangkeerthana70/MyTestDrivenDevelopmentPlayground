using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinValue
{
    class Coin
    {
        //property
        public string coin { get; set; }
        //empty constructor
        public Coin()
        {

        }
        //methods
        public int GetCoinValue(string coin)
        {
            int result = -1;
            if (coin == "Quarter")
            {
                result = 25;
            }                    
            else if (coin == "Dime")
            {
                return 15;
            }
            return result;

            /*
            else if (coin == "Nickel")
            {

            }*/
        }
    }

    


}

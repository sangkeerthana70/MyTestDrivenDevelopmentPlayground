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
            return result;
            /*
            else if (coin == "Dime")
            {
                return 10;
            }
            else if (coin == "Nickel")
            {

            }*/
        }
    }

    


}

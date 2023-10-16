using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OCP.BadExample
{
    public enum CoffeeType { Latte = 1, Expresso, Mocha, CaramelMacchiato }
    public class BadCoffee
    {
        public double GetTotalPrice(double quantity, CoffeeType coffeeType) 
        {
            double totalPrice = 0;
            if (coffeeType == CoffeeType.Latte)
            {
                totalPrice += quantity * 49;
            }
            else if (coffeeType == CoffeeType.Mocha)
            {
                totalPrice += quantity * 88;
            }
            else if (coffeeType == CoffeeType.Expresso)
            {
                totalPrice += quantity * 26;
            }
            else if (coffeeType == CoffeeType.CaramelMacchiato)
            {
                totalPrice += quantity * 79;
            }

            return totalPrice;

        }
    }
}

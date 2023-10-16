using _2.OCP.BadExample;
using _2.OCP.GoodExample.Concrete;

namespace _2.OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bad
            //int adet = 25;
            //CoffeeType coffeeType = CoffeeType.Latte;

            //BadCoffee badCoffee = new BadCoffee();
            //Console.WriteLine("Toplam ücret => " + badCoffee.GetTotalPrice(adet, coffeeType));
            #endregion
            #region Good
            //int adet = 25;
            //Latte latte = new Latte();
            //Console.WriteLine("Latte fiyatı => " + latte.GetTotalPrice(adet));

            #endregion
        }
    }
}
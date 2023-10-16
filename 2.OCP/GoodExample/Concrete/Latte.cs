using _2.OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OCP.GoodExample.Concrete
{
    public class Latte : GoodCoffeeShop
    {
        public override double GetTotalPrice(double quantity)
        {
            return quantity * 49;
        }
    }
}

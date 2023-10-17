using _4.ISP.GoodExample.InterfaceGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.GoodExample.ConcreteGood
{
    public class ChickenGood : IWalkBird
    {
        public string Walk() => "Chicken can walk!";
    }
}

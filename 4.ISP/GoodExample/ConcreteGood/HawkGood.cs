using _4.ISP.GoodExample.InterfaceGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.GoodExample.ConcreteGood
{
    public class HawkGood : IFlyBird, IWalkBird
    {
        public string Fly() => "Hawks can fly!";

        public string Walk() => "Hawks can walk!";
    }
}

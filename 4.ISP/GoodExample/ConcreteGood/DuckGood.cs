using _4.ISP.GoodExample.InterfaceGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.GoodExample.ConcreteGood
{
    public class DuckGood : IWalkBird, IFlyBird, ISwimmBird
    {
        public string Fly() => "Ducks can fly!";
        public string Swimm() => "Ducks can swim!";
        public string Walk() => "Ducks can walk!";
    }
}

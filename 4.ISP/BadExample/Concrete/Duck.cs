using _4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.BadExample.Concrete
{
    public class Duck : IBird
    {
        public string Fly() => "Ducks can fly!";

        public string Swim() => "Ducks can swim!";

        public string Walk() => "Ducks can walk!";
    }
}

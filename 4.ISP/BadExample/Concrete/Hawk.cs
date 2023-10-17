using _4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.BadExample.Concrete
{
    public class Hawk : IBird
    {
        public string Fly() => "Hawks can fly!";

        public string Swim() => "Hawks can't swim!";

        public string Walk() => "Hawks can walk!";
    }
}

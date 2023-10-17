using _4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ISP.BadExample.Concrete
{
    public class Chicken : IBird
    {
        //IBird sınıfından kalıtım yoluyla gereksiz yetenek kazanan Chicken.cs sınıfı ISP prensibine ters düşmüştür. 
        public string Fly() => "Chickens can't fly!";

        public string Swim() => "Chickens can't swim!";

        public string Walk() => "Chickens can walk!";
    }
}

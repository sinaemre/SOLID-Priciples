using _3.LSP.GoodExample.InterfaceGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.GoodExample.ConcreteGood
{
    public class UcakAGood : IKesifYap, IHedefiVur
    {
        public bool HedefiVur()
        {
            Console.WriteLine("Uçak A Hedefi vurdu!");
            return true;
        }

        public bool KesifYap()
        {
            Console.WriteLine("Uçak A keşif yaptı!");
            return true;
        }
    }
}

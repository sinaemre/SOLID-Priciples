using _3.LSP.GoodExample.InterfaceGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.GoodExample.ConcreteGood
{
    internal class UcakCGood : IKesifYap
    {
        public bool KesifYap()
        {
            Console.WriteLine("Uçak C keşif yaptı!");
            return true;
        }
    }
}

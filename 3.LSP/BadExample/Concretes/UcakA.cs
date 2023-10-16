using _3.LSP.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.BadExample.Concretes
{
    public class UcakA : IUcak
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

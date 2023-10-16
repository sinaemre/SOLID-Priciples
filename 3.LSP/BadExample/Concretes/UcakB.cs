using _3.LSP.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.BadExample.Concretes
{
    public class UcakB : IUcak
    {
        public bool HedefiVur()
        {
            Console.WriteLine("Uçak B Hedefi vurdu!");
            return true;
        }

        public bool KesifYap()
        {
            Console.WriteLine("Uçak B keşif yaptı!");
            return true;
        }
    }
}

using _3.LSP.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LSP.BadExample.Concretes
{
    public class UcakC : IUcak
    {
        public bool HedefiVur()
        {
            return false;
        }

        public bool KesifYap()
        {
            Console.WriteLine("Uçak C keşif yaptı!");
            return true;
        }
    }
}

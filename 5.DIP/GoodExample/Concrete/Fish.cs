using _5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.GoodExample.Concrete
{
    public class Fish : IProduct
    {
        public string GetCookingInfo() => "Balık tarifleri...";
    }
}

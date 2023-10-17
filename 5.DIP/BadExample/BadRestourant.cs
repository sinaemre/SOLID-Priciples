using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.BadExample
{
    public class BadRestourant
    {
        BadFish badFish = new BadFish();
        BadPoultry badPoultry = new BadPoultry();

        public string GetCookingInfo() => $"{badFish.GetFish()} - {badPoultry.GetPoultry()}";
    }
}

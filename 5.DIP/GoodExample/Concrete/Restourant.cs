using _5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DIP.GoodExample.Concrete
{
    public class Restourant
    {
        private readonly IProduct _product;

        public Restourant(IProduct product)
        {
            _product = product;
        }

        public string GetCookingInfoFoods() => $"{_product.GetCookingInfo()}";
    }
}

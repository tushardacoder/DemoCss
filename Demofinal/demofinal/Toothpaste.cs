using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demofinal
{
    public class Toothpaste:Iproduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

        public decimal GetDiscountprice()
        {
              return (Price*15)/100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demofinal
{
    public interface Iproduct
    {
             string Name { get; set; }
             decimal Price { get; set; }
             decimal Discount { get; set; }

             decimal GetDiscountprice();
    } 
}

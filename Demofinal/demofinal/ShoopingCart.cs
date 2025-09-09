using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demofinal
{
    internal class ShoopingCart
    {
        public Iproduct[] products { get; set; }
        public int ItemCount { get; set; }

        public void showcartitems()
        {
            var total = 0M;

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + item.Price + item.Discount);
                total += item.Discount;
            }

            Console.WriteLine(total);
        }
    }

}

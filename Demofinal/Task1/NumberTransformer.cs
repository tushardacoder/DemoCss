using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NumberTransformer
    {
        public int Number { private set; get; }
        public NumberTransformer() {
             Number = 0;
        }
        public NumberTransformer(int initialNumber) {
            Number = initialNumber;
        }

        public void AddDigit(int digit)
        {
            Number = (Number * 10) + digit;
        }

        public void AddDigit(int[] arr)
        {
            foreach(int digit in arr)
            {
                Number = (Number * 10) + digit;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public  class Utility
    {
        public  int _id;
        public string Location { get; set; }

        public Utility()
        {
            _id = 1;
            Location = "Dhaka";
        }

        public  string AppendLoction(string text)
        {
            return Location + text;
        }
    }
}

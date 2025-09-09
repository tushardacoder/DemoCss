using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Utility
    {
        public static int _id;
        public static string Location { get; set; }

        static Utility()
        {
            _id = 1;
            Location = "Dhaka";
        }

        public static string AppendLoction(string text)
        {
            return Location + text;
        }
    }
}

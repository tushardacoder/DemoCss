using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class User
    {
        public virtual string MakeUsername(string username)
        {
            return username+username;
        }
    }
}

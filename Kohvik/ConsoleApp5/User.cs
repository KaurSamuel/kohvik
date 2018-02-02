using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class User
    {
        public double Balance;
        public List<Kohv> Shopping_cart = new List<Kohv>();      
        public User()
        {
            Balance = 0;
            //Shopping_cart.Add(new Kaffe_Late());
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class CoffeeTableBook : Book
    {
        public CoffeeTableBook(string ISBN, string title, string author, decimal price) : base(ISBN, title, author, price)
        {
          
        }

        public override decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 35)
                {
                    _price = 35;
                }
                else if (value > 100)
                {
                    _price = 100;
                }
                else
                {
                    _price = value;
                }
            }
        }
    }
}

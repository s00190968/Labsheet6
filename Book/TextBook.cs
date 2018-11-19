using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class TextBook : Book
    {
        string studentYear { get; set; }

        public TextBook(string ISBN, string title, string author, decimal price, string studentYear) : base( ISBN, title, author, price)
        {
            this.studentYear = studentYear;
        }

        public override string ToString()
        {
            
            return base.ToString() + "\nYear: " + studentYear;
        }

        public override decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 20)
                {
                    price = 20;
                }
                else if (value > 80)
                {
                    price = 80;
                }
                else
                {
                    _price = value;
                }
            }
        }
    }
}

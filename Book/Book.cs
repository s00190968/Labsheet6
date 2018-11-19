using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string ISBN { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public virtual decimal price { get; set; }
        public decimal _price;

        public Book(string ISBN, string title, string author, decimal price)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override string ToString()
        {
            return "ISBN: " + ISBN + "\nTitle: " + title + "\nAuthor: " + author + "\nPrice: " + price;
        }
    }
}

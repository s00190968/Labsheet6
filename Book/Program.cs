using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            //book
            books.Add(new Book("465465", "Best everbook", "kathryn dellis", 10));

            //textbooks
            books.Add(new TextBook("894465", "worst everbook", "name lastname", 10, "2006"));
            books.Add(new TextBook("5534545452", "last time", "tetra packs", 50, "2009"));
            books.Add(new TextBook("254634654", "what is this", "kathryn dellis", 150,"2018"));

            //coffee books
            books.Add(new CoffeeTableBook("54161", "Score", "bottle flower", 20));
            books.Add(new CoffeeTableBook("8446892", "50 points", "jackey doom", 42));
            books.Add(new CoffeeTableBook("35458", "only accents", "kate somewherethere", 180));

            foreach (Book b in books)
            {
                Console.WriteLine(b + "\n");
            }
        }
    }
}

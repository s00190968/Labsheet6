using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill b = new Bill("sansa sdansaj", (decimal)45.5);
            OverdueBill ob = new OverdueBill("fsdv ggddf", (decimal)64.45, 6);

            Console.WriteLine(b);
            Console.WriteLine(ob);
        }
    }
}

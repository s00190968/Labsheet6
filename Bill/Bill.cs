using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
     class Bill
    {
        protected string name { get; set; }
        protected decimal amount { get; set; }

        public Bill(string name, decimal amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public override string ToString()
        {
            return name + ", " + amount;
        }
    }
}

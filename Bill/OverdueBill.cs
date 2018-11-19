using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    class OverdueBill : Bill
    {
        protected int days { get; set; }

        public OverdueBill(string name, decimal amount, int days) : base(name, amount)
        {
            this.days = days;
        }
    }
}

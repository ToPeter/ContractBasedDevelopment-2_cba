using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCustomer
{
    class Movement
    {
        public DateTime date;
        public double amount;

        public Movement(DateTime date, double amount)
        {
            this.date = date;
            this.amount = amount;
        }



    }
}

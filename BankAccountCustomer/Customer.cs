using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCustomer
{
   

    class Customer
    {
        public Bank b1 = new Bank();
        public Customer()
        {
        }

        public void makeReguest(int customer_id, double amountToMove, int account)
        {
            
            b1.move(amountToMove, customer_id, account);

        }
    }
}

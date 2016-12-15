using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace BankAccountCustomer
{
    class Program
    {
        
      
        static void Main(string[] args)
        {
            
            Customer c1 = new Customer();
            Contract.Requires(c1 != null);


            int customer_id = 123;
            int account = 124;           
            double amountToMove = 5000.123;

            Console.WriteLine("Transaction FROM customerID(123) TO customer(124)");
            Console.WriteLine("Sender initial balance: " + 10000.123);
            Console.WriteLine("Receiver initial balance: " + 20000.0);
            Console.WriteLine("Amount: " + amountToMove);
            Console.WriteLine("<------------------------------->");

            c1.makeReguest(customer_id, amountToMove, account);
            c1.makeReguest(customer_id, amountToMove, account);
            c1.makeReguest(customer_id, amountToMove, account);

            while (true)
            {

            }

        }
    }
}

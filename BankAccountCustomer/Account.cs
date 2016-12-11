using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace BankAccountCustomer
{
    class Account
    {
        public int number;
        public double balance;
        public ArrayList accountCredits;
        public ArrayList accountDebits;

        public Account(int number, double balance, ArrayList accountCredits, ArrayList accountDebits)
        {
            this.number = number;
            this.balance = balance;
            this.accountCredits = accountCredits;
            this.accountDebits = accountDebits;
        }

        public Account()
        {
        }

        public class Movement
        {         
            public DateTime date;

            public Movement()
            {
            }

            private bool _isCredit;
            public bool IsCreddit
            {
                get { return _isCredit; }
                set { _isCredit = value; }
            }

            private double _amount;
            public double Amount
            {
                get { return _amount; }
                set { _amount = value; }
            }

            public string buildMOvementRecord()
            {
                date = DateTime.Now;
                string myDate = date.ToString("dd-MM-yyyy HH:mm s");
                string amount = Amount.ToString();
                string dateAmountBuild = myDate + "|" + amount;
                return dateAmountBuild;
            }
        }
    }
}

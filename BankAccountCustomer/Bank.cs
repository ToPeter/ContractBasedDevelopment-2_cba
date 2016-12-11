using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace BankAccountCustomer
{
    class Bank
    {
        public ArrayList accountList;
        public ArrayList accountCredits;
        public ArrayList accountDebits;
        public ArrayList accountCredits1;
        public ArrayList accountDebits1;
        public bool alreadyDone = false;
        Account.Movement temp_am_move = new Account.Movement();
        public Bank()
        {
        }
        private void initializeAccounts()
        {            
            if (!alreadyDone)
            {
                accountList = new ArrayList();

                //Double booking standard
                accountCredits = new ArrayList();
                accountDebits = new ArrayList();
                accountCredits1 = new ArrayList();
                accountDebits1 = new ArrayList();

                //TODO one more Array for Bank vs. CLient (just credit)
                Account senderAccount = new Account(123, 10000.56654, accountCredits, accountDebits);
                Account receiverAccount = new Account(124, 20000.0, accountCredits1, accountDebits1);

                accountList.Add(senderAccount);
                accountList.Add(receiverAccount);

                alreadyDone = true;
            }             
        }

        public void move(double amount, int source, int target)
        {
            initializeAccounts();
            
            for (int k = 1; k <= accountList.Count; k++)
            {
                Account temp_obj = (Account)accountList[k-1];
                temp_am_move.Amount = amount;
                if (temp_obj.number == source)
                {
                  
                   temp_obj.balance -= amount;
  
                    if (amount > 0)
                    {
                        temp_am_move.IsCreddit = true;                                            
                        temp_obj.accountCredits.Add(temp_am_move.buildMOvementRecord());
                    }
                    if (amount < 0)
                    {
                        temp_am_move.IsCreddit = false;
                        temp_obj.accountDebits.Add(temp_am_move.buildMOvementRecord());
                    }
                    
                    accountList.RemoveAt(k-1);
                    accountList.Insert(k-1,temp_obj);
  
                    Console.WriteLine("Sender ID------>" + temp_obj.number);
                    Console.WriteLine("Sender balance------>" + temp_obj.balance);

                    for (int p = 1; p <= temp_obj.accountCredits.Count; p++)
                    {
                        Console.WriteLine("Sender creditList------>" + temp_obj.accountCredits[p-1].ToString());
                    }

                    for (int l = 1; l <= temp_obj.accountDebits.Count; l++)
                    {
                        Console.WriteLine("Sender debitList------>" + temp_obj.accountDebits[l-1].ToString());
                    }

                        Console.WriteLine("<---------->");
                }              
            }
            
            makeStatement(source, target);
        }
                                                      // target
        private void makeStatement(int customer_id, int number)
        {
            // math in within receiver
            for (int i = 1; i <= accountList.Count; i++)
            {
                Account temp_obj = (Account)accountList[i-1];

                if (temp_obj.number == number)
                {
                    temp_obj.balance += temp_am_move.Amount;

                    if (temp_am_move.IsCreddit) temp_obj.accountDebits.Add(temp_am_move.buildMOvementRecord()); 
                        else temp_obj.accountCredits.Add(temp_am_move.buildMOvementRecord());
                    

                    Console.WriteLine("Receiver ID------>" + temp_obj.number);
                    Console.WriteLine("Receiver balance------>" + temp_obj.balance);
                    // TODO: update logic one day
                    for (int p = 1; p <= temp_obj.accountCredits.Count; p++)
                    {
                        Console.WriteLine("Sender creditList------>" + temp_obj.accountCredits[p - 1].ToString());
                    }

                    for (int l = 1; l <= temp_obj.accountDebits.Count; l++)
                    {
                        Console.WriteLine("Sender debitList------>" + temp_obj.accountDebits[l - 1].ToString());
                    }
                    Console.WriteLine("<---------->");
                }            
            }
        }
    }
}

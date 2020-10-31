using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        

        int getBal()
        {
            return balance;
        }

        string getName()
        {
            return this.accName;
        }
        string getId()
        {
            return this.acid;
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }

        public bool withdraw(int amount)
        {
            bool chk = true;
            if (amount <=  balance)
            {
                balance -= amount;
            }
            else if (amount > balance)
            {
                chk = false;
            }
            return chk;
        }

        public int getBalAfter(int mos)
        {
            int prin = balance;
            return prin;
        }
    }
}

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
        string getName()
        {
            return this.acid;
        }
        public void Deposit(int amount)
        {
            balance += addAmt;
        }

        public bool withdraw(double outAmt)
        {
            bool chk = true;
            if (outAmt <= balance)
            {
                balance -= outAmt;
            }
            else if (outAmt > balance)
            {
                chk = false;
            }
            return chk;
        }

        public int getBalAfter(int mos)
        {
            double prin = balance;
            double intFeed;
            for (int g = 1; g <= mos; g++)
            {
                intFeed = prin * interest;
                prin += intFeed;
            }
            return prin;
        }
    }
}

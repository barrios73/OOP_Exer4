using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    public class Account
    {
        private string accountNumber;
        protected Customer accountHolderName;
        protected double balance;
        protected double withdrawAmt;

        //constructors
        public Account()
        {
            this.accountNumber = "00000";
            //when a default constructor contains initialising a class
            //we use the new className statement as seen below  
            this.accountHolderName = new Customer();
            this.balance = 0;
        }

        public Account(string AccountNumber, Customer AccountHolderName, double Balance) : this()
        {
            this.accountNumber = AccountNumber;
            this.accountHolderName = AccountHolderName;
            this.balance = Balance;
        }

        //methods
        public void Deposit(double DepositAmt)
        {
            balance = balance + DepositAmt;
        }

        public bool Withdraw(double tempWithdrawAmt)
        {
            WithdrawAmt = tempWithdrawAmt;
            balance = balance - withdrawAmt;

            if (withdrawAmt == 0)
            {
                Console.WriteLine("Withdrawal amount ${0} is more than balance. No withdrawal made", tempWithdrawAmt);
                return false;
            }
            else
                return true;
        }

        public void TransferTo(double TransferAmt, Account another)
        {
            if (another.Withdraw(TransferAmt) == true)
                Deposit(TransferAmt);
            else
                Console.WriteLine("Transfer unsuccessful");
        }
        
        public double Show()
        {
            return balance;
        }
      

        //property methods

        public double WithdrawAmt
        {
            get
            {
                return withdrawAmt;
            }

            set
            {
                if (value > balance)
                {
                    withdrawAmt = 0;
                }
                else
                    withdrawAmt = value;
            }
        }

    }

    
}





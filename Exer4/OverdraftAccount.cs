using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    class OverdraftAcct: Account
    {
        //attributes
        private static double interestRatePosBalance = 0.0025;
        private static double interestRateNegBalance = 0.06;
        private double interestAmt;

        //constructor
        public OverdraftAcct(string AccountNumber, Customer AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance)
        {
        }

        public new void Withdraw(double tempWithdrawAmt)
        {
            balance = balance - tempWithdrawAmt;
            
        }

        public new void TransferTo(double TransferAmt, Account another)
        {
            another.Withdraw(TransferAmt);
            Deposit(TransferAmt);
            
        }

        public void CalculateInterest()
        {
            if (balance <= 0)
                interestAmt = interestRateNegBalance * balance;
            else
                interestAmt = interestRatePosBalance * balance;
        }

        public void CreditInterest()
        {
            CalculateInterest();
            if (balance <= 0)
            {
                balance = balance + interestAmt;
                Console.WriteLine("Balance with interest deducted for overdraft account customer {0}: ${1}", accountHolderName.Name, balance);
            }
            else
            {
                balance = balance + interestAmt;
                Console.WriteLine("Balance with interest credited for overdraft account customer {0}: ${1}", accountHolderName.Name, balance);
            }

        }


    }
}

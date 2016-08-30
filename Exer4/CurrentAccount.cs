using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    class CurrentAcct: Account
    {
        //attributes
        private static double interestRate = 0.0025;
        private double interestAmt;

        //constructor
        public CurrentAcct(string AccountNumber, Customer AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance)
        {
        }


        //General methods
        public void CalculateInterest()
        {
            interestAmt = interestRate * balance;
        }

        public void CreditInterest()
        {
            CalculateInterest();
            balance = balance + interestAmt;
            Console.WriteLine("Balance with interest credited for current account customer {0}: ${1}", accountHolderName.Name, balance);
        }
    }
}

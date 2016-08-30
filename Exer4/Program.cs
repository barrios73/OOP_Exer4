using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer w = new Customer("Barrios", "20, Uruguay Road", "XXX5A", new DateTime(1999, 04, 11));
            Customer x = new Customer("Pujol", "17, Emilio Road", "XXX7G", new DateTime(1984, 11, 22));
            Customer v = new Customer("Tarrega", "17, Aranjuez Road", "XXXAA", new DateTime(1980, 03, 09));
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            Account a = new Account("001-001-001", y, 2000);
            Account b = new Account("001-001-002", z, 5000);
            SavingsAcct c = new SavingsAcct("001-001-003", w, 6000);
            CurrentAcct d = new CurrentAcct("001-001-004", x, 150000);
            OverdraftAcct e = new OverdraftAcct("001-001-005", v, 9000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            e.Withdraw(2000);
            Console.WriteLine(a.Show());
            Console.WriteLine(e.Show());
            a.TransferTo(99900, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            c.CreditInterest();
            e.CreditInterest();


        }
    }
}

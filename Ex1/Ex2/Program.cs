using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{

    class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new CompanyDepositAccount(4);

            acc1.Deposit(4000);
            acc1.Withdraw(270);
            Console.WriteLine(acc1.InterestByPeriod(2));

            var acc2 = new IndividualLoanAccount();
            acc2.Deposit(3000);
            //acc2.Withdraw(290);//error
            Console.WriteLine(acc2.InterestByPeriod(6));
        }
    }
}

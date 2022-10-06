using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herança.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts acc1 = new Accounts(1001, "Alex", 500.0);
            Accounts acc2 = new SavingsAccounts(1002, "Anna", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}

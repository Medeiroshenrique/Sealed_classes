using System;
using UpcastingAndDowncasting.Entities;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new BusinessAcount(1001,"John Lennox",500,1000.0);
            Account acc2 = new SavingsAccount(1002, "Alexandra", 500, 0.01);
            
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
   public class Account
    {
        public Account()
        {
            Console.WriteLine("Account class");
        }
        public virtual void AccountName()
        {
            Console.WriteLine("name of account");
        }
        public virtual void AccountDetails()
        {
            Console.WriteLine("Details information about account");
        }

    };
    class Customer : Account
    {
        public Customer()
        {
            Console.WriteLine("Customer class");
        }
        public override void AccountName()
        {
            Console.WriteLine("name of account");
        }
    }
}

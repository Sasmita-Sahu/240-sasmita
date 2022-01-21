using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CustomerContext())
            {
                List<Customer> customers = context.Customer.ToList();
                foreach(var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                }
            }
            
        }
    }
}

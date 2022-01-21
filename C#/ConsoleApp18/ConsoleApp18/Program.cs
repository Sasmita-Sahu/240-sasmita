using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {
                List<Customers> customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.CompanyName);
                        
                }

            }
        }
    }
}

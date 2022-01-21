using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace ConsoleApp16
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
                        Console.WriteLine(customers.CompanyName);
                            
                    }
                }
                
            }
        }
    
}
    
    




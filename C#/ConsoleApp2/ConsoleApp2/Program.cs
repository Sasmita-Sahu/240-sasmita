using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mona", "mita", "srikant" };
            UsingLinqExtensions(names);
        }
        private static void UsingLinqExtensions(string[] names)
        {
            IEnumerable<string> query = names
                                        .Where(s => s.Length == 5)
                                        .OrderBy(s => s)
                                        .Select(s => s.ToUpper());

            foreach (string item in query)
                Console.WriteLine(item);

            Console.Read();

        }
    }
}

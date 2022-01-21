using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mona", "mita", "srikant" };
            UsingLINQFunctions(names);

        }

        private static void UsingLINQFunctions(string[] names)
        {


            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> query = names
                                        .Where(filter)
                                        .OrderBy(extract)
                                        .Select(project);


            foreach (string item in query)
                Console.WriteLine(item);
            Console.Read();
        }
    }
}

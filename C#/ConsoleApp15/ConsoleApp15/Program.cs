using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "mona", "mita", "srikant", "ram", "shyam", "hari", "kunu", "sunu", "dolly", "debansh" };

            UsingLINQ(names);
        }
        private static void UsingLINQ(string[] names)
        {
            IEnumerable<string> query = from a in names
                                        where a.Length == 5
                                        orderby a
                                        select a.ToUpper();

            foreach (string item in query)
                Console.WriteLine(item);
            Console.Read();
                                        
        }
    }
}

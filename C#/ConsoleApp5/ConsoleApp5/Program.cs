using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("linq operation");
        }

        private static void LINGReadXML()
        {
            string myXML = @"<Departments>
                               <Departments>Account</Departments>
                                  <Departments>Sales</Departments>
                                <Departments>Marketinh</Departments>
                                  <Departments>Pre-Sales</Departments>
                                </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            var result = xdoc.Element("Departments").Descendants();
            foreach(XElement item in result)
            {
                Console.WriteLine("Department Name =" + item.Value);
            }
            Console.WriteLine("\n press any key to continue.");
            Console.ReadKey();

                                     
                
                
        }
    }
}

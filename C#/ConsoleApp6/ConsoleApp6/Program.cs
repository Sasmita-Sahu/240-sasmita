using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleApp6
{
    
        class Program
        {
            static void Main(string[] args)
            {
            string[] names = { "mita", "mona" };

            //  LINGReadXML();
            LINQtoXMLAddNode();
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
                foreach (XElement item in result)
                {
                    Console.WriteLine("Department Name =" + item.Value);
                }
                Console.WriteLine("\n press any key to continue.");
                Console.ReadKey();




            }
        public static void LINQtoXMLAddNode()
        {
            string myXML = @"<Departments>
                               <Departments>Account</Departments>
                                  <Departments>Sales</Departments>
                                <Departments>Marketinh</Departments>
                                  <Departments>Pre-Sales</Departments>
                                </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            //Add new Element
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));
            //Add newelement at first
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name =" + item.Value);
            }
            Console.WriteLine("\n press any key to continue.");
            Console.ReadKey();
        }
        }
    }



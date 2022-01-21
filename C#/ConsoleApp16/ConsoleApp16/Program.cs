using System;
using System.Configuration;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Xml;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp16
{
    class Program
    {
        private static object resultTextBox;

        [Obsolete]
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                //creating connection
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=NorthWind; integrated security=SSPI");
                //writing sql query
                SqlCommand cm = new SqlCommand("select * from Customers", con);
                //opening Connection
                con.Open();
                //executing sql query
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CompanyName"] + "" + sdr["Region"]);
                }
                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine("something is wrong" + e);
            }
        }
     }
}
    


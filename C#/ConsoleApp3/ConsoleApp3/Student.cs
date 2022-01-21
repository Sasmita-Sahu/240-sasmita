using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Student : IStudent
    {
        public string GetLocation()
        {
            return "india";
        }

       public string GetName()
        {
            return "mona";
        }
    }
}

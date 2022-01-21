using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
   public class Employee : Department
    {
        public string GetEmployeeFirstName()
        {
            return "Sasmita";
        }
        public string GetEmployeeLastName()
        {
            return "Sahu";
        }
        public override string GetDepartmentDetails()
        {
            return"Software";
        }
    };
}

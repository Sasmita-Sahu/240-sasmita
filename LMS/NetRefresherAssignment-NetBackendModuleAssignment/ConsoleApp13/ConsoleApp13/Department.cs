using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Department
    {
        public string GetDepartmentName()
        {
            return "IT Department";
        }
        public int GetNumberOfDepartments()
        {
            return 50 ;
        }
        public  virtual string GetDepartmentDetails()
        {
            return "Software";
        }
    }
}

using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            string employeeFirstName = emp1.GetEmployeeFirstName();
            string employeeLastName = emp1.GetEmployeeLastName();
            string departmentName = emp1.GetDepartmentName();
            int noofdepartments = emp1.GetNumberOfDepartments();
            string departmentDetails = emp1.GetDepartmentDetails();
            Console.WriteLine(employeeFirstName + " " + employeeLastName + " belongs to  " + departmentName + " contain  number of departments : " + noofdepartments + " has contain Product : " + departmentDetails);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class employee
    { 
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public employee(int empId, string empName, float salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }
    }
    public class ParttimeEmployee : employee
    {
        public float Wages { get; set; }
        public ParttimeEmployee(int empId, string empName, float salary, float wages)
            : base(empId, empName, salary)
        {
            Wages = wages;
        }
    }
    class Employee
    {
        static void Main(string[] args)
        {
            ParttimeEmployee partTimeEmp = new ParttimeEmployee(1, "eswar", 30000, 100);
            Console.WriteLine("Emp ID: " + partTimeEmp.EmpId + ", Name: " + partTimeEmp.EmpName + ", Salary: " + partTimeEmp.Salary + ", Wages: " + partTimeEmp.Wages);
            Console.Read();
        }
    }
}

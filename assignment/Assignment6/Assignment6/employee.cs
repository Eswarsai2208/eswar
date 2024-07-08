using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<employee> employees = new List<employee>
        {
            new employee { EmpId = 1, EmpName = "Eswar", EmpCity = "Bangalore", EmpSalary = 50000 },
            new employee { EmpId = 2, EmpName = "Sai", EmpCity = "Chennai", EmpSalary = 40000 },
            new employee { EmpId = 3, EmpName = "Ravi", EmpCity = "Bangalore", EmpSalary = 55000 },
            new employee { EmpId = 4, EmpName = "Teja", EmpCity = "Mumbai", EmpSalary = 48000 },
            new employee { EmpId = 5, EmpName = "Ritesh", EmpCity = "Bangalore", EmpSalary = 42000 }
        };
            Console.WriteLine("All Employees:");
            DisplayEmployees(employees);
            Console.WriteLine("\nEmployees with Salary Greater Than 45000:");
            DisplayEmployees(employees.Where(e => e.EmpSalary > 45000).ToList());
            Console.WriteLine("\nEmployees Belonging to Bangalore:");
            DisplayEmployees(employees.Where(e => e.EmpCity.Equals("Bangalore", StringComparison.OrdinalIgnoreCase)).ToList());
            Console.WriteLine("\nEmployees Sorted by Name (Ascending):");
            DisplayEmployees(employees.OrderBy(e => e.EmpName).ToList());
        }
        static void DisplayEmployees(List<employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }

}


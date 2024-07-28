using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_assignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class program

    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            var empjoinedBefore2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1)).ToList();
            Console.WriteLine("Employees who joined before 1/1/2015:");
            foreach (var e in empjoinedBefore2015)
            {
                Console.WriteLine($"{e.EmployeeID} {e.FirstName} {e.LastName} {e.DOJ.ToShortDateString()} {e.City}");
            }
            Console.Write("-----------------------------------------------------------------------------------");
           
            var dobAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1)).ToList();
            Console.WriteLine("\nEmployees with DOB after 1/1/1990:");
            foreach (var e in dobAfter1990)
            {
                Console.WriteLine($"{e.EmployeeID} {e.FirstName} {e.LastName} {e.DOB.ToShortDateString()} {e.City}");
            }
            Console.Write("-----------------------------------------------------------------------------------");

            var consultantAndAssociate = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate").ToList();
            Console.WriteLine("\nEmployees with designation Consultant or Associate:");
            foreach (var e in consultantAndAssociate)
            {
                Console.WriteLine($"{e.EmployeeID} {e.FirstName} {e.LastName} {e.DOJ.ToShortDateString()} {e.City}");
            }
            Console.Write("-----------------------------------------------------------------------------------");
 
            int totalEmployees = empList.Count;
            Console.WriteLine($"\nTotal number of employees: {totalEmployees}");
           
            int totalChennaiEmployees = empList.Count(e => e.City == "Chennai");
            Console.WriteLine($"Total number of employees in Chennai: {totalChennaiEmployees}");
            
            int highestEmployeeID = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");
           
            int totalJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Total number of employees who joined after 1/1/2015: {totalJoinedAfter2015}");
                      
            int totalNotAssociate = empList.Count(e => e.Title != "Associate");
            Console.WriteLine($"Total number of employees whose designation is not Associate: {totalNotAssociate}");
            Console.Write("-----------------------------------------------------------------------------------");
  
            var employeesByCity = empList.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() }).ToList();
            Console.WriteLine("\nTotal number of employees based on City:");
            foreach (var g in employeesByCity)
            {
                Console.WriteLine($"{g.City}: {g.Count}");
            }
            Console.Write("-----------------------------------------------------------------------------------");
 
            var employeesByCityAndTitle = empList.GroupBy(e => new { e.City, e.Title }).Select(g => new { g.Key.City, g.Key.Title, Count = g.Count() }).ToList();
            Console.WriteLine("\nTotal number of employees based on City and Title:");
            foreach (var g in employeesByCityAndTitle)
            {
                Console.WriteLine($"{g.City} - {g.Title}: {g.Count}");
            }
            Console.Write("-----------------------------------------------------------------------------------");

            DateTime youngestDOB = empList.Max(e => e.DOB);
            var youngestEmployees = empList.Where(e => e.DOB == youngestDOB).ToList();
            Console.WriteLine("\nYoungest employees:");
            foreach (var e in youngestEmployees)
            {
                Console.WriteLine($"{e.EmployeeID} {e.FirstName} {e.LastName} {e.DOB.ToShortDateString()} {e.City}");
              
            }
            Console.ReadLine();
        }
    }
}

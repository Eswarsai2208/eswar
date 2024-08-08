using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    public static class Admin
    {
        public static void AddNewTrain()
        {
            Console.Write("Enter Train No: ");
            string trainNo = Console.ReadLine();

            Console.Write("Enter Train Name: ");
            string trainName = Console.ReadLine();

            Console.Write("Enter From Station: ");
            string fromStation = Console.ReadLine();

            Console.Write("Enter To Station: ");
            string toStation = Console.ReadLine();

            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Price per Seat: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Status: ");
            string status = Console.ReadLine();

            Console.Write("Enter Number of Seats: ");
            int noOfSeats = int.Parse(Console.ReadLine());

            Console.Write("Enter Classes: ");
            string classes = Console.ReadLine();

            Train.AddTrain(trainNo, trainName, fromStation, toStation, date, price, status, noOfSeats, classes);
        }

        public static void UpdateTrain()
        {
            Console.Write("Enter Train ID to update: ");
            int trainID = int.Parse(Console.ReadLine());

            Console.Write("Enter Train No: ");
            string trainNo = Console.ReadLine();

            Console.Write("Enter Train Name: ");
            string trainName = Console.ReadLine();

            Console.Write("Enter From Station: ");
            string fromStation = Console.ReadLine();

            Console.Write("Enter To Station: ");
            string toStation = Console.ReadLine();

            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Price per Seat: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Status: ");
            string status = Console.ReadLine();

            Console.Write("Enter Number of Seats: ");
            int noOfSeats = int.Parse(Console.ReadLine());

            Console.Write("Enter Classes: ");
            string classes = Console.ReadLine();

            Train.UpdateTrain(trainID, trainNo, trainName, fromStation, toStation, date, price, status, noOfSeats, classes);
        }
    }
}

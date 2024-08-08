﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Railway Reservation System");

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            int userID = Train.GetUserID(username, password);
            string userRole = userID == 0 ? "Guest" : GetUserRole(userID);

            if (userRole == "Guest")
            {
                Console.WriteLine("Invalid credentials.");
                return;
            }

            Console.WriteLine($"Logged in as {userRole}");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. List All Trains");
                Console.WriteLine("2. Add Train");
                Console.WriteLine("3. Update Train");
                Console.WriteLine("4. Book Tickets");
                Console.WriteLine("5. Cancel Tickets");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Train.ListTrain();
                        break;

                    case 2:
                        if (userRole == "Admin")
                        {
                            Admin.AddNewTrain();
                        }
                        else
                        {
                            Console.WriteLine("Access denied. Admins only.");
                        }
                        break;

                    case 3:
                        if (userRole == "Admin")
                        {
                            Admin.UpdateTrain();
                        }
                        else
                        {
                            Console.WriteLine("Access denied. Admins only.");
                        }
                        break;

                    case 4:
                        if (userRole == "User")
                        {
                            Users.BookTickets();
                        }
                        else
                        {
                            Console.WriteLine("Access denied. Users only.");
                        }
                        break;

                    case 5:
                        if (userRole == "User")
                        {
                            Users.CancelTickets();
                        }
                        else
                        {
                            Console.WriteLine("Access denied. Users only.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static string GetUserRole(int userID)
        {
            using (var conn = Train.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT UserRole FROM [User] WHERE UserID = @UserID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    return cmd.ExecuteScalar()?.ToString() ?? "Guest";
                }
            }
        }
    }
}

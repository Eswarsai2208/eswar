using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6;

namespace TicketBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                TicketBooking ticketBooking = new TicketBooking();
                ticketBooking.CalculateConcession(age);

                Console.ReadLine();
            }
        }
    }
}

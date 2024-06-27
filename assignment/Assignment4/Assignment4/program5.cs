using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Doctor
    {
        private int RegnNo;
        private string Name;
        private decimal Feescharged;
        public int RegistrationNumber
        {
            get { return RegnNo; }
            set { RegnNo = value; }
        }
        public string DoctorName
        {
            get { return Name; }
            set { Name = value; }
        }
        public decimal FeesCharged
        {
            get { return Feescharged; }
            set { Feescharged = value; }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Doctor Name: {Name}");
            Console.WriteLine($"Fees Charged: {Feescharged:C}");
            Console.Read();
        }
    }

    class Program5
    {
        static void Main()
        {
            Doctor doctor1 = new Doctor();
            doctor1.RegistrationNumber = 3322566;
            doctor1.DoctorName = "Dr. Gopal";
            doctor1.FeesCharged = 420;
            Console.WriteLine("Doctor Details:");
            doctor1.DisplayDetails();
        }
    }

}

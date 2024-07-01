﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Dayscholar(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Dayscholar Details - "+StudentId+", Name: "+Name);
            Console.ReadLine();
        }
    }
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Resident(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Resident Details - "+StudentId+", Name: "+Name);
            Console.ReadLine();
        }
    }
    class student
    {
        public static void Main()
        {
            IStudent dayscholar = new Dayscholar ( 1, "eswar");
            IStudent resident = new Resident (2, "sai" );
            dayscholar.ShowDetails();
            resident.ShowDetails();
        }
    }

}

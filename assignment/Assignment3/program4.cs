using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{

public class Customer
{
    private int CustomerId;
    private string Name;
    private int Age;
    private string Phone;
    private string City;
    public Customer()
    {
        CustomerId = 0;
        Name = "Not provided";
        Age = 0;
        Phone = "Not provided";
        City = "Not provided";
    }
    public Customer(int id, string name, int age, string phone, string city)
    {
        CustomerId = id;
        Name = name;
        Age = age;
        Phone = phone;
        City = city;
    }
    public static void DisplayCustomer()
    {
        Console.WriteLine("\nCustomer Details:");
        Console.WriteLine($"Customer ID: {CustomerId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"City: {City}");
    }
    ~Customer()
    {
        Console.WriteLine($"Destructor called for customer {Name}");
    }
}

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(1001, "John Doe", 30, "123-456-7890", "New York");
        Customer.DisplayCustomer();
        Customer.DisplayCustomer();
    }
}


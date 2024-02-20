﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer 
            { 
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                City = "Ankara"
            };
            Customer customer2 = new Customer(1,"Derin","Demiroğ","Ankara");
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}

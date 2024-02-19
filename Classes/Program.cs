﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            

            Customer customer = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Murat",
                LastName = "Büyük"
            };

            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }
}

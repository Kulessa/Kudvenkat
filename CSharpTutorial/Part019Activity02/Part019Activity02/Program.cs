﻿using System;

namespace Part019Activity02
{
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer();
            C1.PrintFullName();
        }
    }
    class Customer
    {
        string firstName;
        string lastName;

        //public Customer(string firstName, string lastName)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //}
        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this.firstName + " " + this.lastName);
        }
        ~Customer()
        {
            //Clean up code
        }

    }
}

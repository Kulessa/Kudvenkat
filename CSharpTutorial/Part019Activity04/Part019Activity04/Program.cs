using System;

namespace Part019Activity04
{
    class Program
    {
        static void Main()
        {
            Customer C1 = new Customer();
            C1.PrintFullName();

            Customer C2 = new Customer("P", "T");
            C1.PrintFullName();
        }

        class Customer
        {
            string firstName;
            string lastName;

            public Customer() : this("No FirstName Provided", "No LastName Provided")
            {
            }

            public Customer(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

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
}

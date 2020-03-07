using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part021Activity03
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Pragim";
            FTE.LastName = "Tech";
            FTE.YearlySalary = 50000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Part";
            PTE.LastName = "time";
            PTE.PrintFullName();

            A a = new A();
            a.HourlyRate = 1;
            a.MyProperty = 2;
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary { get; set; }
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }
    }
    public class A: PartTimeEmployee
    {
        public int MyProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part025Activity01
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1, 2, 3);
            Add(1, 2, 3, 4);
        }
        public static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber + thirdNumber);
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber + thirdNumber + fourthNumber);
        }
    }
}

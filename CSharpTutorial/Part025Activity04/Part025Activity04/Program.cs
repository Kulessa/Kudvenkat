using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part025Activity04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber + thirdNumber);
        }
        public static int Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber + thirdNumber);
            return firstNumber + secondNumber + thirdNumber;
        }
    }
}

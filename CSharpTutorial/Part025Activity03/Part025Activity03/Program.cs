using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part025Activity03
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2, 3);
            int x;
            Add(1, 2, out x);
            Console.WriteLine("Out - Sum = {0}", x);
        }
        public static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber + thirdNumber);
        }
        public static void Add(int firstNumber, int secondNumber, out int sum)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
            sum = firstNumber + secondNumber;
        }
    }
}

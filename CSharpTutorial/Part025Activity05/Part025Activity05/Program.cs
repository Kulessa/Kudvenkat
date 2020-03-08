using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part025Activity05
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void Add(int firstNumber, int secondNumber, params int[] thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber );
        }
        public static void Add(int firstNumber, int secondNumber, int[] thirdNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber );
        }
    }
}

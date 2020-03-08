using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part025Activity02
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1F, 2F);
            Add(1, 2F);
        }
        public static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }
        public static void Add(float firstNumber, float secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }
        public static void Add(int firstNumber, float secondNumber)
        {
            Console.WriteLine("Sum = {0}", firstNumber + secondNumber);
        }
    }
}

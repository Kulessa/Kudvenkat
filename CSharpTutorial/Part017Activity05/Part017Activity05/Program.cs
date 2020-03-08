using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part017Activity05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, product;
            Calculate(1, 2, out sum, out product);
            Console.WriteLine("Sum = {0} - Product = {1}", sum, product);
        }
        public static void Calculate(int firstNumber, int secondNumber, out int sum, out int product)
        {
            sum = firstNumber + secondNumber;
            product = firstNumber * secondNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part017Activity04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Calculate(1, 2);
            Console.WriteLine(sum);
        }
        public static int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}

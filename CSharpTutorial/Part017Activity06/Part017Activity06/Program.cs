using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part017Activity06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;

            //Method();
            Method(numbers);
            //Method(1, 2, 3, 4, 5);

            ParamsMethod();
            ParamsMethod(numbers);
            ParamsMethod(1, 2, 3, 4, 5);
        }
        public static void Method(int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============================");
        }
        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============================");
        }
        public static void ParamsMethodX(int x, params int[] numbers)
        {
            Console.WriteLine("There are {0} elements", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============================");
        }
        //public static void ParamsMethodXX(params int[] numbers,int x)
        //{
        //    Console.WriteLine("There are {0} elements", numbers.Length);
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("=============================");
        //}


        //public static void ParamsMethodXXX(params int[] numbers, params string[] name)
        //{
        //    Console.WriteLine("There are {0} elements", numbers.Length);
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("=============================");
        //}
    }
}

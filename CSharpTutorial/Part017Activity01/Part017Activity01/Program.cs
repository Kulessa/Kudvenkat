﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part017Activity01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Program.SimpleMethod(i);
            Console.WriteLine(i);
        }
        public static void SimpleMethod(int j)
        {
            j = 101;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part017Activity03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            SimpleMethod(ref i);
            Console.WriteLine(i);
        }
        public static void SimpleMethod(ref int j)
        {
            j = 101;
        }
    }
}

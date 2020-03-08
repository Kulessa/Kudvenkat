using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part024Activity02
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();
            b.Print();
        }
    }
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part021Activity05
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
        }
    }
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass constructor called");
        }
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("ChildClass constructor called");
        }
    }
}

﻿using System;

namespace Part020Activity03
{
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            float area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", area1);
            
            //C1.Print();
            Circle.Print();

            Circle C2 = new Circle(6);
            float area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", area2);
        }
    }
    class Circle
    {
        static float pi = 3.141F;
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public float CalculateArea()
        {
            return Circle.pi * this.radius * this.radius;
        }
        public static void Print()
        {
            //
        }
    }

}

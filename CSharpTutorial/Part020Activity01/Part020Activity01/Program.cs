using System;

namespace Part020Activity01
{
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            float area = C1.CalculateArea();
            Console.WriteLine("Area = {0}", area);
        }
    }
    class Circle
    {
        float pi = 3.141F;
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public float CalculateArea()
        {
            return this.pi * this.radius * this.radius;
        }
    }
}

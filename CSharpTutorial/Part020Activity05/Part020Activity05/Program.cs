using System;

namespace Part020Activity05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Circle.pi);
        }
    }
    class Circle
    {
        public static float pi;
        int radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle.pi = 3.141F;
        }

        public Circle(int radius)
        {
            Console.WriteLine("Instace Constructor Called");
            this.radius = radius;
        }
        public float CalculateArea()
        {
            return Circle.pi * this.radius * this.radius;
        }
    }
}

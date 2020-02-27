using System;

namespace Part020Activity04
{
    class Program
    {
        static void Main()
        {
            Circle C1 = new Circle(5);
            float area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", area1);

            Circle C2 = new Circle(6);
            float area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", area2);
        }
    }
    class Circle
    {
        //3
        // /*1*/static float pi = 3.141F;
        static float pi;
        int radius;

        //3
        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle.pi = 3.141F;
        }
        
        //2
        //Circle(int radius)
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

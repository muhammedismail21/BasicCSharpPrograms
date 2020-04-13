using System;
namespace OOPs
{
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            Geometry.Area(200);
            Geometry.Area(100, 150);
            Geometry.Area(1.23);

            Console.ReadLine();
        }
    }

    class Geometry
    {
        /*
         * what is a static method?
         * - a static method is called without creating an object of that class
         * - a static method can be called with the class name
         */
        public static void Area(int side)
        {
            int areaOfSquare = side * side;
            Console.WriteLine("Area of square: " + areaOfSquare );
        }
        public static void Area(int length, int breadth)
        {
            int areaOfRectangle = length * breadth;
            Console.WriteLine("Area of Rectangle: " + areaOfRectangle);
        }
        public static void Area(double radius)
        {
            double areaOfCircle = radius * radius * Math.PI;
            Console.WriteLine("Area of Circle: " + areaOfCircle);
        }
    }
}

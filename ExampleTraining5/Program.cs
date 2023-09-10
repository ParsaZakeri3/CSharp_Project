using System;

namespace ExampleTraining5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter radius :");
            double radius = double.Parse(Console.ReadLine());  // شعاع دایره

            double perimeter = CalculateCirclePerimeter(radius);

            Console.WriteLine("perimeter : " + perimeter);
        }

        static double CalculateCirclePerimeter(double radius)
        {
            // محاسبه محیط دایره با فرمول 2 * π * شعاع
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }
}

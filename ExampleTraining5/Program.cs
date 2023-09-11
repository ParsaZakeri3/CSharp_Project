using System;

namespace ExampleTraining5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("inter radius :");
                    double radius = double.Parse(Console.ReadLine());  // شعاع دایره

                    Console.WriteLine("perimeter : " + CalculateCirclePerimeter(radius));
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        static double CalculateCirclePerimeter(double radius)
        {
            // محاسبه محیط دایره با فرمول 2 * π * شعاع
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }
}

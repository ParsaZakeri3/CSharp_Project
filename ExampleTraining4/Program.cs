using System;

namespace ExampleTraining4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("inter length :");
                    double length = double.Parse(Console.ReadLine());  // طول مستطیل
                    Console.WriteLine("inter width :");
                    double width = double.Parse(Console.ReadLine());   // عرض مستطیل

                    Console.WriteLine("area : " + CalculateRectangleArea(length, width));
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        static double CalculateRectangleArea(double length, double width)
        {
            // محاسبه مساحت مستطیل با ضرب طول و عرض
            double area = length * width;
            return area;
        }
    }
}

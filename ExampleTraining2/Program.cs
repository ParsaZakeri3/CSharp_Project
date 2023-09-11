using System;
using ExampleTraining2.Class;

namespace ExampleTraining2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the number :");
                    string Number = Console.ReadLine();
                    Console.WriteLine(Validation.ValiadNumber(Number));
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}

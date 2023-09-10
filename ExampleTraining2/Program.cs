using System;
using ExampleTraining2.Class;

namespace ExampleTraining2
{
    class Program
    {
        public static string Code;
        public static bool num_ = false;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the number :");
                string Number = Console.ReadLine();
                Code = Validation.ValiadNumber(Number);
                Console.WriteLine(Code);
            }
        }
    }
}

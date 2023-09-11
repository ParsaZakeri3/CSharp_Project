using System;

namespace ExampleTraining3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Wellcom!");
                    Console.WriteLine("FirstName :");
                    string Fname = Console.ReadLine();
                    Console.WriteLine("LastName :");
                    string Lname = Console.ReadLine();
                    Console.WriteLine(valid(Fname, Lname));
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private static string valid(string Fname , string Lname)
        {
            string FLname = Fname + " " + Lname;
            return FLname;
        }
    }
}

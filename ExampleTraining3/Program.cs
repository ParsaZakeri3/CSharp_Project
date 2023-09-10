using System;

namespace ExampleTraining3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcom!");
            Console.WriteLine("FirstName :");
            string Fname = Console.ReadLine();
            Console.WriteLine("LastName :");
            string Lname = Console.ReadLine();
            string FLname = valid(Fname, Lname);
            Console.WriteLine(FLname);
        }

        private static string valid(string Fname , string Lname)
        {
            string FLname = Fname + " " + Lname;
            return FLname;
        }
    }
}

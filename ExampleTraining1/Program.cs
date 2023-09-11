using System;

namespace ExampleTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("inter your number :");
                    string numm = Console.ReadLine();
                    //1-
                    //numm = int.TryParse(numm, out int num) && num % 2 == 0 ? "ok zoje" : "ok fard";
                    //Console.WriteLine(numm);
                    //2-
                    Console.WriteLine(Getnuminjf(numm));
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private static string Getnuminjf(string nuum)
        {
            string jf = int.TryParse(nuum, out int num) && num % 2 == 0 ? "ok zoje" : "ok fard";
            return jf;
        }
    }
}

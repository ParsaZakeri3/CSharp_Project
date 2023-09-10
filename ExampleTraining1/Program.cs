using System;

namespace ExampleTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter your number :");
            string numm = Console.ReadLine();
            //1-
            /*string jf = int.TryParse(numm, out int num) && num % 2 == 0 ? "ok zoje" : "ok fard";
            Console.WriteLine(jf);*/
            //2-
            string getvalue = Getnuminjf(numm);
            Console.WriteLine(getvalue);
        }

        private static string Getnuminjf(string nuum)
        {
            string jf = int.TryParse(nuum, out int num) && num % 2 == 0 ? "ok zoje" : "ok fard";
            return jf;
        }
    }
}

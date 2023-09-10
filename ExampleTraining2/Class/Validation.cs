using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTraining2.Class
{
    class Validation
    {
        public static string ValiadNumber(string numr)
        {
            if (int.TryParse(numr, out int num) && num % 5 == 0)
            {
                string a = $"The entered value {numr} is divisible by 5 thank you ,true";
                string b = Valiad(a);
                return b;
            }
            else
            {
                string a = $"The entered value {numr} is not divisible by 5 Enter the number again ,false";
                string b = Valiad(a);
                return b;
            }
        }
        public static string Valiad(string numr)
        {
            string[] a = numr.Split(",");
            if (a[1] == "true")
            {
                string b = Writemasseage(numr ,true);
                return b;
            }
            else if (a[1] == "false")
            {
                string b = Writemasseage(numr, false);
                return b;
            }
            else
            {
                string b = Writemasseage(numr, false);
                return b;
            }
        }
        public static string Writemasseage(string numr,bool trfa)
        {
            if(trfa == true)
            {
                string[] writ = numr.Split(",");
                return writ[0];
            }
            else if(trfa == false)
            {
                string[] writ = numr.Split(",");
                return writ[0];
            }
            else
            {
                return "Erorr";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTraining2.Class
{
    class Validation
    {
        public static string ValiadNumber(string numr)
        {
            string a = int.TryParse(numr, out int num) && num % 5 == 0 ? $"The entered value {numr} is divisible by 5 thank you ,true" : $"The entered value {numr} is not divisible by 5 Enter the number again ,false";
            string[] b = a.Split(",");
            string writ = b[1] == "true" || b[1] == "false" ? b[0] : b[0];
            return writ;
        }
    }
}

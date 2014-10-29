using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProj
{
    public class FizzBuzz
    {


        public string Decode(int num)
        {  
            if (IsFizzBuzz(num))
                return "FizzBuzz";
            if (IsFizz(num))
              return "Fizz";
            if (IsBuzz(num))
                return "Buzz";

            return num.ToString();
        }

        private bool IsBuzz(int num)
        {
            return num % 5 == 0;
        }

        private bool IsFizzBuzz(int num)
        {
            return num % 15 == 0;
        }

        private bool IsFizz(int num)
        {
            return num % 3 == 0;
        }
        
        public string Print(int min, int max)
        {
            //string result = "";
            StringBuilder result = new StringBuilder();
            for (int i = min; i <= max; ++i)
            {
                result.Append(Decode(i));
                result.Append(',');
            }
            return result.ToString().Remove(result.Length - 1);
        }


    }
}

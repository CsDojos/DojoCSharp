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
            if (num == 3 )
              return "Fizz";
            if (num == 5)
                return "Buzz";
            if (num == 15)
                return "FizzBuzz";

            return num.ToString();
        }

        public string[] Print()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ita_chsharp_training
{
    public class FizzBuzzMain
    {
        //This is parameterless constructor
        public FizzBuzzMain()
        {
           

        }
        public string ExecuteFizzBuzz(int x)
        {
            var y = x % 3;
            var z = x % 5;

            if ((y == 0 && z == 0) == true)
            {
                Console.WriteLine("FizzBuzz!");
                
                return Convert.ToString(x);

            }

            else if (y == 0)
            {
                Console.WriteLine("Fizz!");
                return Convert.ToString(x);

            }
            //////
            else if (z == 0)
            {
                Console.WriteLine("Buzz");
                return Convert.ToString(x);

            }
            //////

            else
                return Convert.ToString(x);
            Console.ReadKey();
        }
    }
}

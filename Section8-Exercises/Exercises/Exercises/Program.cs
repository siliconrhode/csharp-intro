using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter numbers separated by '-' ");
            var userInput = Console.ReadLine();

            var inputArray = userInput.Split('-');
            var firstNumber = Convert.ToInt32(inputArray[0]);
            var descending = true;
            for (var i = 0; i < inputArray.Length - 1; i++)
            {

                if (!(Convert.ToInt32(inputArray[i + 1]) < Convert.ToInt32(inputArray[i])))
                {
                    descending = false;
                    break;
                }

            }
            var ascending = true;
            for (var i = 0; i < inputArray.Length-1; i++)
            {

                if (!( Convert.ToInt32(inputArray[i + 1]) > Convert.ToInt32(inputArray[i])))
                {
                    ascending = false;
                    break;
                }

            }

            if (ascending || descending)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}

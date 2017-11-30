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
            //CountNumDivisibleBy3();
            //OkOrExit();
            Factorial();
        }

        public static void CountNumDivisibleBy3()
        {
            var totalNumbersDivisable = 0;
            for (int i = 2; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    totalNumbersDivisable++;
                }
            }
            Console.WriteLine("Total numbers divisble by 3 between 1 and 100 is: " + totalNumbersDivisable);
        }

        public static void OkOrExit()
        {
            var sum = 0;
            
            {
                while (true)
                {
                    Console.WriteLine("Please enter a number or Ok to exit");
                    var userInput = Console.ReadLine();
                    if (userInput == "Ok")
                    {
                        break;
                    }
                    else
                    {
                        var userInputToInt = Convert.ToInt32(userInput);
                        sum += userInputToInt;
                    }
                }
                        Console.WriteLine("The sum of the numbers you have entered is : " + sum);
            }
        }

        public static void Factorial()
        {
            Console.WriteLine("Please enter a number to calculate it's factorial");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var factorial = userInput;
            var answer = 1;
            while (factorial > 1)
            {
                answer *= factorial;
                factorial--;
            }
            Console.WriteLine("{0}! = {1}",userInput,answer);
        }

    }
}

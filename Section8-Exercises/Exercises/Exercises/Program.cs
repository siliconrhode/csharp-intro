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
            Console.WriteLine(Duplicate());
        }

        static string AscendingOrDescending()
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
            for (var i = 0; i < inputArray.Length - 1; i++)
            {

                if (!(Convert.ToInt32(inputArray[i + 1]) > Convert.ToInt32(inputArray[i])))
                {
                    ascending = false;
                    break;
                }

            }

            if (ascending || descending)
            {
                return "Ascending";
            }
            else
            {
                return "Descending";
            }

        }

        public static string Duplicate()
        {
            Console.WriteLine("Please enter numbers separated by a hyphen");
            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Ext");
            }
            var numbers = new List<int>();
            foreach (var number in userInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    return "Duplicate";
                }
            }
            return "Non Duplicate";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //AscendigOrDescending();
            //Duplicate();
            ValidateTime();

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

        public static void  Duplicate()
        {
            Console.WriteLine("Please enter numbers separated by a hyphen");
            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                return;
                
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
                    Console.WriteLine("Duplicate");
                    ;
                }
            }
            Console.WriteLine("Non Duplicate");
        }

        public static void ValidateTime()
        {

            Console.WriteLine("Please enter time vale ing the 24-hour time format (e.g. 19:00)");
            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            var userInputArray = userInput.Split(':');
            if (userInputArray.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            try
            {
                var userInputList = new List<int>();
                foreach (var str in userInputArray)
                {
                    userInputList.Add(Convert.ToByte(str));
                }
                if (userInputList[0] >= 00 && userInputList[0] <= 23)
                {
                    if (userInputList[1] >= 00 && userInputList[1] <= 59)
                    {
                        Console.WriteLine("Ok");
                        return;

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }






        }


    }
}

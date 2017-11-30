
using System;

namespace iterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Hardy";
            //Display letter by letter in a string using for loop
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //..... using a foreach loop
            foreach (var letter in name)
            {
                Console.WriteLine(letter);
            }
            //.......using 

        }

    }

}

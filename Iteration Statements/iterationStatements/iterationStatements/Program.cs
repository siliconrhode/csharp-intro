
using System;

namespace iterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[3] {1, 2, 3};
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }

    }

}

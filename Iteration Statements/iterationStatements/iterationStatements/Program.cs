
using System;

namespace iterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print even numbers from 1 to 10;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Print even numbers from 10 to 1;
            for (int i = 10; i >= 1; i--)
            {   if (i%2 == 0)
                Console.WriteLine(i);
            }
                
        }

    }

}

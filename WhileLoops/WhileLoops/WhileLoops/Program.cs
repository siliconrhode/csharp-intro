using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a while loop that prints even numbers from 1 to 10
            int i = 0;
            while (i < 10)
            {
                if (i%2 == 0)
                {
                Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}

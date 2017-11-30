using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(((char)random.Next(97,122)));
            }
                Console.WriteLine();


        }
    }
}

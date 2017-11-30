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
                Console.Write(((char)( 'a' + random.Next(0,26))));
            }
                Console.WriteLine();


        }
    }
}

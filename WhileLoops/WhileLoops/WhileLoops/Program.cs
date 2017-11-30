using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the "continue"
            while (true)
            {
                Console.WriteLine("Please enter your name");
                var name = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("@Echo: " + name);
                    continue;
                }

                break;
            }
        }
    }
}


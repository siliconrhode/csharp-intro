using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            OneToTen();
        }

        public static void OneToTen()
        {
            Console.WriteLine("Please enter a number you can represt using your hands");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput >= 1 && userinput <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

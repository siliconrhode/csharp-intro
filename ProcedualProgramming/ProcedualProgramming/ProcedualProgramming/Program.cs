using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedualProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name to reverse");
            var name = Console.ReadLine();
            Console.WriteLine("Reversed Name : " + ReverseName(name));
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return new string(array);
        }
    }
}

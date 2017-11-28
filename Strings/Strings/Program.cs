

using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array 
            var numbers = new int[3] {1, 2.3};
            // join the aray elements 
            string list = string.Join(",", numbers);

        }
    }
}

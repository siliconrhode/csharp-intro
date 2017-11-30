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
            // declare an instance of random
            var random = new System.Random();
            // declare a ten elements array of type character
            var passwordLength = 10;
            var buffer = new char[passwordLength];
            // store a random character in each element
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + (random.Next(0, 26)));
            }
            // new string (arrayOfCharacters);
                var password = new string(buffer); 
                Console.WriteLine(password);


        }
    }
}

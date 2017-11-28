

using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "John";
            var lastName = "Hardy";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            var myFullName = string.Format("{0} {1}",firstName,lastName);
            Console.WriteLine(myFullName);
            var names = new string[3] {"Sam", "Dam", "Ham"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

           





        }
    }
}

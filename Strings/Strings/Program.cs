

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

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            





        }
    }
}

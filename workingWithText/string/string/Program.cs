using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "John Heartman ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            // to prove strings are immutable
            Console.WriteLine(fullName+'|');
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Trim().Substring(index+1);
            Console.WriteLine("firstName: '{0}'",firstName);
            Console.WriteLine("lastName: '{0}'",lastName);

            // produce an array of names
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: "+ names[0] );
            Console.WriteLine("Second Name: "+ names[1] );


        }
    }
}

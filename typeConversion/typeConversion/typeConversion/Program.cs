
using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "1234";
            // this will cause System.OverflowException
            byte b = Convert.ToByte(number);
            Console.WriteLine(b);

        }
    }
}

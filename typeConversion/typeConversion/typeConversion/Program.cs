
using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                var number = "1234";
                // this will cause System.OverflowException
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
                
            {
                Console.WriteLine("the number couldn't be   converted to a byte");
            }

        }
    }
}

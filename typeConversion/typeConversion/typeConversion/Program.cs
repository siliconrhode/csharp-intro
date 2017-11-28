
using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
            }
            catch (Exception)
            {
                Console.WriteLine(b);
            }

        }
    }
}

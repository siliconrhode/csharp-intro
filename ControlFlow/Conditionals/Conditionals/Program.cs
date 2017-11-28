

using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("50% off");
                    break;

                default:
                    Console.WriteLine("Everything else sucks");
                    break;
            }
        }
    }
}

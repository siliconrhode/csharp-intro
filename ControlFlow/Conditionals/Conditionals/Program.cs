

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
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;

                default:
                    Console.WriteLine("Everything else sucks");
                    break;
            }
        }
    }
}

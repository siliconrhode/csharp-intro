

using System;
using System.IO;

namespace WorkingWithFiles_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLocation = (@"C:\Users\Widows Pc\Documents\NoRuleModels.txt");
            var content = File.ReadAllText(fileLocation);
            Console.WriteLine(CountWords(content));
        }

        public static int CountWords(string text)
        {
            var wordCount = 0;
            foreach (var word in text)
            {
                wordCount++;
            }
            return wordCount;
        }

    }
}

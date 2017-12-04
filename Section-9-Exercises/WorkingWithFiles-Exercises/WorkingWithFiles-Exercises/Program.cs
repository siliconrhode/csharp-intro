

using System;
using System.Collections.Generic;
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
            Console.WriteLine(ShowLongestWord(content));
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

        public static string ShowLongestWord(string content)
        {
            var wordList = new List<string>();
            var longestWord = "";
            var length = 0;
            foreach(var word in content.Split(' '))
            {
                if (word.Length > length)
                {
                    longestWord = word;
                    length = word.Length;
                }
            }
            return longestWord;
        }

    }
}

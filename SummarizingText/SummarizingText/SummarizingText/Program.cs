

using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = " This is going to be a very very very really really long text.";
            var summary = SummerizeText(sentence, 25);
            Console.WriteLine(summary);

        }

        static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            
            
            var words = text.Split(' ');
            var totalLength = 0;
            var summaryList = new List<string>();
            foreach (var word in words)
            {

                summaryList.Add(word);
                totalLength += word.Length;
                if (totalLength > maxLength)
                {
                    break;
                }
            }
            
            return String.Join(" ", summaryList) + "...";

            

        }
    }
}

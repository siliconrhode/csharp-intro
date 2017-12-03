

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
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

        }

    }
}

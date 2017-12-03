using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
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

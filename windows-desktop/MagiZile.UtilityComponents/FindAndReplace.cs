using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UtilityComponents
{
    public static class FindAndReplace
    {
        public static List<int> Find(string text, string word, bool matchCase, bool wholeWordsOnly)
        {
            string usedText = text.ToLower();
            string usedWord = word.ToLower();
            if (matchCase)
            {
                usedText = text;
                usedWord = word;
            }
            List<int> positions = new List<int>();
            for (int i = 0; i < usedText.Length - word.Length - 1; i += word.Length)
            {
                string temp = usedText.Substring(i, i + word.Length); //Temporary debug variable.
                if (usedText.Substring(i, i + word.Length - 1) == word)
                {
                    if (wholeWordsOnly)
                    {
                        if (i - 1 > 0 && i < usedText.Length)
                        {

                        }
                        if (usedText.Substring(i - 1, i + word.Length).StartsWith(" ") && usedText.Substring(i - 1, i + word.Length).EndsWith(" "))
                        {
                            positions.Add(i);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    positions.Add(i);
                }
            }
            return positions;
        }

        public static string Replace(string text, string word, string replacement, int pos)
        {
            return text.Substring(0, pos) + replacement + word.Substring(pos + word.Length, word.Length);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UserInteractions.ParentalControls
{
    /// <summary>
    /// Respresents a filter for bad words.
    /// </summary>
    public class WordFilter
    {
        Dictionary<string, string> WordReplacements = new Dictionary<string, string>(); //This dictionary is for the clean replacements of bad words.
        List<string> BadWords = new List<string>(); //This is the list of bad words.
        List<string> LowExceptions = new List<string>();
        List<string> ModerateExceptions = new List<string>();

        string filteredWord = "";
        public WordFilter(FilteringLevel defaultFilteringLevel)
        {
            StreamWriter objBadWordList = new StreamWriter("badwords.temp"); //Create a StreamWriter object for the temporary bad-word list file.
            objBadWordList.Write(Properties.Resources.BadWordList); //Write the contents of the text file stored in Resources to the temporary file.
            objBadWordList.Close(); //Close the file.
            objBadWordList.Dispose(); //Clean up.

            StreamReader objBadWords = new StreamReader("badwords.temp"); //Create a StreamReader object for reading from the temporary file.
            List<string> lines = new List<string>(); //This the list of lines in the file.
            string line = ""; //This is for the current line in the file.
            while (line != null) //While there are still lines left to read in the file...
            {
                line = objBadWords.ReadLine(); //Set the line variable to the next line in the file.
                if (line != null) //If the line variable is not null...
                {
                    lines.Add(line); //Add the line variable to the list of lines.
                }
            }
            objBadWords.Close(); //Close the file.
            objBadWords.Dispose(); //Clean up.

            string word = "";
            string replacement = "";
            for (int i = 0; i < lines.Count; i++) //For all items in the list of lines read from the file...
            {
                if (i % 2 == 0) //If i is even...
                {
                    word = lines[i]; //Set the word string to the item at the current index.
                }
                else //Otherwise...
                {
                    replacement = lines[i]; //Set the replacement string to the item at the current index.
                    WordReplacements.Add(word, replacement); //Add a word/replacement pair to the replacements dictionary.
                }
            }

            BadWords = WordReplacements.Keys.ToList(); //Set the bad words list to the keys in the replacements dictionary.

            File.Delete("badwords.temp"); //Delete the temporary file.

            LowExceptions = new List<string>(BadWords);
            LowExceptions.Remove("nigger");
            LowExceptions.Remove("nigga");

            ModerateExceptions = new List<string>(BadWords);
            ModerateExceptions.Remove("nigger");
            ModerateExceptions.Remove("nigga");
            ModerateExceptions.Remove("fuck");
            ModerateExceptions.Remove("shit");
            ModerateExceptions.Remove("bitch");
            ModerateExceptions.Remove("bastard");
            ModerateExceptions.Remove("cunt");
            ModerateExceptions.Remove("cock");
            ModerateExceptions.Remove("dildo");

            level = defaultFilteringLevel; //Set the filtering level to the defaultFilteringLevel parameter.
        }
        public enum FilteringLevel { Low, Moderate, Strict };
        public FilteringLevel level = FilteringLevel.Low;
        public FilteringLevel Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        /// <summary>
        /// Replaces all bad words in the specified string with clean equivalents.
        /// </summary>
        /// <param name="text">The string to replace words from.</param>
        /// <returns>The modified string.</returns>
        public string MakeClean(string text)
        {
            string newText = text;
            foreach (string word in BadWords)
            {
                if (text.Contains(word))
                {
                    newText = text.Replace(word, WordReplacements[word]);
                }
            }
            return newText;
        }

        /// <summary>
        /// Gets the word filtered out by the current WordFilter instance.
        /// </summary>
        /// <returns>The word that was filtered.</returns>
        public string GetFilteredWord()
        {
            string word = filteredWord;
            filteredWord = "";
            return word;
        }

        /// <summary>
        /// Returns true if the text specified contains a bad word.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Whether or not the text specified contains a bad word.</returns>
        public bool ContainsBadWords(string text)
        {
            List<string> FilterExceptions = new List<string>();
            switch (level)
            {
                case FilteringLevel.Low:
                    FilterExceptions = LowExceptions;
                    break;
                case FilteringLevel.Moderate:
                    FilterExceptions = ModerateExceptions;
                    break;
            }
            foreach (string item in BadWords)
            {
                if (text.ToLower().Contains(item) == true && FilterExceptions.Contains(item) == false)
                {
                    filteredWord = item;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns a censored string.
        /// </summary>
        /// <param name="text">The string to censor.</param>
        /// <returns>The censored string.</returns>
        public string Censor(string text)
        {
            string censoredText = text;
            List<string> FilterExceptions = new List<string>();
            switch (level)
            {
                case FilteringLevel.Low:
                    FilterExceptions = LowExceptions;
                    break;
                case FilteringLevel.Moderate:
                    FilterExceptions = ModerateExceptions;
                    break;
            }
            foreach (string item in BadWords)
            {
                string asterisks = "";
                for (int i = 0; i < item.Length; i++)
                {
                    asterisks += "*";
                }
                censoredText = censoredText.Replace(item, asterisks);
            }
            return censoredText;
        }
    }
}

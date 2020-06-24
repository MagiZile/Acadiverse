using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.Acadiverse
{
    /// <summary>
    /// Represents a spam filter used for Acadiverse chat and submissions.
    /// </summary>
    public static class SpamFilter
    {

        static bool CheckForSpam(string text)
        {
            foreach (string s in text.Split(' '))
            {
                Debug.WriteLine(s);

                if (s.Contains("http") || text.Contains("https"))
                {
                    try
                    {
                        if (!new Uri(s).Host.Contains(".edu"))
                        {
                            return true;
                        }
                    }
                    catch (UriFormatException)
                    {
                        continue;
                    }
                }
            }
            return false;
        }

        public static bool IsSpam(ChatMessage chatMessage)
        {
            return CheckForSpam(chatMessage.MessageContents);
        }

        public static bool IsSpam(Submission submission)
        {
            return CheckForSpam(submission.Name) || CheckForSpam(submission.Description) || CheckForSpam(submission.Tags) || CheckForSpam(submission.SubmissionContents);
        }
    }
}

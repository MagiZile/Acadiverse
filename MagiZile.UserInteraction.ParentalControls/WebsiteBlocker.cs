using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.UserInteractions.ParentalControls
{
    public class WebsiteBlocker
    {
        Timer tmrBlockTimer = new Timer();
        public WebsiteBlocker()
        {
            tmrBlockTimer.Interval = 100;
            tmrBlockTimer.Tick += new EventHandler(RunTimer);
        }

        public enum WebsiteCategory { Pornography, Gambling, AdultContent, Gaming, Kids, Dating, Shopping, MaliciousWebsites, IllegalActivities, SoftwareDownloads, SocialNetworking };
        public bool active = false;
        public List<String> BlockedWords = new List<string>();

        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        private void RunTimer(object sender, EventArgs e)
        {
            BlockSites();
        }

        bool UrlContainsBlockedWords(string url)
        {
            foreach (string word in BlockedWords)
            {
                if(url.Contains(word))
                {
                    return true;
                }
            }
            return false;
        }

        void BlockSites()
        {
            const int nChars = 256;
            int handle = GetForegroundWindow();
            StringBuilder Buff = new StringBuilder(nChars);
            string windowText = "";
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                windowText = Buff.ToString();
                if (windowText.Contains("Google Chrome") == true)
                {
                    if (UrlContainsBlockedWords("") == true)
                    {
                        
                    }
                }
            }
        }

        public void StartBlocking()
        {
            active = true;
            tmrBlockTimer.Start();
        }

        public void EndBlocking()
        {
            active = false;
            tmrBlockTimer.Stop();
        }
    }
}

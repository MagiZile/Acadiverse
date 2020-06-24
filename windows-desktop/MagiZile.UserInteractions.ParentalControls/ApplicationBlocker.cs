using MagiZile.UtilityComponents;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UserInteractions.ParentalControls
{
    public class ApplicationBlocker
    {
        public enum BlockType { Whitelist, Blacklist };
        public ProcessWatcher applicationWatcher = new ProcessWatcher();
        public List<string> blockedApplications = new List<string>();
        public string blockedApplication = "";

        public BlockType blockType = BlockType.Blacklist;

        public ApplicationBlocker(List<string> blockedApplications)
        {
            this.blockedApplications = blockedApplications;
            applicationWatcher.ProcessStarted += new ProcessWatcher.ProcessEventHandler(BlockApplications);
            applicationWatcher.Start();
            foreach (Process p in Process.GetProcesses())
            {
                foreach (string item in blockedApplications)
                {
                    if (p.MainWindowTitle.Contains(item))
                    {
                        p.Kill();
                        blockedApplication = item;
                        ApplicationBlocked?.Invoke(this, new EventArgs());
                    }
                }
            }
        }
        
        public void BlockApplications(object sender, ProcessWatcher.ProcessEventArgs e)
        {
            foreach (string item in blockedApplications) //For every item in the list of blocked applications...
            {
                if (blockType == BlockType.Blacklist)
                {
                    foreach (Process p in e.RelatedProcesses)
                    {
                        if (p.MainWindowTitle.Contains(item)) //If the process related to the event matches a blocked application...
                        {
                            p.Kill(); //Kill the process associated with the event.
                            blockedApplication = item;
                            ApplicationBlocked?.Invoke(this, new EventArgs());
                        }
                    }
                }
                else
                {
                    foreach (Process p in e.RelatedProcesses)
                    {
                        if (p.MainWindowTitle.Contains(item)) //If the process related to the event does not match a whitelisted application...
                        {
                            p.Kill(); //Kill the process associated with the event.
                            blockedApplication = item;
                            ApplicationBlocked?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
        }

        public event EventHandler ApplicationBlocked;
    }
}

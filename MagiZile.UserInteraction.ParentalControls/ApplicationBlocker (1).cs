using MagiZile.UtilityComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.UserInteractions.ParentalControls
{
    public class ApplicationBlocker
    {
        public ProcessWatcher applicationWatcher = new ProcessWatcher();
        public List<string> blockedApplications = new List<string>();

        public ApplicationBlocker(List<string> blockedApplications)
        {
            this.blockedApplications = blockedApplications;
            applicationWatcher.ProcessStarted += new ProcessWatcher.ProcessEventHandler(BlockApplications);
        }

        public void BlockApplications(object sender, ProcessWatcher.ProcessEventArgs e)
        {
            foreach (string item in blockedApplications) //For every item in the list of blocked applications...
            {
                if (e.RelatedProcess.MainWindowTitle.Contains(item)) //If the process relatesd to the event matches a blocked application...
                {
                    e.RelatedProcess.Kill(); //Kill the process associated with the event.
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MagiZile.UtilityComponents
{
        public class ProcessEventArgs : EventArgs
        {
            public ProcessEventArgs(List<Process> data)
            {
                relatedProcesses = data;
                
            }

            public List<Process> relatedProcesses;

            public List<Process> RelatedProcesses => relatedProcesses;
    }
}

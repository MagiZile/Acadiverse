using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.UtilityComponents
{
    public class ProcessWatcher
    {
        readonly Timer tmrProcessWatcherInterval = new Timer(); //This is for repeating the Watch() method.
        List<Process> processes = Process.GetProcesses().ToList(); //This is the list of processes.

        public ProcessWatcher()
        {
            tmrProcessWatcherInterval.Tick += new EventHandler(Watch); //Set the timer's Tick event to the Watch() method.
            tmrProcessWatcherInterval.Interval = 1; //Set the interval to 1 millisecond.
            tmrProcessWatcherInterval.Start(); //Start the timer.
        }

        public event ProcessEventHandler ProcessStarted;
        public event ProcessEventHandler ProcessKilled;

        public delegate void ProcessEventHandler(object sender, ProcessEventArgs e);

        void Watch(object sender, EventArgs e)
        {
            List<Process> updatedProcesses = Process.GetProcesses().ToList(); //Create a variable for the updated processes list.
            if (updatedProcesses != processes) //If the process list is different from the updated version...
            {
                if (updatedProcesses.Count < processes.Count) //If the updated list is smaller, which means that a process was killed...
                {
                    Debug.WriteLine("processes.Count: " + processes.Count);
                    Debug.WriteLine("updatedProcesses.Count: " + updatedProcesses.Count);
                    ProcessKilled?.Invoke(this, new ProcessEventArgs(GetKilledProcesses(updatedProcesses))); //Invoke the ProcessKilled event with the process that was killed.
                }
                if (updatedProcesses.Count > processes.Count) //If the updated list is larger, which means that a new process was started...
                {
                    Debug.WriteLine("processes.Count: " + processes.Count);
                    Debug.WriteLine("updatedProcesses.Count: " + updatedProcesses.Count);
                    ProcessStarted?.Invoke(this, new ProcessEventArgs(GetStartedProcesses(updatedProcesses))); //Invoke the ProcessStarted event with the process that was started.
                }
            }
            processes = new List<Process>(updatedProcesses); //Replace the process list with the updated version.
        }

        public void Start()
        {
            tmrProcessWatcherInterval.Start();
        }

        public void Stop()
        {
            tmrProcessWatcherInterval.Stop();
        }

        /// <summary>
        /// Gets the process that was started when the specified process list was created.
        /// </summary>
        /// <param name="list">The list to compare the current process list to.</param>
        /// <returns></returns>
        List<Process> GetStartedProcesses(List<Process> list)
        {
            List<Process> startedProcesses = new List<Process>();
            foreach (Process item in list) //For each item in the new process list...
            {
                Debug.WriteLine(item.ProcessName);
                if (processes.Contains(item) == false) //If the current processes list does not contain the item...
                {
                    startedProcesses.Add(item);
                }
            }
            return startedProcesses;
        }

        /// <summary>
        /// Gets the process that was killed when the specified process list was created.
        /// </summary>
        /// <param name="list">The list to compare the current process list to.</param>
        /// <returns></returns>
        List<Process> GetKilledProcesses(List<Process> list)
        {
            List<Process> killedProcesses = new List<Process>();
            foreach (Process item in processes) //For each item in the current process list...
            {
                Debug.WriteLine(item.ProcessName);
                if (list.Contains(item) == false) //If the new processes list does not contain the item...
                {
                    killedProcesses.Add(item);
                }
            }
            return killedProcesses;
        }
    }
}

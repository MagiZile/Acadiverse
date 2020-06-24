using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiZile.CustomUI.EnhancedFileSelection
{
    public class FileOperation
    {
        public string source;
        public string currentDirectory;
        public string destination;
        public FileOperationType type;
        public int fileCount;
        public bool paused;

        public FileOperation(FileOperationType type, string source, string destination = "")
        {
            this.type = type;
            this.source = source;
            this.destination = destination;
            currentDirectory = destination;
        }

        public string Source
        {
            get
            {
                return source;
            }
        }

        public string Destination
        {
            get
            {
                return Destination;
            }
        }

        public FileOperationType Type
        {
            get
            {
                return type;
            }
        }

        public int FileCount
        {
            get
            {
                return fileCount;
            }
        }

        public bool Paused
        {
            get
            {
                return paused;
            }
        }

        public void Cancel()
        {
            currentDirectory = null;
        }

        public void Pause()
        {
            paused = !paused;
        }

        public void CountFiles()
        {
            try
            {
                if (!paused)
                {
                    foreach (string file in Directory.GetFiles(currentDirectory))
                    {
                        fileCount++;
                    }
                    foreach (string dir in Directory.GetDirectories(currentDirectory))
                    {
                        currentDirectory = dir;
                        CountFiles();
                    }
                }
            }
            catch (NullReferenceException)
            {
                //Do nothing; the operation was cancelled.
            }
        }
    }
}

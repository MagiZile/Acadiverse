using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagiZile.UserInteractions.Data
{
    public abstract class Project
    {
        string name;

        public Project(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract void Save(string path);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagiZile.UserInteractions.Data
{
    public class WritingProject : Project
    {
        public string name;
        public string author;

        public WritingProject(string name, string author) : base(name)
        {
            this.name = name;
            this.author = author;
        }

        public override void Save(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadiverse_Lesson_Studio
{
    public abstract class LessonComponent
    {
        string name;
        string filename;
        public LessonComponent(string name, string filename)
        {
            Name = name;
            Filename = filename;
        }

        public string Name { get => name; set => name = value; }
        public string Filename { get => filename; set => filename = value; }       
        
        public abstract void Save();
    }
}
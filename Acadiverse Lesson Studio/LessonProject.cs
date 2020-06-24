using MagiZile.Acadiverse;
using MagiZile.UserInteractions.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Acadiverse_Lesson_Studio
{
    public class LessonProject: Project
    {
        List<Scenario> scenarios;
        List<Quiz> quizzes;
        List<Worksheet> worksheets; 

        public LessonProject(string name) : base(name)
        {
            
        }

        public List<Scenario> Scenarios { get => scenarios; set => scenarios = value; }
        public List<Quiz> Quizzes { get => quizzes; set => quizzes = value; }
        public List<Worksheet> Worksheets { get => worksheets; set => worksheets = value; }

        public override void Save(string path)
        {

        }

        public override string ToString()
        {
            string s = "";
            s += "\nScenarios: ";
            foreach (Scenario scenario in Scenarios)
            {

            }
            s += "\nQuizzes: ";
            foreach (Quiz quiz in Quizzes)
            {

            }
            s += "\nWorksheets: ";
            foreach (Worksheet worksheet in Worksheets)
            {

            }
            return s;
        }
    }
}

using System.Collections.Generic;
using System.Windows.Documents;

namespace Acadiverse_Lesson_Studio
{
    public class Quiz : LessonComponent
    {
        List<QuizQuestion> questions;
        public Quiz(string name, string filename) : base(name, filename)
        {

        }

        public List<QuizQuestion> Questions { get => questions; set => questions = value; }

        public override void Save()
        {

        }
    }
}
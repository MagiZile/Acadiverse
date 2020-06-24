using System;

namespace Acadiverse_Lesson_Studio
{
    public abstract class QuizQuestion
    {
        string questionText;
        int numberOfPoints;

        public QuizQuestion(string questionText)
        {
            this.questionText = questionText;
            NumberOfPoints = 0;
        }

        public string QuestionText { get => questionText; set => questionText = value; }
        public int NumberOfPoints { get => numberOfPoints; set => numberOfPoints = value; }

        public abstract bool CorrectAnswer();
    }
}
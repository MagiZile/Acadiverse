using MagiZile.Acadiverse;
using MagiZile.UserInteractions.ParentalControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadiverse_Lesson_Studio
{
    public partial class FrmPublish : Form
    {
        public FrmPublish()
        {
            InitializeComponent();
        }

        public LessonProject project;
        private void BgwBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {           
            WordFilter wordFilter = new WordFilter(WordFilter.FilteringLevel.Strict);
            if (wordFilter.ContainsBadWords(txtTitle.Text, true)
                || wordFilter.ContainsBadWords(txtDescription.Text, true)
                || wordFilter.ContainsBadWords(txtTags.Text, true))
            {
                goto ProjectRejected;
            }
            foreach (Scenario scenario in project.Scenarios)
            {
                if (wordFilter.ContainsBadWords(scenario.Name, true))
                {
                    goto ProjectRejected;
                }
            }
            foreach (Worksheet worksheet in project.Worksheets)
            {
                if (wordFilter.ContainsBadWords(worksheet.Name, true))
                {
                    goto ProjectRejected;
                }
                else
                {

                }
            }
            foreach (Quiz quiz in project.Quizzes)
            {
                if (wordFilter.ContainsBadWords(quiz.Name, true))
                {
                    goto ProjectRejected;
                }
                foreach (QuizQuestion question in quiz.Questions)
                {
                    if (wordFilter.ContainsBadWords(question.QuestionText))
                    {
                        goto ProjectRejected;
                    }
                }
            }

        ProjectRejected:
            Globals.ShowErrorMessage(Properties.Resources.str_project_rejected);
        }
    }
}

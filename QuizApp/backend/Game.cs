using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public Game()
        {
            Random = new Random();
            CreateQuestions();
            AllCategories = Questions.Select(x => x.Category).Distinct().ToList();
            CurrentCategory = AllCategories[CurrentCategoryIndex];
        }

        public List<Question> Questions { get; set; }
        public Question CurrentQuestion { get; set; }
        public int CurrentCategory { get; set; }
        public Random Random { get; set; }
        public int PlayerPoints { get; set; }
        public List<int> AllCategories { get; set; }
        public int CurrentCategoryIndex { get; set; }

        public void CreateQuestions()
        {
            Questions =  QuestionCreator.CreateQuestions();
        }

        public void DrawQuestion()
        {
            var questionsOfCategory = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var random = Random.Next(0, questionsOfCategory.Count);
            var question = questionsOfCategory[random];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();
            
            for (int i = 0; i < question.Answers.Count; i++)
            {
                question.Answers[i].DisplayOrder = i + 1;
            }
            
            
            CurrentQuestion = question;
        }

        public bool IsUserAnswerCorrect(int userDigit)
        {
            var userAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.DisplayOrder == userDigit);
            var isCorrect = userAnswer.IsCorrect;
            if (isCorrect)
            {
                PlayerPoints += CurrentQuestion.Category;
            }


            return isCorrect;
        }

        public bool IsLastQuestion()
        {
            if (CurrentCategoryIndex >= AllCategories.Count - 1)
            {
                return true;
            }
            else
            {
                CurrentCategoryIndex++;
                CurrentCategory = AllCategories[CurrentCategoryIndex];
                return false;
            }
        }



    }
}

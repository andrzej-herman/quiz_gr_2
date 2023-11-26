using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; } = 100;

        public void CreateQuestions()
        {
            Questions = new List<Question>();
            var q1 = new Question();
            q1.Answers = new List<string>();
            q1.Category = 100;
            q1.Content = "Jak miał na imię Einstein?";
            q1.Answers.Add("Albert");
            q1.Answers.Add("Adam");
            q1.Answers.Add("Tom");
            q1.Answers.Add("John");
            Questions.Add(q1);


            var q2 = new Question();
            q2.Answers = new List<string>();
            q2.Category = 200;
            q2.Content = "Jaka jest stolica Polski?";
            q2.Answers[0] = "Warszawa";
            q2.Answers[1] = "Łódź";
            q2.Answers[2] = "Toruń";
            q2.Answers[3] = "Poznań";
            Questions.Add(q2);
        }

        public Question DrawQuestion()
        {
            return Questions[0];
        }

    }
}

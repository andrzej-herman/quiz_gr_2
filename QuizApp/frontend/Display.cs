using QuizApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.frontend
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Witaj w Quizie");
            Console.WriteLine(" Spróbuj odpowiedź na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ... ");
            Console.ReadLine();
        }


        public static int DisplayQuestion(Question question)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($" {answer.Id}. {answer.Content}");
            }

            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Yellow;
            // zablokowanie wpisania czegokolwiek innrgo niż numer odpowiedzi
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ... ");
            Console.ForegroundColor = ConsoleColor.White;

            return int.Parse(Console.ReadLine());
        }


        public static void GameOverText()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(" Niestety, to nie jest poprawna odpowiedź.");
            Console.WriteLine(" KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void GoodAnswerText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(" Brawo, to jest poprawna odpowiedź !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}

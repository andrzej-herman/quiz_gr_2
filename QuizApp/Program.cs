using QuizApp.backend;
using QuizApp.frontend;

var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
game.DrawQuestion();
var userDigit = Display.DisplayQuestion(game.CurrentQuestion);
var isCorrect = game.IsUserAnswerCorrect(userDigit);

if (isCorrect)
{
    Display.GoodAnswerText();

}
else
{
    Display.GameOverText();
}






Console.ReadLine();
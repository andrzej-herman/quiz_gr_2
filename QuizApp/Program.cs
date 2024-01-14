using QuizApp.backend;
using QuizApp.frontend;

var game = new Game();
Display.DisplayWelcome();

while (true)
{
    game.DrawQuestion();
    var userDigit = Display.DisplayQuestion(game.CurrentQuestion);
    var isCorrect = game.IsUserAnswerCorrect(userDigit);

    if (isCorrect)
    {
        if (game.IsLastQuestion())
        {
            Display.SuccessText(game.PlayerPoints);
            break;
        }
        else
        {
            Display.GoodAnswerText(game.CurrentQuestion.Category);
        }
    }
    else
    {
        Display.GameOverText();
        Console.ReadLine();
        break;
    }
}


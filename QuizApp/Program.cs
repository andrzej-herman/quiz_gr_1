using QuizApp.backend;
using QuizApp.fronted;

var game = new Game();
Display.DisplayWelcome();

while (true)
{
    game.DrawQuestion();
    var number = Display.DisplayQuestion(game.CurrentQuestion);
    if (game.IsCorrectAnswer(number))
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
        break;
    }
}












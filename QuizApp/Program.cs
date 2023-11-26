using QuizApp.backend;
using QuizApp.fronted;
var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
var question = game.DrawQuestion();

Console.WriteLine();


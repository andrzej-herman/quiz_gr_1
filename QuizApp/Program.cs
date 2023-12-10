using QuizApp.backend;
using QuizApp.fronted;

var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
var question = game.DrawQuestion();
var number = Display.DisplayQuestion(question);

// tylko testowo
// zmienimy te logikę na następnych zajęciach
bool ok = false;

foreach (var answer in question.Answers)
{
    if (answer.Id == number)
    {
        if (answer.IsCorrect == true)
        {
            ok = true;
        }
    }
}

if (ok == true)
{
    // narazie
    Console.WriteLine(" HURRA tO PRAWIDŁOWA ODPOWIEDŻ !!!");
}
else
{
    Display.GameOver(); 
}










Console.ReadLine();
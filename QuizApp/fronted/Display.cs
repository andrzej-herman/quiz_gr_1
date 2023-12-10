using QuizApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.fronted
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Witaj w grze Quiz Grupy 1");
            Console.WriteLine(" Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ...");
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
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ");
            // musimy zmusić gracza żeby wcisnął albo 1, 2, 3 lub 4
            return int.Parse(Console.ReadLine());
        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Niestety, to nie jest prawidłowa odpowiedź.");
            Console.WriteLine();
            Console.WriteLine(" Koniec gry !!!");
            Console.WriteLine();
            Console.WriteLine(" Możesz zagrać jeszcze raz");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

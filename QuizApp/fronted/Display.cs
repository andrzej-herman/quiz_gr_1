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
            Console.WriteLine(" Witaj w grze Quiz Grupy 1");
            Console.WriteLine(" Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ...");
            Console.ReadLine();
        }
    }
}

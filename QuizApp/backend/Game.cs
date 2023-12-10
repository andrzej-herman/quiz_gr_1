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
            // stworzyć prawidzwą bazę pytań
            Questions = new List<Question>();

            var q1 = new Question();
            q1.Category = 100;
            q1.Content = "Jak miał na imię Einstein?";

            var a1 = new Answer();
            a1.Id = 1;
            a1.Content = "Albert";
            a1.IsCorrect = true;
            q1.Answers.Add(a1);

            var a2 = new Answer();
            a2.Id = 2;
            a2.Content = "Jakub";
            q1.Answers.Add(a2);

            var a3 = new Answer();
            a3.Id = 3;
            a3.Content = "Tom";
            q1.Answers.Add(a3);

            var a4 = new Answer();
            a4.Id = 4;
            a4.Content = "Zenek";
            q1.Answers.Add(a4);

          
            Questions.Add(q1);
        }

        public Question DrawQuestion()
        {
            // naprawdę losować pytanie
            return Questions[0];
        }
    }
}

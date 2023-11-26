﻿using System;
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
            q1.Category = 100;
            q1.Content = "Jak miał na imię Einstein?";
            q1.Answer1 = "Albert";
            q1.Answer2 = "Jakub";
            q1.Answer3 = "Tom";
            q1.Answer4 = "John";
            Questions.Add(q1);

            var q2 = new Question();
            q2.Category = 200;
            q2.Content = "Jaka jest stolica Chile?";
            q2.Answer1 = "Santigo";
            q2.Answer2 = "Bogota";
            q2.Answer3 = "Caracass";
            q2.Answer4 = "Pabiance";
            Questions.Add(q2);

        }

        public Question DrawQuestion()
        {
            return Questions[0];
        }
    }
}
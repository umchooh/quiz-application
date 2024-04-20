using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameApp2024
{
    internal class Question
    {
        public int Id { get; set; }
        public string Questions { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }
    }
}

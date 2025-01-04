using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string header, string body, int mark, string[] answers, int correctAnswerIndex)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public bool CheckAnswer(int userAnswer)
        {
            return userAnswer == CorrectAnswerIndex + 1;
        }
    }



}

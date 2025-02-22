using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Exam02
{
    internal class MCQ:Question
    {
        public MCQ(string body, int mark, List<Answer> answers, Answer rightAnswer) :
           base("Multiple Choice Question:", body, mark, answers, rightAnswer)
        { }
        public override string ToString()
        {
         return   $"{Header}\n{Body}\nMarks: {Mark}\nAnswers:\n{string.Join("\n", AnswerList)}";
        }





    }
}

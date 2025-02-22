using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Exam02
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int mark, bool isTrue) :
           base("T/F", body, mark, GenerateAnswers(), GetRightAnswer(isTrue))
        { }

        private static List<Answer> GenerateAnswers()
        {
            return new List<Answer>
            {
                new Answer(0, "False"),
                new Answer(1, "True")
            };
        }
        private static Answer GetRightAnswer(bool isTrue)
        {
            return isTrue ? new Answer(1, "True") : new Answer(0, "False");
        }

        public override string ToString() =>
            $"{Header}\n{Body}\nMarks: {Mark}\nAnswers:\n{string.Join("\n", AnswerList )}";

    }


}


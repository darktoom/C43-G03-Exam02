using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Exam02
{
    internal abstract class Question
    {
        private string v;
        private List<Answer> answers;
        private Answer answer;

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public List<Answer> AnswerList { get; set; }
        public int RightAnswer {  get; set; }

     protected internal Question(string Header,string Body,int Mark,List<Answer>AnswerList,int RightAnswer) { 
        this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
            this.AnswerList = AnswerList;
            this.RightAnswer = RightAnswer;
        
        
        }

        protected Question(string v, string body, int mark, List<Answer> answers, Answer answer)
        {
            this.v = v;
            Body = body;
            Mark = mark;
            this.answers = answers;
            this.answer = answer;
        }
    }
}

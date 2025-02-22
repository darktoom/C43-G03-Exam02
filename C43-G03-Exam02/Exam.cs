using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Exam02
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NoOfQuestion { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int time)
        {
            Time = time;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();


    }
}

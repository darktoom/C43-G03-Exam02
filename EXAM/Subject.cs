using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Subject
    {
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(string name)
        {
            Name = name;
        }

        public void AssignExam(Exam exam)
        {
            Exam = exam;
        }
    }

}

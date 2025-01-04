using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{

    public class Exam
    {
        public string ExamType { get; set; }
        public int Time { get; set; }
        public List<Question> Questions { get; set; }
        public int TotalScore { get; private set; }

        public Exam(string examType, int time)
        {
            ExamType = examType;
            Time = time;
            Questions = new List<Question>();
            TotalScore = 0;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void StartExam()
        {
            Console.WriteLine($"{ExamType} Exam:");
            foreach (var question in Questions)
            {
                Console.WriteLine($"{question.Header}: {question.Body} (Mark: {question.Mark})");
                for (int i = 0; i < question.Answers.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                }

                Console.Write("Enter your answer (1/2/3/...): ");
                int userAnswer;
                while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer > question.Answers.Length)
                {
                    Console.Write("Invalid input. Please enter a valid option: ");
                }

                if (question.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Correct!");
                    TotalScore += question.Mark;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                if (ExamType == "Practical")
                {
                    Console.WriteLine($"Correct Answer: {question.Answers[question.CorrectAnswerIndex]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Your Total Score: {TotalScore}/{Questions.Sum(q => q.Mark)}");
        }
    }


}

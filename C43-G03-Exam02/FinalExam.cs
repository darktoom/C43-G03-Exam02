using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time) : base(time) { }
        public override void ShowExam()
        {
            int totalScore = 0;
            int totalPossible = Questions.Sum(q => q.Mark);

            Console.WriteLine($"Final Exam ({Time} minutes)\n");

            foreach (var question in Questions)
            {
                bool showError = false;
                int userAnswerId;



                do
                {
                    Console.WriteLine(question.ToString());

                    if (showError)
                    {
                        Console.WriteLine("Answer does not exist.");
                    }

                    Console.Write("Enter your answer (number): ");
                    string input = Console.ReadLine();

                    bool isInteger = int.TryParse(input, out userAnswerId);
                    bool answerExists = isInteger && question.AnswerList.Any(a => a.AnswerId == userAnswerId);
                    showError = !answerExists;

                } while (showError);

                if (userAnswerId == question.RightAnswer)
                {
                    totalScore += question.Mark;
                }

                Console.WriteLine();
            }
            Console.WriteLine($"Exam completed. Your total score: {totalScore}/{totalPossible}");


        }
    }
    }
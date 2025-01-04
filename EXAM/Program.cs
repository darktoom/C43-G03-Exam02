namespace EXAM
{



    internal class Program
    {

      
        
            static void Main(string[] args)
            {
                // Create a subject
                Subject math = new Subject("Mathematics");

                // Create an exam (Final or Practical)
                Exam finalExam = new Exam("Final", 60);

                // Add questions to the exam
                finalExam.AddQuestion(new Question(
                    "Question 1",
                    "What is 2+2?",
                    5,
                    new string[] { "3", "4", "5" },
                    1 // Correct answer is index 1 (4)
                ));

                finalExam.AddQuestion(new Question(
                    "Question 2",
                    "The Earth is flat.",
                    3,
                    new string[] { "True", "False" },
                    1 // Correct answer is index 1 (False)
                ));

                // Assign the exam to the subject
                math.AssignExam(finalExam);

                // Start the exam
                math.Exam.StartExam();
            }
        

    }
}
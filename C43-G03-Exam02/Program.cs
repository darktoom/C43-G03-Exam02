namespace C43_G03_Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject History = new Subject()
            {
                SubjectId = 144,
                SubjectName = "History",
            };

            FinalExam final = new FinalExam(120);

            // T - F Questions
            final.Questions.Add(new TrueFalseQuestion("is donald trump the President of USA ", 1, true));
            final.Questions.Add(new TrueFalseQuestion("Cleopatra was the first female pharaoh of Egypt", 1, false));
            final.Questions.Add(new TrueFalseQuestion("The Great Pyramid of Giza was built during the Middle Kingdom.", 1, false));
            final.Questions.Add(new TrueFalseQuestion("Papyrus was used by ancient Egyptians to make paper.", 1, true));

            // MCQ Questions
            final.Questions.Add(new MCQ("Which year did Egypt gain independence from British rule?", 2,
                new List<Answer>
                {
                    new Answer(1, "1914"),
                    new Answer(2, "1922" ),
                    new Answer(3, "1936"),
                    new Answer(4, "1958"),
                },
                new Answer(2, "1922")
            ));

            final.Questions.Add(new MCQ("Who was the first President of Egypt after the 1952 revolution?", 2,
                new List<Answer>
                {
                    new Answer(1, "Hosni Mubarak"),
                    new Answer(2, "Gamal Abdel Nasser "),
                    new Answer(3, "Anwar Sadat"),
                    new Answer(4, "Muhammad Naguib"),
                },
                new Answer(4, "Muhammad Naguib")
            ));

            final.Questions.Add(new MCQ("hich major canal, crucial for global trade, is located in Egypt?", 2,
                new List<Answer>
                {
                    new Answer(1, "Panama Canal"),
                    new Answer(2, "Suez Canal "),
                    new Answer(3, "Grand Canal"),
                    new Answer(4, "Corinth Canal"),
                },
                new Answer(2, "Mars")
            ));

            History.CreateExam(final);
            History.Exam.ShowExam();
        }
    }


}
    

